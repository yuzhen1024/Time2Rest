﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Time2Rest.Hooks
{
    class KeyboardHook
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);


        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;

        static int hKeyboardHook = 0;

        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                Console.WriteLine("Keyboard Captured!!!");
            }

            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }


        public void StartHook()
        {
            if (hKeyboardHook == 0)
            {
                HookProc keyboardHookProc = new HookProc(KeyboardHookProc);
                hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, keyboardHookProc, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);

                if (hKeyboardHook == 0)
                {
                    StopHook();
                    throw new Exception("Hook failed!");
                }
            }
        }

        public void StopHook()
        {
            if (hKeyboardHook != 0)
            {
                bool retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
                if (!retKeyboard)
                    throw new Exception("Unhook failed!");
            }
        }
    }
}
