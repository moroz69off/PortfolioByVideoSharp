using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RoboClicker
{
    public partial class clickerForm : Form
    {

        int clickLost = 0; // Сколько кликов осталось


        public clickerForm()
        {
            InitializeComponent();
            trackBarCountClick_Scroll(null,null);
            trackBarWaitClick_Scroll(null,null);
        }

        private void trackBarCountClick_Scroll(object sender, EventArgs e)
        {
            labelResultPropCountClick.Text = trackBarCountClick.Value.ToString();
        }

        private void trackBarWaitClick_Scroll(object sender, EventArgs e)
        {
            labelResultPropWaitClick.Text = trackBarWaitClick.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startClicker();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            makeClick();
        }

         public void makeClick()
        {
            clickLost--;
            DoMouseClick();
            if (clickLost == 0)
            {
                stopClicker();
            }

            
        }

        void stopClicker()
        {
            timer1.Enabled = false;
            button1.Enabled = true;
            
        }

        void startClicker()
        {
            clickLost = trackBarCountClick.Value;
            button1.Enabled = false;
            timer1.Interval = trackBarWaitClick.Value;
            timer1.Enabled = true;
           
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 5, 5);
        }
 
    }
}
