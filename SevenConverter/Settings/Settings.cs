using System;

namespace SevenConverter
{
    [Serializable]
    public class Settings
    {
        public string lastSourcePath = "";
        public int outputVideoFormat = 0;
        public int outputAudioCodec = 0;
        public int outputVideoCodec = 0;
        public string outputAudioFreq = "44100";
        public string outputAudioQuality = "320k";
    }
}