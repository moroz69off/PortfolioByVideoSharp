using System;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint
{
    public partial class labirintForm : Form
    {

        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(Labirint.Properties.Resources.crushSound);
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(Labirint.Properties.Resources.finishSound);
        System.Media.SoundPlayer bonusSoundPlayer = new System.Media.SoundPlayer(Labirint.Properties.Resources.bonusSound);
        int muhomorTotal = 8;
        int muhomor;

        public labirintForm()
        {
            InitializeComponent();
            bonusSoundPlayer.Play();
            firstStart();
            muhomor = muhomorTotal;
        }



        //============================================================
        private void firstStart()
        {
            Point startPoint = labelStart.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
        }
        //============================================================


        //=====================F I N I S H============================
        /// <summary>
        /// Событие наведения указателя мыши на элемент Финиш
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            if (muhomor > 0)
            {
                showStatus();
                startSoundPlayer.Play();
            }
            else
            {
                labelFinish.Image = Labirint.Properties.Resources.doorOpen;
                finishSoundPlayer.Play();
                MessageBox.Show("Молодец!");
                Close();
            }
        }
        //============================================================


        //==M E T H O D   C R U S H  A N D   B A C K   T O   S T A R T
        /// <summary>
        /// Этот метод возвращает курсор в указанную точку(здесь - на старт)
        /// </summary>
        private void backToStart()
        {
            Point startPoint = labelStart.Location;
            startPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startPoint);
            startSoundPlayer.Play();
        }
        //============================================================



        //============================================================
        /// <summary>
        /// Событие наведения указателя мыши на элемент "стена"(label)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wallMouseEnter(object sender, EventArgs e)
        {
            backToStart();
        }
        //============================================================


        //============================================================
        // Блок собирания грибов
        //============================================================
        /// <summary>
        /// Скрывает гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает второй гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus1_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus1.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает третий гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus2_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus2.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает четвёртый гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus3_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus3.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает пятый гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus4_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus4.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает шестой гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus5_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus5.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает седьмой гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus6_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus6.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        /// <summary>
        /// Скрывает восьмой гриб
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBonus7_Click(object sender, EventArgs e)
        {
            bonusSoundPlayer.Play();
            labelBonus7.Visible = false;
            muhomor--;
            labelMesage.Visible = false;
        }
        //=============================================================

        //=============================================================
        private void showStatus()
        {
            labelMesage.Visible = true;
        }
        //=============================================================
        

    }
}
