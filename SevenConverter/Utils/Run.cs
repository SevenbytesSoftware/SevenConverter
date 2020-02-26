using System.Diagnostics;

namespace SevenConverter.Utils
{
    public static class Execute
    {
        public static bool RunApp(string commandLine, string arguments)
        {
            bool result;

            // for debug purposes
            //Clipboard.SetText(commandLine + " " + arguments);

            using (Process app = new Process())
            {
                app.StartInfo.FileName = commandLine;
                app.StartInfo.Arguments = arguments;
                app.StartInfo.UseShellExecute = false;
                app.StartInfo.CreateNoWindow = false;
                app.EnableRaisingEvents = true;
                app.Start();
                app.WaitForExit();
                result = true;
            }
            return result;
        }
    }
}