using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compress.NET.LowLevel
{
    public enum AMD_TC_FORMAT
    {
        Unknown,                    // Undefined texture format.
        // Channel Component formats --------------------------------------------------------------------------------
        ARGB_8888,                  //< ARGB format with 8-bit fixed channels.
        RGB_888,                    //<    RGB format with 8-bit fixed channels.
        RG_8,                       //<    Two component format with 8-bit fixed channels.
        R_8,                        //<    Single component format with 8-bit fixed channels.
        ARGB_2101010,               //< ARGB format with 10-bit fixed channels for color & a 2-bit fixed channel for alpha.
        ARGB_16,                    //<    RGB format with 16-bit fixed channels.
        RG_16,                      //<    Two component format with 16-bit fixed channels.
        R_16,                       //<    Single component format with 16-bit fixed channels.
        ARGB_16F,                   //< ARGB format with 16-bit floating-point channels.
        RG_16F,                     //<    Two component format with 16-bit floating-point channels.
        R_16F,                      //<    Single component with 16-bit floating-point channels.
        ARGB_32F,                   //< ARGB format with 32-bit floating-point channels.
        RGB_32F,                   //<	 RGB format with 32-bit floating-point channels.
        RG_32F,                     //<    Two component format with 32-bit floating-point channels.
        R_32F,                      //<    Single component with 32-bit floating-point channels.
        // Compression formats -----------------------------------------------------------------------------------
        ATI1N,                      //< Single component compression format using the same technique as DXT5 alpha. Four bits per pixel.
        ATI2N,                      //<	 Two component compression format using the same technique as DXT5 alpha. Designed for compression object space normal maps. Eight bits per pixel.
        ATI2N_XY,                   //<    Two component compression format using the same technique as DXT5 alpha. The same as ATI2N but with the channels swizzled. Eight bits per pixel.
        ATI2N_DXT5,                 //<    ATI2N like format using DXT5. Intended for use on GPUs that do not natively support ATI2N. Eight bits per pixel.
        ATC_RGB,                    //< AMD_TC - a compressed RGB format.
        ATC_RGBA_Explicit,          //< AMD_TC - a compressed ARGB format with explicit alpha.
        ATC_RGBA_Interpolated,      //< AMD_TC - a compressed ARGB format with interpolated alpha.
        BC1,                        //< A four component opaque (or 1-bit alpha) compressed texture format for Microsoft DirectX10. Identical to DXT1.  Four bits per pixel.
        BC2,                        //< A four component compressed texture format with explicit alpha for Microsoft DirectX10. Identical to DXT3. Eight bits per pixel.
        BC3,                        //< A four component compressed texture format with interpolated alpha for Microsoft DirectX10. Identical to DXT5. Eight bits per pixel.
        BC4,                        //< A single component compressed texture format for Microsoft DirectX10. Identical to ATI1N. Four bits per pixel.
        BC5,                        //< A two component compressed texture format for Microsoft DirectX10. Identical to ATI2N. Eight bits per pixel.
        BC6H,                       //< BC6H compressed texture format 
        BC7,                        //< BC7  compressed texture format
        DXT1,                       //< An DXTC compressed texture matopaque (or 1-bit alpha). Four bits per pixel.
        DXT3,                       //<    DXTC compressed texture format with explicit alpha. Eight bits per pixel.
        DXT5,                       //<    DXTC compressed texture format with interpolated alpha. Eight bits per pixel.
        DXT5_xGBR,                  //<    DXT5 with the red component swizzled into the alpha channel. Eight bits per pixel.
        DXT5_RxBG,                  //<    swizzled DXT5 format with the green component swizzled into the alpha channel. Eight bits per pixel.
        DXT5_RBxG,                  //<    swizzled DXT5 format with the green component swizzled into the alpha channel & the blue component swizzled into the green channel. Eight bits per pixel.
        DXT5_xRBG,                  //<    swizzled DXT5 format with the green component swizzled into the alpha channel & the red component swizzled into the green channel. Eight bits per pixel.
        DXT5_RGxB,                  //<    swizzled DXT5 format with the blue component swizzled into the alpha channel. Eight bits per pixel.
        DXT5_xGxR,                  //<    two-component swizzled DXT5 format with the red component swizzled into the alpha channel & the green component in the green channel. Eight bits per pixel.
        ETC_RGB,                    //< ETC (Ericsson Texture Compression) 
        //--------------------------------------------------------------------------------------------------------
        FORMAT_MAX = ETC_RGB
    }
}
