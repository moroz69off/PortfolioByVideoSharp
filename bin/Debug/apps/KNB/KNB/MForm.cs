using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace camNozBum
{
    public partial class MForm : Form
    {
        string userFig = "";
        string roboFig = "";
        Random rand = new Random();
        int scoreUser = 0;
        int scoreRobo = 0;
        int scoreNihto = 0;
        string mode = "show";

        public MForm()
        {
            InitializeComponent();
            ShowScore();
        }

        private void StartGame()
        {
            if (mode != "game")
            {
                labelUser.Text = "Выбирай!";
                mode = "game";
            }
        }

        private void ShowUserFig(string fig)
        {
            StartGame();
            pictureUserCam.Visible = fig == "Cam";
            pictureUserNoz.Visible = fig == "Noz";
            pictureUserBum.Visible = fig == "Bum";
            userFig = fig;
        }

        private void ShowRoboFig(string fig)
        {
            pictureRoboCam.Visible = fig == "Cam";
            pictureRoboNoz.Visible = fig == "Noz";
            pictureRoboBum.Visible = fig == "Bum";
            roboFig = fig;
        }

        private void PanelUserCam_MouseEnter(object sender, EventArgs e)
        {
            ShowUserFig((((Panel)sender).Tag).ToString());
        }

        private void RoboRandomFig()
        {
            int f = rand.Next(1, 4);
            if (f == 1) ShowRoboFig("Cam");
            if (f == 2) ShowRoboFig("Noz");
            if (f == 3) ShowRoboFig("Bum");
        }

        private void ShowScore()
        {
            labelCount.Text = "Победы:"+ scoreUser.ToString() + 
                              "  Ничья:"+ scoreNihto.ToString() +
                              "  Остальные:"+ scoreRobo.ToString();
        }

        private void PictureUserCam_MouseClick(object sender, MouseEventArgs e)
        {
            CheckResult();
        }

        private void CheckResult()
        {
            mode = "show";
            int user = 0;
            int robo = 0;
            int nihto = 0;

            if (userFig == roboFig) nihto = 1;
            else
            {

                if (userFig == "Cam")
                    if (roboFig == "Noz")
                        user = 1;
                    else robo = 1;
                if (userFig == "Noz")
                    if (roboFig == "Bum")
                        user = 1;
                    else robo = 1;
                if (userFig == "Bum")
                    if (roboFig == "Cam")
                        user = 1;
                    else robo = 1;
            }

            scoreUser += user;
            scoreRobo += robo;
            scoreNihto += nihto;

            if (user > 0) labelUser.Text = "Победа! :)";
            if (robo > 0) labelUser.Text = ":(";
            if (nihto > 0) labelUser.Text = "Ничья :|";
            ShowScore();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RoboRandomFig();
        }
    }
}
