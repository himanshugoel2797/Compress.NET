using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compress.NET.LowLevel
{
    public enum AMD_TC_ERROR
    {
        OK = 0,                            //< Ok.
        ABORTED,                           //< The conversion was aborted.
        INVALID_SOURCE_TEXTURE,        //< The source texture is invalid.
        INVALID_DEST_TEXTURE,          //< The destination texture is invalid.
        UNSUPPORTED_SOURCE_FORMAT,     //< The source format is not a supported format.
        UNSUPPORTED_DEST_FORMAT,       //< The destination format is not a supported format.
        SIZE_MISMATCH,                 //< The source and destination texture sizes do not match.
        UNABLE_TO_INIT_CODEC,          //< AMDCompress was unable to initialize the codec needed for conversion.
        ERR_GENERIC                        //< An unknown error occurred.
    }
}
