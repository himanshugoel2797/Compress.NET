using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compress.NET.LowLevel
{
    public enum AMD_TC_Speed
{
        Normal,                      //< Highest quality mode
        Speed_Fast,                        //< Slightly lower quality but much faster compression mode - DXTn & ATInN only
        Speed_SuperFast,                   //< Slightly lower quality but much, much faster compression mode - DXTn & ATInN only
    }
}
