using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anketa
{
    static class CompabilityLevelClass
    {
        /*Элемент управления WebBrowser по умолчанию работает в режиме совместимости с IE7.Чтобы переключить его
            на более новые версии необходимо создать ключ в реестре по пути
            HKEY_LOCAL_MACHINE\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION 
            или 
            HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION*/
        public static void SetCompabilityLevel()
        {
            string appName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            int lvl = 1000 * GetBrowserVersion();
            bool fixVShost = File.Exists(Path.ChangeExtension(Application.ExecutablePath, ".vshost.exe"));

            WriteCompabilityLevel("HKEY_LOCAL_MACHINE", appName + ".exe", lvl);
            if (fixVShost)
            {
                WriteCompabilityLevel("HKEY_LOCAL_MACHINE", appName + ".vshost.exe", lvl);
            }

            WriteCompabilityLevel("HKEY_CURRENT_USER", appName + ".exe", lvl);
            if (fixVShost)
            {
                WriteCompabilityLevel("HKEY_CURRENT_USER", appName + ".vshost.exe", lvl);
            }

        }

        private static void WriteCompabilityLevel(string root, string appName, int lvl)
        {
            try
            {
                Microsoft.Win32.Registry.SetValue(root + 
                    @"\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, lvl);
            }
            catch (Exception)
            { }
        }

        private static int GetBrowserVersion()
        {
            string strKeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer";
            string[] ls = new string[] { "svcVersion", "svcUpdateVersion", "Version", "W2kVersion" };

            int maxVer = 0;
            for (int i = 0; i < ls.Length; ++i)
            {
                object objVal = Microsoft.Win32.Registry.GetValue(strKeyPath, ls[i], "0");
                string strVal = Convert.ToString(objVal);
                if (strVal != null)
                {
                    int iPos = strVal.IndexOf('.');
                    if (iPos > 0)
                    {
                        strVal = strVal.Substring(0, iPos);
                    }

                    int res = 0;
                    if (int.TryParse(strVal, out res))
                    {
                        maxVer = Math.Max(res, maxVer);
                    }
                }

            }

            return maxVer;
        }
    }
}
