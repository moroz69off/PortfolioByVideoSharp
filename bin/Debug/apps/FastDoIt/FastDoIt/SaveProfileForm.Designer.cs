namespace MrzFastDoIt
{
    partial class SaveProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveProfileForm));
            this.label_saveProfile = new System.Windows.Forms.Label();
            this.textBox_profileName = new System.Windows.Forms.TextBox();
            this.button_saveProfileName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_saveProfile
            // 
            this.label_saveProfile.AutoSize = true;
            this.label_saveProfile.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_saveProfile.Location = new System.Drawing.Point(12, 9);
            this.label_saveProfile.Name = "label_saveProfile";
            this.label_saveProfile.Size = new System.Drawing.Size(144, 18);
            this.label_saveProfile.TabIndex = 0;
            this.label_saveProfile.Text = "Type profile name";
            // 
            // textBox_profileName
            // 
            this.textBox_profileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_profileName.Location = new System.Drawing.Point(15, 30);
            this.textBox_profileName.Name = "textBox_profileName";
            this.textBox_profileName.Size = new System.Drawing.Size(350, 25);
            this.textBox_profileName.TabIndex = 1;
            this.textBox_profileName.TextChanged += new System.EventHandler(this.textBox_profileName_TextChanged);
            // 
            // button_saveProfileName
            // 
            this.button_saveProfileName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_saveProfileName.Location = new System.Drawing.Point(371, 30);
            this.button_saveProfileName.Name = "button_saveProfileName";
            this.button_saveProfileName.Size = new System.Drawing.Size(93, 25);
            this.button_saveProfileName.TabIndex = 0;
            this.button_saveProfileName.Text = "S A V E";
            this.button_saveProfileName.UseVisualStyleBackColor = true;
            this.button_saveProfileName.Click += new System.EventHandler(this.button_saveProfileName_Click);
            // 
            // SaveProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 77);
            this.Controls.Add(this.button_saveProfileName);
            this.Controls.Add(this.textBox_profileName);
            this.Controls.Add(this.label_saveProfile);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Save profile";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_saveProfile;
        private System.Windows.Forms.TextBox textBox_profileName;
        private System.Windows.Forms.Button button_saveProfileName;
    }
}