using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class DefaultImageSerializer : IImageSerializer
    {
        public Image Serialize(MemoryStream stream)
        {
            return new Bitmap(1, 1);
        }

        public MemoryStream Deserialize(Image image)
        {
            return new MemoryStream();
        }
    }
}
