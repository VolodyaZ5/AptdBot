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
using System.Runtime.Serialization.Formatters.Binary;

namespace Anketa
{    
    public partial class frmMain : Form
    {
        IWebDriver browser = new ChromeDriver(); //Объект веб драйвера управления браузером Chrome        
        ChromeOptions option = new ChromeOptions(); //Объект управления настройками браузера Chrome
        DesiredCapabilities dc = new DesiredCapabilities(); //Объект управления настроек Selenium

        BinaryFormatter binFormatter = new BinaryFormatter();

        //Текущий ip-адрес
        string currExternIP = new WebClient().DownloadString("https://api.ipify.org"); 


        public frmMain()
        {            
            InitializeComponent();
            
            SetProxy(ref option, ref browser);
        }

        private void btnUseProxy_Click(object sender, EventArgs e)
        {
            SetProxy(ref option, ref browser);

            if (txtProxyInput.Text != string.Empty)
            {
                if (File.Exists("proxyList.txt"))
                {
                    CheckSavedProxy();
                }
                else
                {
                    SaveProxy();
                } 
            }
            else
            {
                MessageBox.Show($"Введите данные proxy!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckSavedProxy()
        {
            using (StreamReader sr = new StreamReader("proxyList.txt", Encoding.Default))
            {
                List<string> savedIP = new List<string>();
                string enteredIpVal = txtProxyInput.Text;

                while (!sr.EndOfStream)
                {                     
                    savedIP.Add(sr.ReadLine());
                }

                foreach (var el in savedIP)
                {
                    if (enteredIpVal.Equals(el))
                    {
                        MessageBox.Show($"Данный proxy уже использовался", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        sr.Close();
                        SaveProxy();
                    }
                }

            }            
        }

        private void SaveProxy()
        {
            MessageBox.Show($"Proxy сохранен в списке использовавшихся!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (StreamWriter sw = new StreamWriter("proxyList.txt", true, Encoding.Default))
            {
                sw.WriteLine(txtProxyInput.Text);
            }            
        }

        private void SetProxy(ref ChromeOptions opt, ref IWebDriver brows)
        {            
            if (txtProxyInput.Text.Length != 0)
            {
                opt.AddArgument($"--proxy-server=http://{txtProxyInput.Text}");
                brows.Quit();
                
                brows = new ChromeDriver(opt);
                brows.Navigate().GoToUrl($"https://{txtUrlInput.Text}");                
                lblCurrentIp.Text = "Текущий IP-адрес:" + txtProxyInput.Text;
            }
            else
            {
                lblCurrentIp.Text = "Текущий IP-адрес:" + currExternIP;
                brows.Navigate().GoToUrl($"https://{txtUrlInput.Text}");                
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Quit();
        }

        private void btnAnketa_Click(object sender, EventArgs e)
        {
            browser.Navigate().GoToUrl($"http://nok.rosminzdrav.ru/site.html#!/23/2154#reviews");            
        }
    }
}
