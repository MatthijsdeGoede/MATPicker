namespace MATPicker
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Picker
    {
        // TODO: add support for searching PMG/PMD/PMC files with same name and copying them over.
        public static void Pick()
        {
            HashSet<string> materialFiles = new HashSet<string>();
            HashSet<string> tobjFiles = new HashSet<string>();
            HashSet<string> ddsFiles = new HashSet<string>();
            string[] filesToPickFor = Config.SingleFile ? new string[]{ Config.OpenedFile } : Directory.GetFiles(Config.OpenedFile, "*.pmd", SearchOption.AllDirectories);

            foreach (var file in filesToPickFor)
            {
                HashSet<string> materialFilesFromSinglePmd = FileParser.CollectMaterials(file);
                HashSet<string> tobjFilesFromMats = FileParser.CollectTobjs(materialFilesFromSinglePmd);
                if (Config.PickMatFiles) {
                    materialFiles.UnionWith(materialFilesFromSinglePmd);
                }
                if (Config.PickTobjFiles)
                {                    
                    tobjFiles.UnionWith(tobjFilesFromMats);
                }
                if (Config.PickDdsFiles)
                {
                    HashSet<string> ddsFilesFromTobjs = FileParser.CollectDdsFiles(tobjFilesFromMats);
                    ddsFiles.UnionWith(ddsFilesFromTobjs);
                }
            }

            FileCollector.CollectFilesForExport(materialFiles);
            FileCollector.CollectFilesForExport(tobjFiles);
            FileCollector.CollectFilesForExport(ddsFiles);

            LogPickedFiles(materialFiles, tobjFiles, ddsFiles);
        }

        private static void LogPickedFiles(HashSet<string> materialFiles, HashSet<string> tobjFiles, HashSet<string> ddsFiles)
        {
            if (Config.PickMatFiles) 
            {
                Log.Append("\nFollowing MAT files were picked:");
                
                foreach (var item in materialFiles)
                {
                    Log.Append(item);
                }
            }            

            if (Config.PickTobjFiles)
            {
                Log.Append("\nFollowing TOBJ files were picked:");

                foreach (var item in tobjFiles)
                {
                    Log.Append(item);
                }

            }

            if (Config.PickDdsFiles)
            {
                Log.Append("\nFollowing DDS files were picked:");

                foreach (var item in ddsFiles)
                {
                    Log.Append(item);
                }
            }
        }
    }
}
