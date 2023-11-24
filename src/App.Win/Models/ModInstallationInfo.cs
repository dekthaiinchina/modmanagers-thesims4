﻿namespace LwdGeeks.ModManagers.TheSims4.App.Win.Models
{
    public class ModInstallationInfo
    {
        public bool Shared { get; set; }
        public string Name { get; set; }
        public string SourceFile { get; set; }
        public string InstallationPath { get; set; }

        public static ModInstallationInfo Create(FileInfo file, string installationPath, bool shared)
        {
            return new()
            {
                Name = file.Name,
                SourceFile = file.FullName,
                InstallationPath = Path.Combine(installationPath, file.Name),
                Shared = shared
            };
        }
    }
}