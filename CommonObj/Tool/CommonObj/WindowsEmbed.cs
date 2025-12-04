using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace CommonObj
{
    public class WindowsEmbed
    {
        [DllImport("user32.dll", EntryPoint = "SetParent")]
        public static extern int SetParent(IntPtr hwndChild, IntPtr hwndNweParent);

        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", EntryPoint = "IsWindowVisible")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        private const int GWL_STYLE = -16;
        private const uint WS_CAPTION = 0x00C00000;
        private const uint WS_THICKFRAME = 0x00040000;

        Process p = new Process();
        IntPtr WindowsHandle = (IntPtr)0;
        int m_LanuchTime = 1000;
        private string exePath;// 外部exe位置
        private String MutexName;

        public WindowsEmbed(string Name, string FilePath, int LaunchTime)
        {
            MutexName = Name;
            exePath = FilePath;
            m_LanuchTime = LaunchTime;
        }

        public bool ProcessLaunch()
        {
            if (!File.Exists(exePath))
            {
                MessageBox.Show(exePath.ToString() + "程序路径不存在！");
                return false;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = exePath,
                Arguments = "",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = Path.GetDirectoryName(exePath),
                WindowStyle = ProcessWindowStyle.Normal,
            };

            try
            {
                #region 避免程式重覆執行
                Boolean bCreatedNew;
                //Create a new mutex using specific mutex name
                Mutex m = new Mutex(false, MutexName, out bCreatedNew);
                if (!bCreatedNew)
                {
                    MessageBox.Show(MutexName + " Program has been run", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                #endregion

                p.StartInfo = startInfo;
                p.Start();
                while (p.MainWindowHandle.ToInt32() == 0)
                {
                    System.Threading.Thread.Sleep(m_LanuchTime);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }

        public void EmbedWindows(Control con)
        {
            try
            {
                p.WaitForInputIdle();
                // 获取外部程序的窗口句柄
                IntPtr hWnd = p.MainWindowHandle;
                //// 移除外部程序的ControlBox和边框
                uint style = GetWindowLong(hWnd, GWL_STYLE);
                style &= ~(WS_CAPTION | WS_THICKFRAME);
                SetWindowLong(hWnd, GWL_STYLE, style);

                SetParent(hWnd, con.Handle);
                ShowWindow(hWnd, (int)ProcessWindowStyle.Maximized);

                //Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void EmbedSubWindows(Control con, string SubName)
        {
            try
            {
                p.WaitForInputIdle();

                const int maxClassNameLength = 256;
                var ClassNameBuilder = new System.Text.StringBuilder(maxClassNameLength);
                int length = GetClassName(p.MainWindowHandle, ClassNameBuilder, maxClassNameLength);
                string ClassName = ClassNameBuilder.ToString(0, length);

                WindowsHandle = (IntPtr)FindWindow(ClassName, SubName);

                // 获取外部程序的窗口句柄
                IntPtr hWnd = WindowsHandle;
                //// 移除外部程序的ControlBox和边框
                uint style = GetWindowLong(hWnd, GWL_STYLE);
                style &= ~(WS_CAPTION | WS_THICKFRAME);
                SetWindowLong(hWnd, GWL_STYLE, style);

                SetParent(hWnd, con.Handle);
                ShowWindow(hWnd, (int)ProcessWindowStyle.Maximized);

                //Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        public void EmbedWindowsEx(Control con, string FormName)
        {
            try
            {
            //    p.StartInfo.FileName = exePath;
            //    p.StartInfo.UseShellExecute = true;
            //    p.StartInfo.ErrorDialog = true;
            //    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            //    p.Start();


                //WindowsHandle = (IntPtr)FindWindow(exePath, FormName);  //視覺主程式

                WindowsHandle = (IntPtr)FindWindow("WindowsForms10.Window.8.app.0.141b42a_r9_ad1", "");  //視覺主程式



                //while (WindowsHandle == IntPtr.Zero)
                //{
                //    IPLeftUpCCDHandle = (IntPtr)FindWindow(SYSPara.sVisionEmbedPath, "SubViewS0");
                //    if (!IsWindowVisible(IPCCDHandle))           //視覺主程式和嵌入的畫面都不存在
                //    {
                //        if (IPLeftUpCCDHandle == IntPtr.Zero)
                //        {
                //            MessageBox.Show("請先開啓視覺軟體，再開主程式!", "注意");
                //        }
                //    }
                //    else                                        //視覺主程式存在但要嵌入的畫面不存在
                //    {
                //        if (IPLeftUpCCDHandle == IntPtr.Zero)
                //        {
                //            MessageBox.Show("缺少左上CCD嵌入畫面，請關閉目前視覺軟體，再重開視覺軟體!", "注意");
                //        }
                //    }
                //}
                //while (p.MainWindowHandle.ToInt32() == 0)
                //{
                //    System.Threading.Thread.Sleep(100);
                //}
                //// 获取外部程序的窗口句柄
                //IntPtr hWnd = p.MainWindowHandle;
                //// 移除外部程序的ControlBox和边框
                //uint style = GetWindowLong(hWnd, GWL_STYLE);
                //style &= ~(WS_CAPTION | WS_THICKFRAME);
                //SetWindowLong(hWnd, GWL_STYLE, style);

                //SetParent(hWnd, con.Handle);
                //ShowWindow(hWnd, (int)ProcessWindowStyle.Maximized);

                // 移除外部程序的ControlBox和边框
                uint style = GetWindowLong(WindowsHandle, GWL_STYLE);
                style &= ~(WS_CAPTION | WS_THICKFRAME);
                SetWindowLong(WindowsHandle, GWL_STYLE, style);

                SetParent(WindowsHandle, con.Handle);
                ShowWindow(WindowsHandle, (int)ProcessWindowStyle.Maximized);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        //解構使用
        public void DisposeTH()
        {
            if (p != null)
            {
                try
                {
                    p.Kill();
                    p.WaitForExit();
                }
                catch (Exception e)
                {

                }
                finally
                {
                    p.Dispose();
                }
            }
        }
    }
}
