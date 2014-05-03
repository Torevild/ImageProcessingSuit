using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageProcessing.Contracts
{
    public enum SourceType
    {
        Default,
        FileSystem,
        Web,
        FTP
    }

    public enum FilterType
    {
        BlackAndWhite
    }
}
