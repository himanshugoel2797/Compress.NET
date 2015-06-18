using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Compress.NET.LowLevel
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct AMD_TC_CompressOptions
    {

        public int dwSize;
        public bool useChannelWeighting;
        double fWeightingRed;           //<	The weighting of the Red or X Channel. 
        double fWeightingGreen;     //<	The weighting of the Green or Y Channel. 
        double fWeightingBlue;          //<	The weighting of the Blue or Z Channel. 
        bool bUseAdaptiveWeighting; //<	Adapt weighting on a per-block basis. 
        bool bDXT1UseAlpha;          //< Encode single-bit alpha data. Only valid when compressing to DXT1 & BC1.
        byte nAlphaThreshold;        //< The alpha threshold to use when compressing to DXT1 & BC1 with bDXT1UseAlpha. Texels with an alpha value less than the threshold are treated as transparent.
        bool bDisableMultiThreading;    //< Disable multi-threading of the compression. This will slow the compression but can be useful if you're managing threads in your application.
                                        //< if set BC7 dwnumThreads will default to 1 during encoding and then return back to its original value when done.
        AMD_TC_Speed nCompressionSpeed;     //< The trade-off between compression speed & quality.
                                            //< this value is ignored for BC6H and BC7 (for BC7 the compression speed depends on fquaility value)  
        int dwnumThreads;          //< Number of threads to initialize for BC7 encoding (Max up to 128). Default set to 8, 
        double fquality;                //< Quality of encoding for BC7. This value ranges between 0.0 and 1.0.
                                        //< setting fquality above 0.0 gives the fastest, lowest quality encoding, 1.0 is the slowest, highest quality encoding. Default set to a low value of 0.05
        bool brestrictColour;       //< This setting is a quality tuning setting for BC7 which may be necessary for convenience in some applications. Default set to false
                                    //< if  set and the block does not need alpha it instructs the code not to use modes that have combined colour + alpha - this
                                    //< avoids the possibility that the encoder might choose an alpha other than 1.0 (due to parity) and cause something to
                                    //< become accidentally slightly transparent (it's possible that when encoding 3-component texture applications will assume that
                                    //< the 4th component can safely be assumed to be 1.0 all the time.)
        bool brestrictAlpha;            //< This setting is a quality tuning setting for BC7 which may be necessary for some textures. Default set to false,
                                        //< if set it will also apply restriction to blocks with alpha to avoid issues with punch-through or thresholded alpha encoding
        int dwmodeMask;                //< Mode to set BC7 to encode blocks using any of 8 different block modes in order to obtain the highest quality. Default set to 0xCF, (Skips Color components with separate alpha component)
                                       //< You can combine the bits to test for which modes produce the best image quality. 
                                       //< The mode that produces the best image quality above a set quality level (fquality) is used and subsequent modes set in the mask 
                                       //< are not tested, this optimizes the performance of the compression versus the required quality. 
                                       //< If you prefer to check all modes regardless of the quality then set the fquality to a value of 0
        int NumCmds;                //< Count of the number of command value pairs in CmdSet[].  Max value that can be set is AMD_MAX_CMDS = 20 on this release

        [MarshalAs(UnmanagedType.LPStruct)]
        AMD_CMD_SET[] CmdSet;   //< Extended command options that can be set for the specified codec  			
                                //< Example to set the number of threads and quality used for compression 
                                //<		AMD_TC_CompressOptions Options; 
                                //<		memset(Options,0,sizeof(AMD_TC_CompressOptions));
                                //<		Options.dwSize = sizeof(AMD_TC_CompressOptions)
                                //<		Options.CmdSet[0].strCommand   = "NumThreads"
                                //<		Options.CmdSet[0].strParameter = "8";
                                //<		Options.CmdSet[1].strCommand   = "Quality"
                                //<		Options.CmdSet[1].strParameter = "1.0";
                                //<		Options.NumCmds = 2;

    }
}
