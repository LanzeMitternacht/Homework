using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace Hook
{
    internal static class Program
    {
        static IntPtr hook = IntPtr.Zero;
        static HookProcess proc = HookCallBack;
        static int k = 0x0100;
        static void Main()
        {
           hook = SetHook(proc);
            Application.Run();
            UnhokingWindowsHook(hook);
        }
        static IntPtr SetHook(HookProcess proc)
        {
            Process currentProcess = Process.GetCurrentProcess();
            using (ProcessModule currentModule = currentProcess.MainModule)
            {
                return SetWindowsHookEx(13, proc, GetModuleHandle(currentModule.ModuleName),0);
            }
        }
        delegate IntPtr HookProcess(int nCode, IntPtr wParam, IntPtr lParam);
       
        static IntPtr HookCallBack(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if((nCode >=0) && (wParam == (IntPtr)k))
            {
                int kCode = Marshal.ReadInt32(lParam);
                if((Keys)kCode==Keys.LWin || ((Keys)kCode == Keys.RWin)){
                    Console.WriteLine($"{(Keys)kCode}");
                    return (IntPtr)1;
                }
            }
                return CallNextHookEx(hook, nCode, wParam, lParam);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr SetWindowsHookEx(int id, HookProcess lpfn, IntPtr hWnd, int dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool UnhokingWindowsHook(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetModuleHandle(string sModuleName);
    }
}
