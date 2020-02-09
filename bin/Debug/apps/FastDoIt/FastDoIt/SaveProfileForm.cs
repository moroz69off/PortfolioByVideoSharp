using System;
using System.Windows.Forms;

namespace MrzFastDoIt
{
    public partial class SaveProfileForm : Form
    {
        MainForm MF;
        BindSetting BindSetting;
        string profileName;


        public SaveProfileForm()
        {
            InitializeComponent();
            MF = new MainForm();
            Control.ControlCollection controls = MF.Controls;
            BindSetting = new BindSetting();

        }

        private void button_saveProfileName_Click(object sender, EventArgs e)
        {
            BindSetting.AppendIniFile("profileName: " + profileName + '\n');
            Close();
        }

        private void textBox_profileName_TextChanged(object sender, EventArgs e)
        {
            profileName = textBox_profileName.Text;
        }
    }
}
