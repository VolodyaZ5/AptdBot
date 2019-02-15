using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SetProxy;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.Net;

namespace Anketa
{
    public partial class frmMain : Form
    {        
        //object lockAction = new object(); //Заблокировать действие до завершения загрузки
        //bool isCompleted = false; //загрузка завершена

        IWebDriver browser = new ChromeDriver(); //Объект веб драйвера управления браузером Chrome
        ChromeOptions option = new ChromeOptions(); //Объект управления настройками браузера Chrome
        DesiredCapabilities dc = new DesiredCapabilities(); //Объект управления настроек Selenium

        string currExternIP = new WebClient().DownloadString("https://api.ipify.org");


        public frmMain()
        {            
            InitializeComponent();
            //webBrz.ProgressChanged += WebBrz_ProgressChanged;
            //webBrz.ScriptErrorsSuppressed = true;
            //CompabilityLevelClass.SetCompabilityLevel(); //Установка режима совместимости WebBrowser на 11
        }

        #region PrivateMethods

        /// <summary>
        /// Переход на url
        /// </summary>
        /// <param name="aptdUrl">Адрес сайта</param>
        //private void WebNavigate(string aptdUrl)
        //{
        //    lock (lockAction)
        //    {
                
        //        //webBrz.Navigate(aptdUrl);

        //        isCompleted = false;
        //        while (isCompleted == false)
        //        {
        //            Application.DoEvents();
        //        }
        //    }
        //}

        //Обработчик события завершения загрузки страницы
        //private void WebBrz_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        //{
        //    if (webBrz.ReadyState == WebBrowserReadyState.Complete)
        //    {
        //        isCompleted = true;
        //    }
        //}

        #endregion

        private void btnUseProxy_Click(object sender, EventArgs e)
        {
            //WinInetInterop.SetConnectionProxy(txtProxyInput.Text);

            lblProxyInfo.Text = txtProxyInput.Text;
            if (txtProxyInput.Text.Length != 0)
            {
                option.AddArgument($"--proxy-server=http://{txtProxyInput.Text}");
                browser = new ChromeDriver(option);
                browser.Navigate().GoToUrl($"https://{txtUrlInput.Text}");
                lblCurrentIp.Text = "Текущий IP-адрес:" + txtProxyInput.Text;
            }
            else
            {
                lblCurrentIp.Text = "Текущий IP-адрес:" + currExternIP;
                browser.Navigate().GoToUrl($"https://{txtUrlInput.Text}");
            }
            
        }        
    }
}
