using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppendiceB_PInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            NativeMethods.MessageBox(IntPtr.Zero, "World", "Hello", 0);

            NativeMethods.MsgBox(IntPtr.Zero, "World 2", "Hèllo 2", 0);


            NativeMethods.MsgBox(new IntPtr(123132), "Press OK...", "Press OK Dialog", 0);

            // Get the last error and display it.

            int error = Marshal.GetLastWin32Error();

        }
    }

    public enum MessageBoxResult : uint
    {
        Ok = 1,
        Cancel,
        Abort,
        Retry,
        Ignore,
        Yes,
        No,
        Close,
        Help,
        TryAgain,
        Continue,
        Timeout = 32000
    }


    class NativeMethods
    {        
        [DllImport("user32.dll")]
        public static extern MessageBoxResult MessageBox(IntPtr hWnd, String text, String caption, int options);

        [DllImport("user32.dll", EntryPoint="MessageBox", CharSet=CharSet.Ansi, SetLastError=true)]
        public static extern int MsgBox(IntPtr hWnd, String text, String caption, int options);
    }
}
