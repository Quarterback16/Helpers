namespace Helpers
{
    public static class ConfigHelper
    {
        public static string DropboxFolder()
        {
            var dropboxfolder = System.Configuration.ConfigurationManager
                .AppSettings.Get("DropboxFolder");
            if (Utility.HostName().ToUpper().Equals("MAHOMES"))
            {
                dropboxfolder = System.Configuration.ConfigurationManager
                    .AppSettings.Get("DropboxFolderMahomes");
            }
            return dropboxfolder;
        }

        public static string ObsidianFolder() =>

            $"{DropboxFolder()}Obsidian\\ChestOfNotes\\";

        public static string JsonFolder() =>

            $"{DropboxFolder()}JSON\\";

        public static string CsvFolder() =>

            $"{DropboxFolder()}CSV\\";

        public static string YahooXmlFile() =>

            $"{DropboxFolder()}GridStat\\XML\\YahooOutput.xml";

        public static string XmlFolder() =>

            $"{DropboxFolder()}GridStat\\XML\\";

        public static string PlayerCsvFile(string season) =>

            $"{CsvFolder()}PlayerCsv-{season}.csv";

        public static string AdpCsvFile(string season) =>

            $"{CsvFolder()}ADP-{season}.csv";
    }
}
