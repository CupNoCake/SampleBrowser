using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleBrowser
{
    static class Program
    {
        #region 浏览器设置

        /// <summary>  
        /// 修改注册表信息来兼容当前程序  
        /// </summary>  
        private static void SetWebBrowserFeatures(int ieVersion)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
                return;
            //获取程序及名称  
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            //得到浏览器的模式的值  
            uint ieMode = GetEmulationMode(ieVersion);
            var featureControlRegKey = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\";
            //设置浏览器对应用程序（appName）以什么模式（ieMode）运行  
            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION",
                appName, ieMode, RegistryValueKind.DWord);
            //不晓得设置有什么用  
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION",
                appName, 1, RegistryValueKind.DWord);
        }
        /// <summary>  
        /// 获取浏览器的版本  
        /// </summary>  
        /// <returns></returns>  
        private static int GetBrowserVersion()
        {
            int browserVersion = 0;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer",
                RegistryKeyPermissionCheck.ReadSubTree,
                System.Security.AccessControl.RegistryRights.QueryValues))
            {
                var version = ieKey.GetValue("svcVersion");
                if (null == version)
                {
                    version = ieKey.GetValue("Version");
                    if (null == version)
                        throw new ApplicationException("Microsoft Internet Explorer is required!");
                }
                int.TryParse(version.ToString().Split('.')[0], out browserVersion);
            }
            //如果小于7  
            if (browserVersion < 7)
            {
                throw new ApplicationException("不支持的浏览器版本!");
            }
            return browserVersion;
        }
        /// <summary>  
        /// 通过版本得到浏览器模式的值  
        /// </summary>  
        /// <param name="browserVersion"></param>  
        /// <returns></returns>  
        private static uint GetEmulationMode(int browserVersion)
        {
            UInt32 mode = 11000; // Internet Explorer 11
            switch (browserVersion)
            {
                case 7:
                    mode = 7000; // Internet Explorer 7
                    break;
                case 8:
                    mode = 8000; // Internet Explorer 8
                    break;
                case 9:
                    mode = 9000; // Internet Explorer 9
                    break;
                case 10:
                    mode = 10000; // Internet Explorer 10.  
                    break;
                case 11:
                    mode = 11000; // Internet Explorer 11  
                    break;
            }
            return mode;
        }

        /// <summary>
        /// 查询系统环境是否支持IE8以上版本
        /// </summary>
        private static bool IfWindowsSupport()
        {
            bool isWin7 = Environment.OSVersion.Version.Major > 6;
            bool isSever2008R2 = Environment.OSVersion.Version.Major == 6
                && Environment.OSVersion.Version.Minor >= 1;

            if (!isWin7 && !isSever2008R2)
            {
                return false;
            }
            else return true;
        }

        private static void SetIEVersion()
        {
            int ieVersion = GetBrowserVersion();
            if (IfWindowsSupport())
            {
                SetWebBrowserFeatures(ieVersion < 11 ? ieVersion : 11);
            }
            else
            {
                // 如果不支持IE8 则修改为当前系统的IE版本
                SetWebBrowserFeatures(ieVersion < 7 ? 7 : ieVersion);
            }
        }
        #endregion
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetIEVersion();
            Application.Run(new Form1());
        }
    }
}
