using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace Wrox.ProCSharp.Interop
{

   internal static class NativeMethods
   {
        [DllImport("kernel32.dll", SetLastError=true, EntryPoint="CreateHardLink", CharSet=CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CreateHardLink(string newFileName, string existingFileName, IntPtr securityAttributes);

        internal static void CreateHardLink(string oldFileName, string newFileName)
        {
            if (!CreateHardLink(newFileName, oldFileName, IntPtr.Zero))
            {
                Win32Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
                throw new IOException(ex.Message, ex);
            }
        }

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern SafeFileHandle CreateFile(
           string fileName,
           [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess,
           [MarshalAs(UnmanagedType.U4)] FileShare fileShare,
           IntPtr securityAttributes,
           [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
           int flags,
           SafeFileHandle template);

   }

    public static class FileUtility
    {
       [FileIOPermission(SecurityAction.LinkDemand, Unrestricted=true)]
       public static void CreateHardLink(string oldFileName, string newFileName)
       {
          NativeMethods.CreateHardLink(oldFileName, newFileName);
       }

    }

    class Program
    {
        static void Main()
        {
           try
           {
              FileUtility.CreateHardLink("a.txt", "b.txt");
           }
           catch (IOException ex)
           {
              Console.WriteLine(ex.Message);
           }
            
        }
    }
}
