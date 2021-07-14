using System;
using System.Collections.Generic;
using System.IO;

namespace MATPicker
{
    class FileCollector
    {
        public static void CollectFilesForExport(HashSet<string> filePaths)
        {
            foreach (var filePath in filePaths)
            {
                getFile(filePath);
            }
        }

        private static void getFile(string filePath)
        {
            filePath = filePath.Replace("/", @"\");
            string relativePath = Path.GetDirectoryName(filePath);
          
            Directory.CreateDirectory(Config.ExportFolder + relativePath);

            string tryModFolder = Config.ModFolder + filePath;
            string tryBaseFolder = Config.BaseFolder + filePath;
            string destFile = Config.ExportFolder + filePath;

            if (File.Exists(tryModFolder))
            {
                File.Copy(tryModFolder, destFile, true);
            }
            else if (File.Exists(tryBaseFolder))
            {
                File.Copy(tryBaseFolder, destFile, true);
            }
            else
            {
                Log.AppendError($"Unable to locate: {filePath}");
            }

        }
    }
}
