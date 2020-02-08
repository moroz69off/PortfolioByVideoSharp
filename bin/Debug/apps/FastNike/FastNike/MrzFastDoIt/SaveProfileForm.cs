using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
