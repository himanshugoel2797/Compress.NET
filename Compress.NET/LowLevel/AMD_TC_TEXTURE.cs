using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Compress.NET.LowLevel
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AMD_TC_TEXTURE
    {
        public int dwSize;
        public int dwWidth;
        public int dwHeight;
        public int dwPitch;
        public AMD_TC_FORMAT format;
        public int dwDataSize;
        public byte pData;
    }
}
