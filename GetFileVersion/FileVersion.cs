using System.Diagnostics;

namespace GetFileVersion
{
    public class FileVersion
    {
        private static string _PathToFile;

        public FileVersion(string path)
        {
            _PathToFile = path;
        }

        public static string Get()
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(_PathToFile);
            return versionInfo.ProductVersion;
        }
    }
}
