using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing.Contracts;

namespace ImageProcessingSuit
{
    static class ImageLoaderFactory
    {
        public static ILoader Get(SourceType sourceType)
        {
            switch (sourceType)
            {
                case SourceType.FileSystem:
                    return new FileSystemLoader();
                case SourceType.Web:
                    break;
                case SourceType.FTP:
                    break;
            }
            return new DefaultLoader();
        }
    }
}
