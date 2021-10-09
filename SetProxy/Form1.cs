using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Net;

namespace SetProxy
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        static bool settingsReturn, refreshReturn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetContentResult("      Chưa kết nối proxy!", false);
            try
            {
                RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                if (registry.GetValue("ProxyEnable").ToString() == "1")
                    SetContentResult("Đang kết nối: " + registry.GetValue("ProxyServer").ToString());
            }
            catch
            {
                SetContentResult("          Có lỗi xảy ra!!!", false);
            }
        }

        private void btnSetProxy_Click(object sender, EventArgs e)
        {
            txbProxy.Text = txbProxy.Text.Trim();

            bool isChangeProxy = false;
            string proxy = txbProxy.Text.Trim();

            if (!string.IsNullOrEmpty(proxy) && proxy.Contains(":"))
            {
                if(proxy.Split('.').Length == 4 && proxy.Split(':').Length == 2)
                {
                    if(!string.IsNullOrEmpty(proxy.Split(':')[0]) && !string.IsNullOrEmpty(proxy.Split(':')[1]))
                    {
                        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
                        registry.SetValue("ProxyEnable", 1);
                        registry.SetValue("ProxyServer", proxy);

                        // These lines implement the Interface in the beginning of program 
                        // They cause the OS to refresh the settings, causing IP to realy update
                        settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
                        refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);

                        SetContentResult("Thành công: " + proxy);
                        isChangeProxy = true;
                    }
                }
            }
            
            if(!isChangeProxy)
                SetContentResult("          Proxy không hợp lệ", false);
        }
        private void btnRemoveProxy_Click(object sender, EventArgs e)
        {
            txbProxy.Text = txbProxy.Text.Trim();

            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyServer", string.Empty);
            registry.SetValue("ProxyEnable", 0);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);

            SetContentResult("             Đã tắt Proxy", false);
        }

        private void SetContentResult(string result, bool isSuccess = true)
        {
            if (isSuccess)
                lbResult.ForeColor = Color.Green;
            else
                lbResult.ForeColor = Color.Red;

            lbResult.Text = result;
            lbResult.Visible = true;
        }


    }
}
