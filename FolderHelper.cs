namespace Helpers
{
    public static class FolderHelper
    {
        public static string GetObsidianStemFolder() =>

            $"{DropboxFolder()}\\Obsidian\\ChestOfNotes\\";

        public static string GetObsidianNflStemFolder() =>

            $"{DropboxFolder()}\\Obsidian\\ChestOfNotes\\01 - nfl\\";

        public static string GetObsidianYahooStemFolder() =>

            $"{DropboxFolder()}\\Obsidian\\ChestOfNotes\\02 - Yahoo\\";

        public static string GetObsidianGridstatsStemFolder() =>

            $"{DropboxFolder()}\\Obsidian\\ChestOfNotes\\02 - GridStats\\";


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

            System.Configuration.ConfigurationManager
                .AppSettings.Get(
                    nameof(ObsidianFolder));

        public static string YahooXmlFile() =>

            System.Configuration.ConfigurationManager
                .AppSettings.Get(
                    nameof(YahooXmlFile));

        public static string RetroFolder()
        {
            if (Utility.HostName() == "MAHOMES")
                return $"{MahomesRoot()}\\Dropbox\\Obsidian\\ChestOfNotes\\02 - GridstatsRetro\\";

            return "d:\\Dropbox\\Obsidian\\ChestOfNotes\\02 - GridstatsRetro\\";
        }

        public static string EventsFileGs21()
        {
            if (Utility.HostName() == "MAHOMES")
                return $"{MahomesRoot()}\\Dropbox\\JSON\\RetroEvents-GS21.json";
            return "d:\\dropbox\\JSON\\RetroEvents-GS21.json";

        }

        public static string EventsFileGs22()
        {
            if (Utility.HostName() == "MAHOMES")
                return $"{MahomesRoot()}\\Dropbox\\JSON\\RetroEvents.json";
            return "d:\\dropbox\\JSON\\RetroEvents.json";
        }

        public static string PlayerCsvFile(string season) =>

            $"{CsvFolder()}\\PlayerCsv-{season}.csv";



        public static string CsvFolder()
        {
            if (Utility.HostName().ToUpper() == "MAHOMES")
                return $"{MahomesRoot()}\\Dropbox\\CSV\\";

            return $"{ConfigHelper.CsvFolder()}";
        }

        private static string MahomesRoot() => "C:\\Users\\quart\\";

        public static string GameLogFolder()
        {
            if (Utility.HostName() == "MAHOMES")
                return $"{MahomesRoot()}\\Dropbox\\apps\\gamelog\\";
            return $"{ConfigHelper.DropboxFolder()}apps\\gamelog\\";
        }

        public static string JsonFolder()
        {
            if (Utility.HostName() == "MAHOMES")
                return $"{MahomesRoot()}\\Dropbox\\JSON\\";

            return $"{ConfigHelper.JsonFolder()}";
        }

        public static string PlayerMarkdownFolder() =>
             Utility.HostName() == "MAHOMES"
             ? $"{MahomesRoot()}\\Dropbox\\Obsidian\\ChestOfNotes\\01 - nfl\\players\\"
             : $"{ConfigHelper.ObsidianFolder()}01 - nfl//players//";
    }
}
