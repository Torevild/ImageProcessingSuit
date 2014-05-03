using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ImageProcessing.Contracts
{
    public interface IImageSerializer
    {
        Image Serialize(MemoryStream stream);

        MemoryStream Deserialize(Image image);
    }
}
