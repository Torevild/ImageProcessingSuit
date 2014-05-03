using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const string sourcePicturePath = @"d:\example_image.png";

                const string destinationPicturePath = @"d:\example_image2.png";

                var imageLoader = ImageLoaderFactory.Get(SourceType.FileSystem);
                var basicImageSerializer = ImageSerializerFactory.Get(SerializerTypes.BasicSerializer);

                var imageFilter = ImageFilterFactory.Get(FilterType.BlackAndWhite);

                var imageSaver = ImageSaverFactory.Get(SourceType.FileSystem);

                Image image;

                using (var stream = imageLoader.Load(sourcePicturePath))
                {
                    image = basicImageSerializer.Serialize(stream);
                }

                imageFilter.Apply(image);

                using (var stream = basicImageSerializer.Deserialize(image))
                {
                    imageSaver.Save(destinationPicturePath, stream);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key for exit");
            Console.ReadLine();
        }
    }
}
