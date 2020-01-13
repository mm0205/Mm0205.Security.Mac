using System.Runtime.InteropServices;

namespace Mm0205.Security.Mac.Natives
{
    /// <summary>
    /// Native Methods
    /// </summary>
    internal static class NativeMethods
    {
        [DllImport("libMm0205_Native_Mac_Keychain.dylib",
            EntryPoint = "mm_save_generic_password",
            CallingConvention = CallingConvention.Cdecl)]
        [return:MarshalAs(UnmanagedType.I4)]
        public static extern int SaveGenericPassword(
            ref GenericPasswordEditParameter parameter,
            [MarshalAs(UnmanagedType.I4)]
            out int apiStatus
        );
    }
}