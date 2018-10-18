using System;
using System.IO;

namespace PlayMeFileExtensionUpdater
{
    internal class ProcessDirectory
    {
        private readonly string newFileExtension;
        private readonly string pathToUpdate;

        public ProcessDirectory(string newFileExtension, string pathToUpdate)
        {
            this.newFileExtension = newFileExtension;
            this.pathToUpdate = pathToUpdate;
        }

        public void Go()
        {
            if (string.IsNullOrEmpty(newFileExtension) || string.IsNullOrEmpty(pathToUpdate))
                return;

            foreach (var path in Directory.EnumerateDirectories(pathToUpdate))
            {
                foreach (var file in Directory.GetFiles(path)) //what about sub-dirs my bru?
                {
                    var fi = new FileInfo(file);
                    if (!fi.Extension.Equals(".pme"))
                    {
                        fi.MoveTo(Path.Combine(path, fi.Name.Replace(fi.Extension, "") + "." + newFileExtension));
                        Console.WriteLine(file);
                    }
                }
            }
        }
    }
}