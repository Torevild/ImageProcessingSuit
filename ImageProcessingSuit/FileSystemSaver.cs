using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class FileSystemSaver : ISaver
    {
        public void Save(string path, Stream stream)
        {
            using (var fileStream = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite))
            {
                stream.Position = 0;
                stream.CopyTo(fileStream);
            }

        }
    }
}
