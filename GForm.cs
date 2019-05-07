using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VideoSharpAppliedPortfolio
{
    public partial class GForm : Form
    {
        private string currAppPath;
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

        private void button__Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tag = (string)b.Tag;
            tagNum = Int32.Parse(tag);
            ShowApp(tagNum);
        }

        private void ShowApp(int tagN)
        {
            //get and start exe
            string assemblyName = parser.GetAssemlyName(tagN);

            MessageBox.Show(assemblyName+ ".exe");
        }


    }
}
