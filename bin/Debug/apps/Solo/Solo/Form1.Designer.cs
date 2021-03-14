namespace Solo
{
    partial class soloForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soloForm));
            this.labelSampleText = new System.Windows.Forms.Label();
            this.textBoxTypedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSpeedInfo = new System.Windows.Forms.Label();
            this.labelTimeInfo = new System.Windows.Forms.Label();
            this.labelTypeInfo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonChengeText = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // labelSampleText
            // 
            this.labelSampleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSampleText.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelSampleText.Location = new System.Drawing.Point(12, 9);
            this.labelSampleText.Name = "labelSampleText";
            this.labelSampleText.Size = new System.Drawing.Size(640, 169);
            this.labelSampleText.TabIndex = 0;
            this.labelSampleText.Text = "SampleText";
            // 
            // textBoxTypedText
            // 
            this.textBoxTypedText.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.textBoxTypedText.Location = new System.Drawing.Point(12, 181);
            this.textBoxTypedText.Multiline = true;
            this.textBoxTypedText.Name = "textBoxTypedText";
            this.textBoxTypedText.Size = new System.Drawing.Size(640, 169);
            this.textBoxTypedText.TabIndex = 1;
            this.textBoxTypedText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Набрано:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label3.Location = new System.Drawing.Point(193, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label4.Location = new System.Drawing.Point(447, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Скорость:";
            // 
            // labelSpeedInfo
            // 
            this.labelSpeedInfo.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelSpeedInfo.Location = new System.Drawing.Point(535, 371);
            this.labelSpeedInfo.Name = "labelSpeedInfo";
            this.labelSpeedInfo.Size = new System.Drawing.Size(117, 18);
            this.labelSpeedInfo.TabIndex = 7;
            this.labelSpeedInfo.Text = "--";
            // 
            // labelTimeInfo
            // 
            this.labelTimeInfo.AutoSize = true;
            this.labelTimeInfo.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelTimeInfo.Location = new System.Drawing.Point(271, 371);
            this.labelTimeInfo.Name = "labelTimeInfo";
            this.labelTimeInfo.Size = new System.Drawing.Size(18, 18);
            this.labelTimeInfo.TabIndex = 6;
            this.labelTimeInfo.Text = "--";
            // 
            // labelTypeInfo
            // 
            this.labelTypeInfo.AutoSize = true;
            this.labelTypeInfo.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelTypeInfo.Location = new System.Drawing.Point(84, 371);
            this.labelTypeInfo.Name = "labelTypeInfo";
            this.labelTypeInfo.Size = new System.Drawing.Size(18, 18);
            this.labelTypeInfo.TabIndex = 5;
            this.labelTypeInfo.Text = "--";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonChengeText
            // 
            this.buttonChengeText.AutoSize = true;
            this.buttonChengeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.buttonChengeText.Location = new System.Drawing.Point(27, 418);
            this.buttonChengeText.Name = "buttonChengeText";
            this.buttonChengeText.Padding = new System.Windows.Forms.Padding(5);
            this.buttonChengeText.Size = new System.Drawing.Size(182, 38);
            this.buttonChengeText.TabIndex = 8;
            this.buttonChengeText.Text = "Выбрать другой текст";
            this.buttonChengeText.UseVisualStyleBackColor = true;
            this.buttonChengeText.Click += new System.EventHandler(this.buttonChengeText_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.Location = new System.Drawing.Point(462, 418);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(190, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Выход без завершения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Solo";
            this.openFileDialog.Filter = "text files|*.txt";
            // 
            // soloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(664, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonChengeText);
            this.Controls.Add(this.labelSpeedInfo);
            this.Controls.Add(this.labelTimeInfo);
            this.Controls.Add(this.labelTypeInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTypedText);
            this.Controls.Add(this.labelSampleText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "soloForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Соло на клавиатуре";
            this.Load += new System.EventHandler(this.soloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSampleText;
        private System.Windows.Forms.TextBox textBoxTypedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSpeedInfo;
        private System.Windows.Forms.Label labelTimeInfo;
        private System.Windows.Forms.Label labelTypeInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonChengeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

