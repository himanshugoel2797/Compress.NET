using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Compress.NET.LowLevel
{
    public class AMDCompress
    {
        public const int VERSION_MAJOR = 2;
        public const int VERSION_MINOR = 0;

        public const int MAX_CMDS = 5;
        public const int MAX_CMD_STR = 32;
        public const int MAX_CMD_PARAM = 16;

        public delegate bool AMD_TC_Feedback_Proc(float progress, ref int pUser1, ref int pUser2);

        [DllImport("AMDCompress_MT_DLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int AMD_TC_CalculateBufferSize(IntPtr texStruct);

        [DllImport("AMDCOmpress_MT_DLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern AMD_TC_ERROR AMD_TC_ConvertTexture(IntPtr pSourceTexture, IntPtr pDestTexture,
                                                 IntPtr pOptions,
                                                 AMD_TC_Feedback_Proc pFeedbackProc, ref int pUser1, ref int pUser2);
    }
}
