using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Solo
{
    public partial class soloForm : Form
    {
        int totalSimbols;
        int typedSimbols;
        int speed;
        DateTime startTime;
        DateTime currentTime;
        string messageResultVariant;
        string textFileName = "Solo.txt";

        public soloForm()
        {
            InitializeComponent();
        }

        private void soloForm_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            try
            {
                labelSampleText.Text = File.ReadAllText(textFileName, Encoding.Default);
            }

            catch
            {
                labelSampleText.Text = "Текст-образец нужно разместить в папке Debug с именем Solo.txt";
            }

            textBoxTypedText.Text = "";
            totalSimbols = labelSampleText.Text.Length;
            typedSimbols = 0;
            startTime = DateTime.Now;
            currentTime = DateTime.Now;
            speed = 0;
            timer.Enabled = true;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            showStat();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            showStat();
        }

        private void showStat()
        {
            typedSimbols = textBoxTypedText.Text.Length;
            labelTypeInfo.Text =typedSimbols.ToString() + "/" + totalSimbols.ToString() + "симв.";


            bool error;
            if (typedSimbols > 0)
            {
                if (labelSampleText.Text.StartsWith(textBoxTypedText.Text))
                    error = false;
                else
                    error = true;
            }
            else
            {
                error = false;
                startTime = DateTime.Now;
            }
            textBoxTypedText.BackColor = error ? Color.LightPink : Color.White;

            currentTime = DateTime.Now;
            double seconds = (currentTime.Ticks - startTime.Ticks) / 10000000.0;
            labelTimeInfo.Text = seconds.ToString("0.0") + "сек.";
            if (seconds > 0.1)
                speed = Convert.ToInt16(typedSimbols * 60 / seconds);
            else
                speed = 0;
            labelSpeedInfo.Text = speed.ToString() + "символов в минуту.";

            if (!error && typedSimbols == totalSimbols)
                finishGame();
        }

        private void messgeresultVariant()
        {
            
            if (speed >= 555) messageResultVariant = " Прими поздравления! Тебе нет равных в скорости набора.";
                else if  (speed <= 60) messageResultVariant = " Ужасный результат! Попробуй набирать текст хотя бы двумя пальцами.";
            else messageResultVariant = " Молодец! Хорошая скорость набора.";
        }

        private void finishGame()
        {
            messgeresultVariant();
            timer.Enabled = false;
            MessageBox.Show("Набор закончен. Скорость набора: " + labelSpeedInfo.Text + messageResultVariant);  
            init();
        }

        private void buttonChengeText_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFileName = openFileDialog.FileName;
                init();
            }
        }   
    }
}
