using System;

namespace PlayMeFileExtensionUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            //pop this into a json config file you lazy bastard
            var newFileExtension = "pme";
            var pathToUpdate = @"C:\Data\Carl\pluralsight\angular-2-getting-started-update\";

            new ProcessDirectory(newFileExtension, pathToUpdate)
                .Go();

            Console.WriteLine("Hello New Zealand!");
        }
    }
}
