using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
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
            timer = new System.Timers.Timer();
            bindSetting = new BindSetting();
            profiles = bindSetting.GetProfiles();
            DropListIni(profiles);
            acntStr = new string[12];
            userLoginPrefs = new string[] {"",""};
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

        private void DropListIni(string[] profiles)
        {
            comboBox_profileSelect.Items.AddRange(profiles);
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
            userSettings = GetUserPreferences();
        }

        string[] GetUserPreferences()
        {
            cardCsv = textBox_csvInput.Text;//не надо
            mdlName = textBox_middleName.Text;
            return new string[] { mdlName, cardCsv };
        }

        private void GetSizeModel()
        {
            sizeMdl = comboBox_sizeSelect.Text.Replace("US ", "");
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
            NP.MaximizeChromeWindow();
            NikeProvider.driverService.HideCommandPromptWindow = true;
            NP.Driver.Navigate().GoToUrl("https://www.nike.com/ru/launch/?s=upcoming");
        }

        private void TextBox_eMail_TextChanged(object sender, EventArgs e)
        {
            if (textBox_eMail.Text.Contains(@"@")) userLoginPrefs[0] = textBox_eMail.Text;
            acntStr[0] = textBox_eMail.Text;
        }

        private void TextBox_passWord_TextChanged(object sender, EventArgs e)
        {
            userLoginPrefs[1] = textBox_passWord.Text;
            acntStr[1] = textBox_passWord.Text;
        }

        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {
            acntStr[2] = textBox_name.Text;
        }

        private void TextBox_middleName_TextChanged(object sender, EventArgs e)
        {
            mdlName = textBox_middleName.Text;
            acntStr[3] = textBox_middleName.Text;
        }

        private void TextBox_surname_TextChanged(object sender, EventArgs e)
        {
            acntStr[4] = textBox_surname.Text;
        }

        private void TextBox_cardNumber_TextChanged(object sender, EventArgs e)
        {
            cardNum = textBox_cardNumber.Text;
            acntStr[5] = textBox_cardNumber.Text;
        }

        private void TextBox_dateValidMonth_TextChanged(object sender, EventArgs e)
        {
            cardVaM = textBox_dateValidMonth.Text;
            acntStr[6] = textBox_dateValidMonth.Text;
        }

        private void TextBox_dateValidYear_TextChanged(object sender, EventArgs e)
        {
            cardVaY = textBox_dateValidYear.Text;
            acntStr[7] = textBox_dateValidYear.Text;
        }

        private void TextBox_csvInput_TextChanged(object sender, EventArgs e)
        {
            if (textBox_csvInput.Text.Length == 3) cardCsv = textBox_csvInput.Text;
            acntStr[8] = textBox_csvInput.Text;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            timeOfTask = dateTimePicker.Value;
            timerDa = timeOfTask.Date.ToString().Substring(0, 10);
            timerTa = timeOfTask.TimeOfDay.ToString();
            acntStr[9] = dateTimePicker.Value.ToString();
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

            textBox_name.Text           = bindSetting.accountNamee;
            textBox_eMail.Text          = bindSetting.accountEmail;
            textBox_passWord.Text       = bindSetting.accountPassw;
            textBox_surname.Text        = bindSetting.accountSName;
            textBox_middleName.Text     = bindSetting.accountMName;
            textBox_cardNumber.Text     = bindSetting.accontCrdNum;
            textBox_dateValidMonth.Text = bindSetting.cardMonVdate;
            textBox_dateValidYear.Text  = bindSetting.cardYeaVdate;
            textBox_csvInput.Text       = bindSetting.accontCrdCsv;
        }

        private void comboBox_sizeSelect_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private string cardCsv;
        private string releasD;
        private string releasT;
        private string timerDa;
        private string timerTa;
        private string cardNum;
        private string cardVaY;
        private string cardVaM;
        private string sizeMdl;
        private string mdlName;
        private string ordrStr;
        private string[] acntStr;
        private string[] userLoginPrefs;
        private string[] profiles;
        private string[] modelInfo;
        private string[] taskArray;
        private string[] userSettings;
        private string[] profileData;
    }
}
