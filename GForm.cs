using System;
using System.Windows.Forms;

namespace VideoSharpAppliedPortfolio
{
    public partial class GForm : Form
    {
        private string currAppPath;
        private string[] apps;
        private int tagNum;
        ContentParser parser = new ContentParser();
        private string tag;
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
            GetApp();
        }

        private void GetApp()
        {
            //get exe file
            MessageBox.Show(tag);
        }
    }
}
