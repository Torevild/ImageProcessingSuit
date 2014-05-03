using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class FileSystemLoader:ILoader
    {
        public MemoryStream Load(string path)
        {
            var result = new MemoryStream();

            using (var fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var bufferedStream = new BufferedStream(fileStream))
            {
                bufferedStream.CopyTo(result);
            }
            
            return result;

        }
    }
}
