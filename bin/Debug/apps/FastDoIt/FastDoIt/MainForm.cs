using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace MrzFastDoIt
{
    public partial class MainForm : Form
    {
        private static NikeProvider NP;
        BindSetting bindSetting;
        DateTime timeOfTask;
        System.Timers.Timer timer;

        public MainForm()
        {
            InitializeComponent();
            timeOfTask = DateTime.Now;
            timer = new System.Timers.Timer();
            bindSetting = new BindSetting();
            profiles = bindSetting.GetProfiles();
            acntStr = new string[12];
            userLoginPrefs = new string[] {"info@yumor.xyz","21225Moroz2020-m1"};
            taskArray = new string[]
            {
                "https://www.nike.com/ru/launch/t/",
                "product_name",
                "/?productId=",
                "product_id",
                "&size=",
                "size"
            };
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

            CreateNewChrome();
            Autorize(userLoginPrefs);
            WaitModelSelection();
            GetSizeModel();
            GoToOrder(modelInfo);
            Thread.Sleep(10000);
            FillFormFields(userSettings);
            StartTimer();
        }

        private void StartTimer()
        {
            long interval = GetInterval(DateTime.Now);
            timer.Interval = interval;
            timer.Enabled = true;
            timer.Elapsed += PushLastButton;
            timer.Start();  
        }

        private void PushLastButton(Object source, System.Timers.ElapsedEventArgs e)
        {
            NP.PushUltimate();
        }

        private long GetInterval(DateTime now)
        {
            long totalTaskMiliseconds = (timeOfTask.Second * 1000) + (timeOfTask.Minute * 60000) + ((timeOfTask.Hour * 60000) * 60);
            long totalNowMiliseconds = (now.Second * 1000) + (now.Minute * 60000) + (now.Hour * 60000 * 60);
            return totalTaskMiliseconds - totalNowMiliseconds;
        }

        private void GoToOrder(string[] modelInfo)
        {
            taskArray[1] = modelInfo[0];
            taskArray[3] = modelInfo[1];
            taskArray[5] = sizeMdl;
            string orderStr =
                taskArray[0] +
                taskArray[1] +
                taskArray[2] +
                taskArray[3] +
                taskArray[4] +
                taskArray[5];
            NP.Driver.Navigate().GoToUrl(orderStr);
        }

        private void GetSizeModel()
        {
            
            int i = sizeMdl.IndexOf('(');
            sizeMdl = sizeMdl.Substring(0, i - 1);
        }

        private void FillFormFields(string[] userSettings)
        {
            NP.FillForm(userSettings);
        }

        private void WaitModelSelection()
        {
            IClock clock = new SystemClock();
            WebDriverWait waitModel = new WebDriverWait(clock, NP.Driver, TimeSpan.FromSeconds(777.777), TimeSpan.FromSeconds(3.333));
            waitModel.Until(NP.UrlContains("/t/"));
            modelInfo = NP.GetModelInfo(NP.Driver.Url);
        }

        private void Autorize(string[] userPreference)
        {
            IWebElement linkLogin = NP.Driver.FindElement(NP.byLoginLinkClassName);
            linkLogin.Click();
            NP.GetLoginInputs(1).SendKeys(userPreference[0]);
            NP.GetLoginInputs(7).SendKeys(userPreference[1]);
            NP.PushLoginButton();
        }

        private static void CreateNewChrome()
        {
            NP = new NikeProvider();
            File.AppendAllText("program.log", $"chrome current handle: {NP.Driver.CurrentWindowHandle}\n");
            NP.MaximizeChromeWindow();
            NikeProvider.driverService.HideCommandPromptWindow = true;
            NP.Driver.Navigate().GoToUrl("https://www.nike.com/ru/launch/?s=upcoming");
        }

        private void button_saveAccount_Click(object sender, EventArgs e)
        {
            string newAccount =
                acntStr[0] + ", " +
                acntStr[1] + ", " +
                acntStr[2] + ", " +
                acntStr[3] + ", " +
                acntStr[4] + ", " +
                acntStr[5] + ", " +
                acntStr[6] + ", " +
                acntStr[7] + ", " +
                acntStr[8] + ", " +
                acntStr[9] + ", ";
            BindSetting bindAccount = new BindSetting();
            bindAccount.AppendIniFile(newAccount);
            SaveProfileForm SPF = new SaveProfileForm();
            SPF.ShowDialog(this);
        }

        private void comboBox_profileSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox dropList = (ComboBox)sender;
            object selectedItem = dropList.SelectedItem;
            string itemText = dropList.GetItemText(selectedItem);
            profileData = bindSetting.GetProfileData(itemText);
        }

        private void comboBox_sizeSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private string sizeMdl;
        private string[] acntStr;
        private string[] userLoginPrefs;
        private string[] profiles;
        private string[] modelInfo;
        private string[] taskArray;
        private string[] userSettings;
        private string[] profileData;
    }
}
