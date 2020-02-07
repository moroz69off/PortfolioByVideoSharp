using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace NikeFormsApp
{
    public partial class MainForm : Form
    {
        private IWebDriver Driver;
        private string loginLinkClassName;


        public MainForm()
        {
            InitializeComponent();
            string[] userPreference = { "username", "password" };
            loginLinkClassName = "join-log-in text-color-grey prl3-sm pt2-sm pb2-sm fs12-sm d-sm-b";
            ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("userPreference", userPreference);
            Driver = new ChromeDriver(driverService, chromeOptions);
            Driver.Manage().Window.Maximize();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Driver.Navigate().GoToUrl("https://www.nike.com/ru/launch/?s=upcoming");
            WindowState = FormWindowState.Minimized;
            NikeProvider();
        }

        private void NikeProvider()
        {
            
        }

        private void GetCurrentUrl(string currentWindowHandle)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Driver.Dispose();
        }
    }
}



///// <summary>
///// dismiss alert [ driver.dismissAlert(); ]
///// </summary>
///// <param name="driver"></param>
///// <returns>driver</returns>
//public static IWebDriver DismissAlert(this IWebDriver driver)
//{
//    try
//    {
//        IAlert alert = driver.SwitchTo().Alert();
//        alert.Dismiss();
//    }
//    catch { }
//    return driver;
//}
///// <summary>
///// accept alert [ driver.acceptAlert(); ]
///// </summary>
///// <param name="driver"></param>
///// <returns>driver</returns>
//public static IWebDriver AcceptAlert(this IWebDriver driver)
//{
//    try
//    {
//        IAlert alert = driver.SwitchTo().Alert();
//        alert.Accept();
//    }
//    catch { }
//    return driver;
//}
