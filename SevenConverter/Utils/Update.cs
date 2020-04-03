using System;
using System.IO;
using System.Net;
using System.Text;

namespace SevenConverter.Utils
{
    public class Update
    {
        public Update(string url)
        {
            URL = url;
        }

        public string URL { get; set; }

        public string AvailableVersion { get; set; }

        public bool Check(string currentVersion)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            using (WebClient web = new WebClient())
            {                
                string page = web.DownloadString(URL);
                string startPattern = "/releases/tag/";
                int loc1 = page.IndexOf(startPattern, 0);
                if (loc1 != -1)
                {
                    loc1 += startPattern.Length;
                    char[] charPatterns = { '"', '&' };
                    int loc2 = page.IndexOfAny(charPatterns, loc1);
                    if (loc2 != -1)
                    {
                        AvailableVersion = page.Substring(loc1, loc2 - loc1);
                        return String.Compare(AvailableVersion, currentVersion) < 0;
                    }
                    else 
                        throw new Exception(Properties.strings.ErrorOnVersionLookup);
                }
                else
                    throw new Exception(Properties.strings.VersionNotFound);
            }
        }
    }
}
