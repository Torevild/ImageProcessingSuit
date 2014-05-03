using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class ImageFilterFactory
    {
        public static IImageFilter Get(FilterType filterType)
        {
            switch (filterType)
            {
                case FilterType.BlackAndWhite:
                    return new BlackAndWhiteFilter();
                    
            }
            return new DefaultImageFilter();
        }
    }
}
