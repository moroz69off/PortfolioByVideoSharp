using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoSharpAppliedPortfolio
{
    public partial class GForm : Form
    {
        private string currAppPath;
        private string[] apps;
        private int tagNum;
        ContentParser parser = new ContentParser();
        public GForm()
        {
            InitializeComponent();
            currAppPath = parser.appPath;
            apps = parser.GetFolders();
            CreateFolders();
        }

        public void CreateFolders()
        {
            for (int i = 0; i < apps.Length; i++)
            {
                Button nextButton = new Button();
                nextButton.FlatStyle = FlatStyle.Flat;
                nextButton.Name = apps[i];
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

        private void button__Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string tag = (string)b.Tag;
            tagNum = Int32.Parse(tag);
            GetApp();
        }

        private void GetApp()
        {
            string appName = Directory.GetFiles("apps\\"+apps[tagNum], "*.exe")[0];
            Process.Start(appName);
        }
    }
}
