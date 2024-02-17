using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L
{
    internal static class pr
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!IsRunAsAdmin())
            {
                Elevate();
                Application.Exit();
                return;
            }
            StringBuilder builder = new StringBuilder(100);
            string applicationName = "iAuto"; // Tên của ứng dụng
            Process[] processes = Process.GetProcessesByName(applicationName);
            foreach (Process process in processes)
            {
                IntPtr handle = IntPtr.Zero;
                EnumWindows((hWnd, lParam) =>
                {
                    int processId;
                    GetWindowThreadProcessId(hWnd, out processId);
                    if (process.Id == processId)
                    {
                        GetClassName(hWnd, builder, 100);
                        if (builder.ToString().Contains("WindowsForms10.Window.8.app"))
                        {
                            handle = hWnd;
                            return true;
                        }
                    }
                    return true;
                }, IntPtr.Zero);
                if (handle != IntPtr.Zero)
                {
                    // Hiển thị cửa sổ
                    Active(handle);
                }
            }

            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "iAuto", out createdNew))
            {
                if (createdNew)
                {

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                  
                    Application.Run(new m());
                }
            }          
        }

        [DllImport("user32.dll")]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        public static void Active(IntPtr handle)
        {
            RECT rec;
            GetWindowRect(handle, out rec);
            bool isMini = rec.Left == -32000;
            if (!IsWindowVisible(handle))
                ShowWindow(handle, WindowShowStyle.Show);
            if (isMini)
                ShowWindow(handle, WindowShowStyle.Restore);
            if (GetForegroundWindow() != handle)
                SetForegroundWindow(handle);
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public const int SW_RESTORE = 9;

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);
        public enum WindowShowStyle : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        }

        internal static bool IsRunAsAdmin()
        {
            var Principle = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return Principle.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private static bool Elevate()
        {
            var SelfProc = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process.Start(SelfProc);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }


}
