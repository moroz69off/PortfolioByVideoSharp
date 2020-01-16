namespace RoboClicker
{
    partial class clickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clickerForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarCountClick = new System.Windows.Forms.TrackBar();
            this.trackBarWaitClick = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelResultPropWaitClick = new System.Windows.Forms.Label();
            this.labelResultPropCountClick = new System.Windows.Forms.Label();
            this.labelWaitClick = new System.Windows.Forms.Label();
            this.labelCountClick = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaitClick)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(492, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarCountClick
            // 
            this.trackBarCountClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarCountClick.LargeChange = 10;
            this.trackBarCountClick.Location = new System.Drawing.Point(238, 53);
            this.trackBarCountClick.Maximum = 100;
            this.trackBarCountClick.Minimum = 1;
            this.trackBarCountClick.Name = "trackBarCountClick";
            this.trackBarCountClick.Size = new System.Drawing.Size(245, 45);
            this.trackBarCountClick.TabIndex = 1;
            this.trackBarCountClick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarCountClick.Value = 1;
            this.trackBarCountClick.Scroll += new System.EventHandler(this.trackBarCountClick_Scroll);
            // 
            // trackBarWaitClick
            // 
            this.trackBarWaitClick.LargeChange = 100;
            this.trackBarWaitClick.Location = new System.Drawing.Point(238, 138);
            this.trackBarWaitClick.Maximum = 1000;
            this.trackBarWaitClick.Minimum = 1;
            this.trackBarWaitClick.Name = "trackBarWaitClick";
            this.trackBarWaitClick.Size = new System.Drawing.Size(245, 45);
            this.trackBarWaitClick.SmallChange = 10;
            this.trackBarWaitClick.TabIndex = 2;
            this.trackBarWaitClick.TickFrequency = 100;
            this.trackBarWaitClick.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarWaitClick.Value = 1;
            this.trackBarWaitClick.Scroll += new System.EventHandler(this.trackBarWaitClick_Scroll);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.Controls.Add(this.trackBarWaitClick, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelResultPropWaitClick, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelResultPropCountClick, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelWaitClick, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCountClick, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBarCountClick, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 220);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelResultPropWaitClick
            // 
            this.labelResultPropWaitClick.AutoSize = true;
            this.labelResultPropWaitClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultPropWaitClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultPropWaitClick.Location = new System.Drawing.Point(144, 135);
            this.labelResultPropWaitClick.Name = "labelResultPropWaitClick";
            this.labelResultPropWaitClick.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelResultPropWaitClick.Size = new System.Drawing.Size(88, 85);
            this.labelResultPropWaitClick.TabIndex = 6;
            this.labelResultPropWaitClick.Text = "--";
            this.labelResultPropWaitClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelResultPropCountClick
            // 
            this.labelResultPropCountClick.AutoSize = true;
            this.labelResultPropCountClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResultPropCountClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResultPropCountClick.Location = new System.Drawing.Point(144, 50);
            this.labelResultPropCountClick.Name = "labelResultPropCountClick";
            this.labelResultPropCountClick.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelResultPropCountClick.Size = new System.Drawing.Size(88, 85);
            this.labelResultPropCountClick.TabIndex = 5;
            this.labelResultPropCountClick.Text = "--";
            this.labelResultPropCountClick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelWaitClick
            // 
            this.labelWaitClick.AutoSize = true;
            this.labelWaitClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWaitClick.Location = new System.Drawing.Point(3, 135);
            this.labelWaitClick.Name = "labelWaitClick";
            this.labelWaitClick.Size = new System.Drawing.Size(135, 85);
            this.labelWaitClick.TabIndex = 4;
            this.labelWaitClick.Text = "Задержка кликов (ms)";
            this.labelWaitClick.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCountClick
            // 
            this.labelCountClick.AutoSize = true;
            this.labelCountClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCountClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountClick.Location = new System.Drawing.Point(3, 50);
            this.labelCountClick.Name = "labelCountClick";
            this.labelCountClick.Size = new System.Drawing.Size(135, 85);
            this.labelCountClick.TabIndex = 3;
            this.labelCountClick.Text = "Количество кликов";
            this.labelCountClick.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(235, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Начать кликать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(743, 269);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "clickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Робот-кликер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCountClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaitClick)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarCountClick;
        private System.Windows.Forms.TrackBar trackBarWaitClick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelWaitClick;
        private System.Windows.Forms.Label labelCountClick;
        private System.Windows.Forms.Label labelResultPropWaitClick;
        private System.Windows.Forms.Label labelResultPropCountClick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

