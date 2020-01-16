using System;
using System.Windows.Forms;

namespace triOtsenki
{
    public partial class GForm : Form
    {
        private int nr = 1;
        private int ruletka1, ruletka2, ruletka3;
        Random rand = new Random();
        public GForm()
        {
            InitializeComponent();
            timer1.Stop();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            nr++;
            ChengePic(nr);
        }

        private void ChengePic(int nr)
        {
            if (nr%3==0)
	        {
                pictureBox1.BackgroundImage = Properties.Resources.img1;
                pictureBox2.BackgroundImage = Properties.Resources.img2;
                pictureBox3.BackgroundImage = Properties.Resources.img3;
            }
            else if (nr % 3 == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.img2;
                pictureBox2.BackgroundImage = Properties.Resources.img3;
                pictureBox3.BackgroundImage = Properties.Resources.img1;
            }
            else if (nr%3==2)
            {
                pictureBox1.BackgroundImage = Properties.Resources.img3;
                pictureBox2.BackgroundImage = Properties.Resources.img1;
                pictureBox3.BackgroundImage = Properties.Resources.img2;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            nr = 0;
            if (!timer.Enabled) 
            {
                timer.Start();
                timer1.Stop();
            } else
            { 
                timer.Stop();
                ruletka1 = rand.Next(2, 8);
                ruletka2 = rand.Next(2, 8);
                ruletka3 = rand.Next(2, 8);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr++;
            ChengePic(nr);
            if (nr > ruletka1)
            {
                pictureBox1.Invalidate(true);
                if (ruletka1 % 3 == 0) pictureBox1.BackgroundImage = Properties.Resources.img1;
                else if (ruletka1 % 3 == 1) pictureBox1.BackgroundImage = Properties.Resources.img2;
                else if (ruletka1 % 3 == 2) pictureBox1.BackgroundImage = Properties.Resources.img3;
                
            } 
            if (nr > ruletka2)
            {
                pictureBox2.Invalidate(true);
                if (ruletka2 % 3 == 0) pictureBox2.BackgroundImage = Properties.Resources.img1;
                else if (ruletka2 % 3 == 1) pictureBox2.BackgroundImage = Properties.Resources.img2;
                else if (ruletka2 % 3 == 2) pictureBox2.BackgroundImage = Properties.Resources.img3;
            }
            if (nr > ruletka3)
            {
                pictureBox3.Invalidate(true);
                if (ruletka3 % 3 == 0) pictureBox3.BackgroundImage = Properties.Resources.img1;
                else if (ruletka3 % 3 == 1) pictureBox3.BackgroundImage = Properties.Resources.img2;
                else if (ruletka3 % 3 == 2) pictureBox3.BackgroundImage = Properties.Resources.img3;
            }

        }
    }
}
