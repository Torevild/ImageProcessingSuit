using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class BasicImageSerializer : IImageSerializer
    {
        public Image Serialize(MemoryStream stream)
        {
            return Image.FromStream(stream);
        }

        public MemoryStream Deserialize(Image image)
        {
            var result = new MemoryStream();
            image.Save(result, ImageFormat.Png);
            return result;
        }
    }
}
