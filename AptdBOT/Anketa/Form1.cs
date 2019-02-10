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
using OpenQA.Selenium;
using SetProxy;
using System.Threading;

namespace Anketa
{
    public partial class frmMain : Form
    {
        //Заблокировать действие до завершения загрузки
        object lockAction = new object();
        //загрузка завершена
        bool isCompleted = false;        

        public frmMain()
        {
            InitializeComponent();

            webBrz.ProgressChanged += WebBrz_ProgressChanged;
            webBrz.ScriptErrorsSuppressed = true;

            //Установка режима совместимости WebBrowser на 11
            CompabilityLevelClass.SetCompabilityLevel();                    
        }

        //Обработчик события завершения загрузки страницы
        private void WebBrz_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (webBrz.ReadyState == WebBrowserReadyState.Complete)
            {
                isCompleted = true;
            }
        }

        private void btnToSite_Click(object sender, EventArgs e)
        {
            string aptdUrl = @"http://armptd.ru/";
            //webBrz.Navigate(aptdUrl);
            WebNavigate(aptdUrl);
            
            string anketaUrl = @"http://nok.rosminzdrav.ru/site.html#!/23/2154#reviews";
            webBrz.Navigate(anketaUrl);
            WebNavigate(anketaUrl);            
                        
                        
        }       

        #region PrivateMethods

        /// <summary>
        /// Переход на url
        /// </summary>
        /// <param name="aptdUrl">Адрес сайта</param>
        private void WebNavigate(string aptdUrl)
        {
            lock (lockAction)
            {
                
                webBrz.Navigate(aptdUrl);

                isCompleted = false;
                while (isCompleted == false)
                {
                    Application.DoEvents();
                }
            }
        }

        #endregion

        private void btnUseProxy_Click(object sender, EventArgs e)
        {
            WinInetInterop.SetConnectionProxy(txtProxyInput.Text);
            lblProxyInfo.Text = txtProxyInput.Text;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //webBrz.Url = new Uri(txtUrlInput.Text);
            //WebNavigate(txtUrlInput.Text);
            webBrz.Navigate(txtUrlInput.Text);
        }
    }
}
