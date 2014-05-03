using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class ImageSerializerFactory
    {
        public static IImageSerializer Get(SerializerTypes serializerTypes)
        {
            switch (serializerTypes)
            {
                case SerializerTypes.BasicSerializer:
                    return new BasicImageSerializer();
            }

            return new DefaultImageSerializer();
        }
    }
}
