using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SevenConverter.Utils
{
    public static class Tools
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);

        [FlagsAttribute]
        private enum ExecutionState : uint
        {
            EsAwaymodeRequired = 0x00000040,
            EsContinuous = 0x80000000,
            EsDisplayRequired = 0x00000002,
            EsSystemRequired = 0x00000001
        }

        public static void PreventSleep()
        {
            SetThreadExecutionState(ExecutionState.EsContinuous | ExecutionState.EsSystemRequired);
        }

        public static void AllowSleep()
        {
            SetThreadExecutionState(ExecutionState.EsContinuous);
        }

        public static string GetProgramVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }


        public static void ShowPanel(Control toggleControl, Panel panel, bool show, int height)
        {
            panel.Left = toggleControl.Left + toggleControl.Width;

            int oldHeight = height;

            if (show)
            {
                panel.Height = 0;
                panel.Visible = show;
                for (int i = 0; i < oldHeight; i += 10)
                {
                    panel.Height = i;
                    panel.Top = toggleControl.Top - i;
                    Thread.Sleep(2);
                }
                panel.Height = oldHeight;
                panel.Top = toggleControl.Top - panel.Height;
            }
            else
            {
                for (int i = oldHeight; i > 0; i -= 10)
                {
                    panel.Height = i;
                    panel.Top = toggleControl.Top - i;
                    Thread.Sleep(2);
                }
                panel.Height = 0;
                panel.Visible = show;
                panel.Top = toggleControl.Top;
            }
        }
    }
}