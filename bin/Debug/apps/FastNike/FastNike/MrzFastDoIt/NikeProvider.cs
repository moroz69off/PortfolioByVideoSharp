using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;

namespace MrzFastDoIt
{
    class NikeProvider
    {
        BindSetting BS;
        static IWebElement frmEl;
        public IClock clock = new SystemClock();
        public static ChromeOptions chromeOptions = new ChromeOptions();
        public static ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
        public IWebDriver Driver = new ChromeDriver(driverService, chromeOptions);

        public void MaximizeChromeWindow()
        {
            Driver.Manage().Window.Maximize();
        }

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

        internal void PushUltimate()
        {
            ReadOnlyCollection<IWebElement> last = Driver.FindElements(By.ClassName("button-submit"));
            foreach (IWebElement btn in last)
            {
                if (btn.Text == "ОТПРАВИТЬ ЗАКАЗ") { btn.Click(); }
            }
        }

        /// <summary>
        /// Writes values from settings to form fields (Записывает значения из текстбоксов в поля формы)
        /// </summary>
        /// <param name="userSettings">string[10]</param>

        internal void FillForm(string[] userSettings)
        {
            BS = new BindSetting();
            ReadOnlyCollection<IWebElement> btns;
            
            WebDriverWait FormWait = new WebDriverWait(clock, Driver, TimeSpan.FromSeconds(48), TimeSpan.FromSeconds(1.5));
            FormWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            try
            {
                IWebElement middleName = FormWait.Until(ElementExists(By.Id("middleName")));
                middleName.SendKeys(userSettings[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: \n" + ex.Message+ "\nStackTrace: \n" + ex.StackTrace);
                File.AppendAllText("error.log", "Exception: \n" + ex.Message + "\nStackTrace: \n" + ex.StackTrace);
                Driver.Close();
                return;
            }

            btns = Driver.FindElements(By.ClassName("button-continue"));
            foreach (var btn in btns) { if (btn.Text== "СОХРАНИТЬ И ПРОДОЛЖИТЬ") btn.Click(); }

            btns = Driver.FindElements(By.ClassName("button-continue"));
            btns[0].Click();

        }

        internal Func<IWebDriver, IWebElement> ElementExists(By locator) { return d => d.FindElement(locator); }

        internal Func<IWebDriver, bool> UrlContains(string fraction) { return (driver) => { return driver.Url.ToLowerInvariant().Contains(fraction.ToLowerInvariant()); }; }

        internal string[] GetModelInfo(string curUrl)
        {
            IWebElement ModelId;
            string modelId;
            string modelName = curUrl.Substring(33).TrimEnd(new char[]{ '/'});
            
            try
            {
                WebDriverWait idWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(17)) { PollingInterval = TimeSpan.FromSeconds(.5) };
                idWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                ModelId = idWait.Until(D => D.FindElement(By.Name("branch:deeplink:productId")));
                modelId = ModelId.GetAttribute("content");
                string releiseDateTime = Driver.FindElement(By.ClassName("available-date-component")).Text.Substring(9).Replace(" В ", " ");
                return new string[] { modelName, modelId, releiseDateTime };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: \n" + ex.Message + "\n" + "StackTrace: \n" + ex.StackTrace + "\nЧто-то пошло не так ...\nЗапустие новую задачу");
                File.AppendAllText("error.log", "Exception: \n" + ex.Message + "\n" + "StackTrace: \n" + ex.StackTrace);
                Driver.Close();
                return null;
            }
        }
    }
}
