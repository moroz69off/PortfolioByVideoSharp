using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastDoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NikeFormsApp
{
    public partial class MainForm : Form
    {
        private string cardCsv;
        private string[] userPreference;
        string[] modelInfo;
        private static NikeProvider NP;


        public MainForm()
        {
            InitializeComponent();
            userPreference = new string[] { "", "" };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CreateNewChromeNike();
            Autorize(userPreference);
            WaitModelSelection();
        }

        private void WaitModelSelection()
        {
            WebDriverWait waitModelInfo = new WebDriverWait(NP.Driver, TimeSpan.FromSeconds(200));
            modelInfo = waitModelInfo.Until<string[]>(Arg);
        }

        private string[] Arg(IWebDriver arg)
        {
            return NP.GetModelInfo(NP.Driver.Url);
        }

        private void Autorize(string[] userPreference)
        {
            IWebElement linkLogin = NP.Driver.FindElement(NP.byLoginLinkClassName);
            linkLogin.Click();
            NP.GetLoginInputs(1).SendKeys(userPreference[0]);
            NP.GetLoginInputs(7).SendKeys(userPreference[1]);
            NP.PushLoginButton();
        }

        private static void CreateNewChromeNike()
        {
            NP = new NikeProvider();
            NikeProvider.driverService.HideCommandPromptWindow = true;
            NP.Driver.Manage().Window.Maximize();
            ReadOnlyCollection<string> DriverWindowHandles = NP.Driver.WindowHandles;
            NP.Driver.Navigate().GoToUrl("https://www.nike.com/ru/launch/?s=upcoming");
            File.AppendAllText("handles.log", DriverWindowHandles[0] + "\n");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NP.Driver.Dispose();
        }

        private void textBox_eMail_TextChanged(object sender, EventArgs e)
        {
            if (textBox_eMail.Text.Contains(@"@")) userPreference[0] = textBox_eMail.Text;
        }

        private void textBox_csvInput_TextChanged(object sender, EventArgs e)
        {
            if (textBox_csvInput.Text.Length == 3) cardCsv = textBox_csvInput.Text;
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
