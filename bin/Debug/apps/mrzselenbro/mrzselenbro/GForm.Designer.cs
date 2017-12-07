namespace MrzSelenChr
{
    partial class GForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GForm));
            this.button = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCloseProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(200, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Поставить всем пятёрки";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 142);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(169, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть браузер";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCloseProgram
            // 
            this.buttonCloseProgram.BackColor = System.Drawing.Color.Gray;
            this.buttonCloseProgram.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseProgram.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonCloseProgram.Location = new System.Drawing.Point(187, 142);
            this.buttonCloseProgram.Name = "buttonCloseProgram";
            this.buttonCloseProgram.Size = new System.Drawing.Size(25, 23);
            this.buttonCloseProgram.TabIndex = 3;
            this.buttonCloseProgram.Text = "X";
            this.buttonCloseProgram.UseVisualStyleBackColor = false;
            this.buttonCloseProgram.Click += new System.EventHandler(this.buttonCloseProgram_Click);
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MrzSelenChr.Properties.Resources.fmap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(224, 180);
            this.Controls.Add(this.buttonCloseProgram);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "•••";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCloseProgram;
    }
}

