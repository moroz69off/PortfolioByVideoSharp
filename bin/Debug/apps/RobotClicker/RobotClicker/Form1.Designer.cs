namespace RobotClicker
{
    partial class RobotClickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RobotClickerForm));
            this.buttonForClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForClick
            // 
            this.buttonForClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonForClick.Location = new System.Drawing.Point(0, 0);
            this.buttonForClick.Margin = new System.Windows.Forms.Padding(30);
            this.buttonForClick.Name = "buttonForClick";
            this.buttonForClick.Padding = new System.Windows.Forms.Padding(30);
            this.buttonForClick.Size = new System.Drawing.Size(288, 235);
            this.buttonForClick.TabIndex = 1;
            this.buttonForClick.Text = "Button";
            this.buttonForClick.UseVisualStyleBackColor = true;
            // 
            // RobotClickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 235);
            this.Controls.Add(this.buttonForClick);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RobotClickerForm";
            this.Text = "Robot clicker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonForClick;
    }
}

