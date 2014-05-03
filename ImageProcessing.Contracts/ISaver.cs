using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ImageProcessing.Contracts
{
    public interface ISaver
    {
        void Save(string path, Stream stream);
    }
}
