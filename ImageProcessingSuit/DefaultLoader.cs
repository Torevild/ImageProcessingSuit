using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class DefaultLoader : ILoader
    {
        public MemoryStream Load(string path)
        {
            return null;
        }
    }
}
