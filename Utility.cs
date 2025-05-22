using System;

namespace Helpers
{
    public static class Utility
    {
        /// <summary>
        ///   Different machines will need to output to different places due to local policies
        ///   not a good idea to have the durectory as a konstant
        /// </summary>
        /// <returns></returns>
        public static string OutputDirectory()
        {
            string outputDir;

            outputDir = @"c:\public\GridStat\";

            return outputDir;
        }

        public static string HostName()
        {
            return Environment.MachineName;
        }

        public static decimal Percent(
            int quotient, 
            int divisor)
        {
            return 100 * Average(quotient, divisor);
        }

        public static decimal Average(int quotient, int divisor)
        {
            //  need to do decimal other wise INT() will occur
            if (divisor == 0) return 0.0M;
            return (Decimal.Parse(quotient.ToString()) /
                Decimal.Parse(divisor.ToString()));
        }

        public static void Announce(string rpt, int indent = 3)
        {
            var theLength = rpt.Length + indent;
            rpt = rpt.PadLeft(theLength, ' ');
            Console.WriteLine(rpt);
        }

        public static void CopyFile(
            string fromFile, 
            string targetFile)
        {
            var sourcePath = OutputDirectory();
            var targetPath = OutputDirectory();
            var sourceFile = System.IO.Path.Combine(sourcePath, fromFile);
            var destFile = System.IO.Path.Combine(targetPath, targetFile);
            // To copy a file to another location and
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);
        }

        public static bool IsOdd(int number) => number % 2 != 0;
        
        public static bool IsEven(int number) => !IsOdd(number);
    }
}