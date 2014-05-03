using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageProcessing.Contracts
{
    public interface IImageFilter
    {
        void Apply(Image inputImage);
    }
}
