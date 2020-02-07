using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Windows.Forms;

namespace FastDoIt
{
    
    class NikeProvider
    {
        private const string indexModelNameStr = "/launch/t/";
        static IWebElement frmEl;

        public static ChromeOptions chromeOptions = new ChromeOptions();
        public static ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
        public IWebDriver Driver = new ChromeDriver(driverService, chromeOptions);

        static readonly string loginLinkClasName = "join-log-in";
        static readonly string submitBtnClasName = "submit-button";

        public By byLoginLinkClassName = By.ClassName(loginLinkClasName);
        public By bySubmitBtnClassName = By.ClassName(submitBtnClasName);
        public By byLoginEmailInputIdd = By.ClassName(loginLinkClasName);

        public IWebElement GetLoginInputs(int i)
        {
            frmEl = Driver.FindElements(By.Id("nike-unite-loginForm"))[0];
            var divEl = frmEl.FindElements(By.TagName("div"))[i];
            var input = divEl.FindElement(By.TagName("input"));
            return input;
        }

        internal void PushLoginButton()
        {
            frmEl.FindElement(By.ClassName("nike-unite-submit-button")).FindElement(By.TagName("input")).Click();
        }

        internal string[] GetModelInfo(string curUrl)
        {
            string modelName = curUrl.Substring(curUrl.IndexOf(indexModelNameStr + 10));
            string modelId = null;
            string releiseDateTime = null;
            return new string[] { modelName, modelId, releiseDateTime };
        }
    }
}
