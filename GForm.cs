using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VideoSharpAppliedPortfolio
{
    public partial class GForm : Form
    {
        private readonly string currAppPath;
        public string[] apps;
        private int tagNum;
        ContentParser parser = new ContentParser();
        private string tag;
        public GForm()
        {
            InitializeComponent();
            currAppPath = parser.appPath;
            apps = parser.GetFolders();
            CreateButtons();
        }
        /// <summary>
        /// Creates buttons-links to project folders
        /// </summary>
        public void CreateButtons()
        {
            for (int i = 0; i < apps.Length; i++)
            {
                Button nextButton = new Button();
                nextButton.FlatStyle = FlatStyle.Flat;
                nextButton.Name = apps[i];
                nextButton.AutoSize = true;
                nextButton.Text = apps[i];
                nextButton.Tag = i.ToString();
                flowLayoutPanel_forButtons.Controls.Add(nextButton);
                nextButton.Click += new System.EventHandler(this.button__Click);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Eny button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button__Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tag = (string)b.Tag;
            tagNum = int.Parse(tag);
            ShowApp(tagNum);
        }
        ///// <summary>
        /// 
        /// </summary>
        /// <param name="tagN"></param>
        private void ShowApp(int tagN)
        {
            //get and start exe file
            string assemblyName = parser.GetAssemlyName(tagN);
            string strStartProcess = parser.appPath + "\\" + parser.apps[tagN] + "\\" + parser.apps[tagN] + "\\bin\\Debug\\" + assemblyName + ".exe";
            Process.Start(strStartProcess);
        }

        private void GForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // спросить: что делать с открытыми образцами приложений (если такие есть)
            // записать что-то в настройки программы
        }
    }
}
