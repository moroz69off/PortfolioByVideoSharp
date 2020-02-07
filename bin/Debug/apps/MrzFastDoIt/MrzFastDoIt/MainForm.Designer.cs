namespace NikeFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox_eMail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox_passWord = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.label_middleName = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_middleName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_account = new System.Windows.Forms.TabPage();
            this.tabPage_paymentCard = new System.Windows.Forms.TabPage();
            this.label_slash = new System.Windows.Forms.Label();
            this.textBox_dateValidYear = new System.Windows.Forms.TextBox();
            this.label_CSV = new System.Windows.Forms.Label();
            this.textBox_csvInput = new System.Windows.Forms.TextBox();
            this.label_validityDate = new System.Windows.Forms.Label();
            this.textBox_dateValidMonth = new System.Windows.Forms.TextBox();
            this.label_paymentCard = new System.Windows.Forms.Label();
            this.textBox_cardNumber = new System.Windows.Forms.TextBox();
            this.tabPage_taskSet = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage_account.SuspendLayout();
            this.tabPage_paymentCard.SuspendLayout();
            this.tabPage_taskSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonStart.Location = new System.Drawing.Point(160, 410);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 28);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START NEW";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox_eMail
            // 
            this.textBox_eMail.Location = new System.Drawing.Point(25, 54);
            this.textBox_eMail.Name = "textBox_eMail";
            this.textBox_eMail.Size = new System.Drawing.Size(223, 25);
            this.textBox_eMail.TabIndex = 1;
            this.textBox_eMail.TextChanged += new System.EventHandler(this.textBox_eMail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelEmail.Location = new System.Drawing.Point(22, 33);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(56, 18);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-Mail";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelPassword.Location = new System.Drawing.Point(22, 92);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(72, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBox_passWord
            // 
            this.textBox_passWord.Location = new System.Drawing.Point(25, 113);
            this.textBox_passWord.Name = "textBox_passWord";
            this.textBox_passWord.PasswordChar = '•';
            this.textBox_passWord.Size = new System.Drawing.Size(223, 25);
            this.textBox_passWord.TabIndex = 4;
            this.textBox_passWord.UseSystemPasswordChar = true;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_name.Location = new System.Drawing.Point(22, 145);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(40, 18);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(25, 166);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(223, 25);
            this.textBox_name.TabIndex = 6;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelSurname.Location = new System.Drawing.Point(22, 198);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(64, 18);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Surname";
            // 
            // label_middleName
            // 
            this.label_middleName.AutoSize = true;
            this.label_middleName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_middleName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_middleName.Location = new System.Drawing.Point(22, 256);
            this.label_middleName.Name = "label_middleName";
            this.label_middleName.Size = new System.Drawing.Size(96, 18);
            this.label_middleName.TabIndex = 9;
            this.label_middleName.Text = "Middle name";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(25, 219);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(223, 25);
            this.textBox_surname.TabIndex = 10;
            // 
            // textBox_middleName
            // 
            this.textBox_middleName.Location = new System.Drawing.Point(25, 277);
            this.textBox_middleName.Name = "textBox_middleName";
            this.textBox_middleName.Size = new System.Drawing.Size(223, 25);
            this.textBox_middleName.TabIndex = 11;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePicker.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(20, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(226, 25);
            this.dateTimePicker.TabIndex = 12;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_account);
            this.tabControl.Controls.Add(this.tabPage_paymentCard);
            this.tabControl.Controls.Add(this.tabPage_taskSet);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(287, 388);
            this.tabControl.TabIndex = 13;
            // 
            // tabPage_account
            // 
            this.tabPage_account.Controls.Add(this.textBox_name);
            this.tabPage_account.Controls.Add(this.textBox_eMail);
            this.tabPage_account.Controls.Add(this.textBox_middleName);
            this.tabPage_account.Controls.Add(this.labelEmail);
            this.tabPage_account.Controls.Add(this.textBox_surname);
            this.tabPage_account.Controls.Add(this.labelPassword);
            this.tabPage_account.Controls.Add(this.label_middleName);
            this.tabPage_account.Controls.Add(this.textBox_passWord);
            this.tabPage_account.Controls.Add(this.labelSurname);
            this.tabPage_account.Controls.Add(this.label_name);
            this.tabPage_account.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage_account.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage_account.Location = new System.Drawing.Point(4, 27);
            this.tabPage_account.Name = "tabPage_account";
            this.tabPage_account.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_account.Size = new System.Drawing.Size(279, 357);
            this.tabPage_account.TabIndex = 0;
            this.tabPage_account.Text = "Account";
            this.tabPage_account.UseVisualStyleBackColor = true;
            // 
            // tabPage_paymentCard
            // 
            this.tabPage_paymentCard.Controls.Add(this.label_slash);
            this.tabPage_paymentCard.Controls.Add(this.textBox_dateValidYear);
            this.tabPage_paymentCard.Controls.Add(this.label_CSV);
            this.tabPage_paymentCard.Controls.Add(this.textBox_csvInput);
            this.tabPage_paymentCard.Controls.Add(this.label_validityDate);
            this.tabPage_paymentCard.Controls.Add(this.textBox_dateValidMonth);
            this.tabPage_paymentCard.Controls.Add(this.label_paymentCard);
            this.tabPage_paymentCard.Controls.Add(this.textBox_cardNumber);
            this.tabPage_paymentCard.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tabPage_paymentCard.Location = new System.Drawing.Point(4, 27);
            this.tabPage_paymentCard.Name = "tabPage_paymentCard";
            this.tabPage_paymentCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_paymentCard.Size = new System.Drawing.Size(279, 357);
            this.tabPage_paymentCard.TabIndex = 1;
            this.tabPage_paymentCard.Text = "Payment card";
            this.tabPage_paymentCard.UseVisualStyleBackColor = true;
            // 
            // label_slash
            // 
            this.label_slash.AutoSize = true;
            this.label_slash.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_slash.Location = new System.Drawing.Point(68, 98);
            this.label_slash.Name = "label_slash";
            this.label_slash.Size = new System.Drawing.Size(20, 22);
            this.label_slash.TabIndex = 7;
            this.label_slash.Text = "/";
            // 
            // textBox_dateValidYear
            // 
            this.textBox_dateValidYear.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dateValidYear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_dateValidYear.Location = new System.Drawing.Point(94, 99);
            this.textBox_dateValidYear.Name = "textBox_dateValidYear";
            this.textBox_dateValidYear.Size = new System.Drawing.Size(56, 25);
            this.textBox_dateValidYear.TabIndex = 6;
            this.textBox_dateValidYear.Text = "YY";
            this.textBox_dateValidYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_CSV
            // 
            this.label_CSV.AutoSize = true;
            this.label_CSV.Location = new System.Drawing.Point(194, 78);
            this.label_CSV.Name = "label_CSV";
            this.label_CSV.Size = new System.Drawing.Size(32, 18);
            this.label_CSV.TabIndex = 5;
            this.label_CSV.Text = "CSV";
            // 
            // textBox_csvInput
            // 
            this.textBox_csvInput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_csvInput.Location = new System.Drawing.Point(197, 98);
            this.textBox_csvInput.Name = "textBox_csvInput";
            this.textBox_csvInput.Size = new System.Drawing.Size(74, 25);
            this.textBox_csvInput.TabIndex = 4;
            this.textBox_csvInput.TextChanged += new System.EventHandler(this.textBox_csvInput_TextChanged);
            // 
            // label_validityDate
            // 
            this.label_validityDate.AutoSize = true;
            this.label_validityDate.Location = new System.Drawing.Point(8, 78);
            this.label_validityDate.Name = "label_validityDate";
            this.label_validityDate.Size = new System.Drawing.Size(112, 18);
            this.label_validityDate.TabIndex = 3;
            this.label_validityDate.Text = "Validity date";
            // 
            // textBox_dateValidMonth
            // 
            this.textBox_dateValidMonth.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_dateValidMonth.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_dateValidMonth.Location = new System.Drawing.Point(8, 98);
            this.textBox_dateValidMonth.Name = "textBox_dateValidMonth";
            this.textBox_dateValidMonth.Size = new System.Drawing.Size(54, 25);
            this.textBox_dateValidMonth.TabIndex = 2;
            this.textBox_dateValidMonth.Text = "MM";
            this.textBox_dateValidMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_paymentCard
            // 
            this.label_paymentCard.AutoSize = true;
            this.label_paymentCard.Location = new System.Drawing.Point(8, 15);
            this.label_paymentCard.Name = "label_paymentCard";
            this.label_paymentCard.Size = new System.Drawing.Size(96, 18);
            this.label_paymentCard.TabIndex = 1;
            this.label_paymentCard.Text = "Card number";
            // 
            // textBox_cardNumber
            // 
            this.textBox_cardNumber.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_cardNumber.Location = new System.Drawing.Point(8, 35);
            this.textBox_cardNumber.Name = "textBox_cardNumber";
            this.textBox_cardNumber.Size = new System.Drawing.Size(263, 25);
            this.textBox_cardNumber.TabIndex = 0;
            // 
            // tabPage_taskSet
            // 
            this.tabPage_taskSet.Controls.Add(this.dateTimePicker);
            this.tabPage_taskSet.Location = new System.Drawing.Point(4, 27);
            this.tabPage_taskSet.Name = "tabPage_taskSet";
            this.tabPage_taskSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_taskSet.Size = new System.Drawing.Size(279, 357);
            this.tabPage_taskSet.TabIndex = 2;
            this.tabPage_taskSet.Text = "Task set";
            this.tabPage_taskSet.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(287, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FastNike";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabPage_account.ResumeLayout(false);
            this.tabPage_account.PerformLayout();
            this.tabPage_paymentCard.ResumeLayout(false);
            this.tabPage_paymentCard.PerformLayout();
            this.tabPage_taskSet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox_eMail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox_passWord;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label label_middleName;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_middleName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_account;
        private System.Windows.Forms.TabPage tabPage_paymentCard;
        private System.Windows.Forms.Label label_slash;
        private System.Windows.Forms.TextBox textBox_dateValidYear;
        private System.Windows.Forms.Label label_CSV;
        private System.Windows.Forms.TextBox textBox_csvInput;
        private System.Windows.Forms.Label label_validityDate;
        private System.Windows.Forms.TextBox textBox_dateValidMonth;
        private System.Windows.Forms.Label label_paymentCard;
        private System.Windows.Forms.TextBox textBox_cardNumber;
        private System.Windows.Forms.TabPage tabPage_taskSet;
    }
}

