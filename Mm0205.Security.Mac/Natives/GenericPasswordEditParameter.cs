using System.Runtime.InteropServices;

namespace Mm0205.Security.Mac.Natives
{
    /// <summary>
    /// struct for create/edit generic password item.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct GenericPasswordEditParameter
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string account;
        
        [MarshalAs(UnmanagedType.LPStr)]
        public string password;
        
        [MarshalAs(UnmanagedType.LPStr)]
        public string description;
        
        [MarshalAs(UnmanagedType.LPStr)]
        public string comment;
        
        [MarshalAs(UnmanagedType.LPStr)]
        public string label;
        
        [MarshalAs(UnmanagedType.LPStr)]
        public string service;
    }
}