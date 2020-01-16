namespace camNozBum
{
    partial class MForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MForm));
            this.panelUserCam = new System.Windows.Forms.Panel();
            this.pictureUserCam = new System.Windows.Forms.PictureBox();
            this.panelUserNoz = new System.Windows.Forms.Panel();
            this.pictureUserNoz = new System.Windows.Forms.PictureBox();
            this.panelUserBum = new System.Windows.Forms.Panel();
            this.pictureUserBum = new System.Windows.Forms.PictureBox();
            this.panelRobo = new System.Windows.Forms.Panel();
            this.pictureRoboCam = new System.Windows.Forms.PictureBox();
            this.pictureRoboBum = new System.Windows.Forms.PictureBox();
            this.pictureRoboNoz = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelUser = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelRobo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUserCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserCam)).BeginInit();
            this.panelUserNoz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserNoz)).BeginInit();
            this.panelUserBum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserBum)).BeginInit();
            this.panelRobo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoboCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoboBum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoboNoz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserCam
            // 
            this.panelUserCam.BackColor = System.Drawing.SystemColors.Control;
            this.panelUserCam.Controls.Add(this.pictureUserCam);
            this.panelUserCam.Location = new System.Drawing.Point(12, 58);
            this.panelUserCam.Name = "panelUserCam";
            this.panelUserCam.Size = new System.Drawing.Size(132, 132);
            this.panelUserCam.TabIndex = 0;
            this.panelUserCam.Tag = "Cam";
            this.panelUserCam.MouseEnter += new System.EventHandler(this.PanelUserCam_MouseEnter);
            // 
            // pictureUserCam
            // 
            this.pictureUserCam.Image = global::camNozBum.Properties.Resources.userCam;
            this.pictureUserCam.Location = new System.Drawing.Point(0, 0);
            this.pictureUserCam.Name = "pictureUserCam";
            this.pictureUserCam.Size = new System.Drawing.Size(132, 132);
            this.pictureUserCam.TabIndex = 0;
            this.pictureUserCam.TabStop = false;
            this.pictureUserCam.Visible = false;
            this.pictureUserCam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureUserCam_MouseClick);
            // 
            // panelUserNoz
            // 
            this.panelUserNoz.BackColor = System.Drawing.SystemColors.Control;
            this.panelUserNoz.Controls.Add(this.pictureUserNoz);
            this.panelUserNoz.Location = new System.Drawing.Point(150, 58);
            this.panelUserNoz.Name = "panelUserNoz";
            this.panelUserNoz.Size = new System.Drawing.Size(132, 132);
            this.panelUserNoz.TabIndex = 1;
            this.panelUserNoz.Tag = "Noz";
            this.panelUserNoz.MouseEnter += new System.EventHandler(this.PanelUserCam_MouseEnter);
            // 
            // pictureUserNoz
            // 
            this.pictureUserNoz.Image = global::camNozBum.Properties.Resources.userNoz;
            this.pictureUserNoz.Location = new System.Drawing.Point(0, 0);
            this.pictureUserNoz.Name = "pictureUserNoz";
            this.pictureUserNoz.Size = new System.Drawing.Size(132, 132);
            this.pictureUserNoz.TabIndex = 2;
            this.pictureUserNoz.TabStop = false;
            this.pictureUserNoz.Visible = false;
            this.pictureUserNoz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureUserCam_MouseClick);
            // 
            // panelUserBum
            // 
            this.panelUserBum.BackColor = System.Drawing.SystemColors.Control;
            this.panelUserBum.Controls.Add(this.pictureUserBum);
            this.panelUserBum.Location = new System.Drawing.Point(288, 58);
            this.panelUserBum.Name = "panelUserBum";
            this.panelUserBum.Size = new System.Drawing.Size(132, 132);
            this.panelUserBum.TabIndex = 1;
            this.panelUserBum.Tag = "Bum";
            this.panelUserBum.MouseEnter += new System.EventHandler(this.PanelUserCam_MouseEnter);
            // 
            // pictureUserBum
            // 
            this.pictureUserBum.Image = global::camNozBum.Properties.Resources.userBum;
            this.pictureUserBum.Location = new System.Drawing.Point(0, 0);
            this.pictureUserBum.Name = "pictureUserBum";
            this.pictureUserBum.Size = new System.Drawing.Size(132, 132);
            this.pictureUserBum.TabIndex = 3;
            this.pictureUserBum.TabStop = false;
            this.pictureUserBum.Visible = false;
            this.pictureUserBum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureUserCam_MouseClick);
            // 
            // panelRobo
            // 
            this.panelRobo.BackColor = System.Drawing.SystemColors.Control;
            this.panelRobo.Controls.Add(this.pictureRoboCam);
            this.panelRobo.Controls.Add(this.pictureRoboBum);
            this.panelRobo.Controls.Add(this.pictureRoboNoz);
            this.panelRobo.Location = new System.Drawing.Point(600, 58);
            this.panelRobo.Name = "panelRobo";
            this.panelRobo.Size = new System.Drawing.Size(132, 132);
            this.panelRobo.TabIndex = 1;
            // 
            // pictureRoboCam
            // 
            this.pictureRoboCam.Image = global::camNozBum.Properties.Resources.roboCam;
            this.pictureRoboCam.Location = new System.Drawing.Point(0, 0);
            this.pictureRoboCam.Name = "pictureRoboCam";
            this.pictureRoboCam.Size = new System.Drawing.Size(132, 132);
            this.pictureRoboCam.TabIndex = 6;
            this.pictureRoboCam.TabStop = false;
            this.pictureRoboCam.Visible = false;
            // 
            // pictureRoboBum
            // 
            this.pictureRoboBum.Image = global::camNozBum.Properties.Resources.roboBum;
            this.pictureRoboBum.Location = new System.Drawing.Point(0, 0);
            this.pictureRoboBum.Name = "pictureRoboBum";
            this.pictureRoboBum.Size = new System.Drawing.Size(132, 132);
            this.pictureRoboBum.TabIndex = 4;
            this.pictureRoboBum.TabStop = false;
            this.pictureRoboBum.Visible = false;
            // 
            // pictureRoboNoz
            // 
            this.pictureRoboNoz.Image = global::camNozBum.Properties.Resources.roboNoz;
            this.pictureRoboNoz.Location = new System.Drawing.Point(0, 0);
            this.pictureRoboNoz.Name = "pictureRoboNoz";
            this.pictureRoboNoz.Size = new System.Drawing.Size(132, 132);
            this.pictureRoboNoz.TabIndex = 5;
            this.pictureRoboNoz.TabStop = false;
            this.pictureRoboNoz.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelUser
            // 
            this.labelUser.BackColor = System.Drawing.Color.Azure;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelUser.Location = new System.Drawing.Point(12, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(408, 46);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Выбирай!";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCount
            // 
            this.labelCount.BackColor = System.Drawing.Color.Azure;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelCount.Location = new System.Drawing.Point(12, 193);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(720, 46);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "Счёт";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRobo
            // 
            this.labelRobo.BackColor = System.Drawing.Color.Azure;
            this.labelRobo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelRobo.Location = new System.Drawing.Point(600, 9);
            this.labelRobo.Name = "labelRobo";
            this.labelRobo.Size = new System.Drawing.Size(132, 46);
            this.labelRobo.TabIndex = 4;
            this.labelRobo.Text = "Робот";
            this.labelRobo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::camNozBum.Properties.Resources.camNozBumTitle;
            this.pictureBox1.Location = new System.Drawing.Point(426, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 181);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(744, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelRobo);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.panelRobo);
            this.Controls.Add(this.panelUserBum);
            this.Controls.Add(this.panelUserNoz);
            this.Controls.Add(this.panelUserCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень | Ножницы | Бумага";
            this.panelUserCam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserCam)).EndInit();
            this.panelUserNoz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserNoz)).EndInit();
            this.panelUserBum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUserBum)).EndInit();
            this.panelRobo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoboCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoboBum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoboNoz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserCam;
        private System.Windows.Forms.Panel panelUserNoz;
        private System.Windows.Forms.Panel panelUserBum;
        private System.Windows.Forms.Panel panelRobo;
        private System.Windows.Forms.PictureBox pictureUserCam;
        private System.Windows.Forms.PictureBox pictureUserNoz;
        private System.Windows.Forms.PictureBox pictureUserBum;
        private System.Windows.Forms.PictureBox pictureRoboBum;
        private System.Windows.Forms.PictureBox pictureRoboNoz;
        private System.Windows.Forms.PictureBox pictureRoboCam;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelRobo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

