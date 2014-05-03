using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    class ImageSaverFactory
    {
        public static ISaver Get(SourceType sourceType)
        {
            switch (sourceType)
            {

                case SourceType.FileSystem:
                    return new FileSystemSaver();
                case SourceType.Web:
                    break;
                case SourceType.FTP:
                    break;
            }
            return new DefaultSaver();
        }
    }
}
