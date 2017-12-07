using OpenQA.Selenium;
using System;
using System.Windows.Forms;

namespace MrzSelenChr
{
    public partial class GForm : Form
    {
        private IWebDriver mrzBro;
        private IWebElement mrzIsAuthorize;
        private IWebElement mrzWebElement;
        private string loginButtonClass = "btn-success";
       // private System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> mrzWebElements;
        private string stringId;
        private int count;
        private string first;
        private string secon;
        private bool isBro;
        public GForm()
        {
            InitializeComponent();
        }

        private void GForm_Load(object sender, EventArgs e)
        {
            isBro = false;
        }

        private void MrzBroInit()
        {
            isBro = true;
            mrzBro = new OpenQA.Selenium.Chrome.ChromeDriver();
            mrzBro.Manage().Window.Maximize();
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Click(object sender, EventArgs e)
        {
            MrzBroInit();

            mrzBro.Navigate().GoToUrl("https://videosharp.info");

            mrzIsAuthorize = mrzBro.FindElement(By.ClassName(loginButtonClass));

            mrzIsAuthorize.Click();

            mrzWebElement = mrzBro.FindElement(By.Id("my_email"));

            mrzWebElement.SendKeys("moroz69off@yandex.ru" + // ================================================
                                 OpenQA.Selenium.Keys.Tab + 
                                           "vjhjp69vjhjp" + // пароль и логин перенести в настройки или конфиги
                                 OpenQA.Selenium.Keys.Tab + 
                                 OpenQA.Selenium.Keys.Enter);

            // беру кнопку с количеством работ
            mrzWebElement = mrzBro.FindElement(By.ClassName("btn-success"));

            mrzWebElement.Click();

            do
            {
                // ищем кнопку «ХОРОШО»
                string stringURL = mrzBro.Url;
                stringId = "good_link_votes_" + GetInfoForButtonId(stringURL);
                try
                {
                    mrzWebElement = mrzBro.FindElement(By.Id(stringId));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Похоже, проверять больше нечего\nХочется проодолжить?", "Ошибка", MessageBoxButtons.YesNo);
                    GForm.ActiveForm.WindowState = FormWindowState.Normal;
                    return;
                    //MessageBox.Show("Ошибка " + ex.ToString());
                    //throw new NoSuchElementException("Кнопки «ХОРОШО» нету");
                }
                if (!mrzWebElement.Displayed)
                {
                    return;
                }
                mrzWebElement.Click();
                count++;
            } while (mrzWebElement!=null);

        }

        /// <summary>
        /// Достаёт из адреса номер юзера и номер карточки
        /// </summary>
        /// <param name="stringURL">Строка - адрес страницы.</param>
        /// <returns></returns>
        private string GetInfoForButtonId(string stringURL)
        {
            string suffics = stringURL.Remove(0, 28);
            if (suffics.Contains("/"))
            {
                first = suffics.Remove(suffics.IndexOf('/'));
            }
            else return suffics;
            if (suffics.Contains("#"))
            {
                secon = suffics.Remove(suffics.IndexOf('#'));
            }
            else return suffics;
            if (secon.Contains("="))
            {
                secon = secon.Remove(0, secon.IndexOf('=') + 1);
            }
            else return suffics;
            suffics = first + "_" + secon;
            return suffics;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (isBro)
            {
                mrzBro.Quit();
            }
            else return;
            isBro = false;
        }

        private void buttonCloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
