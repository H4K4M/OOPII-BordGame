
namespace BoardGame.src.design
{
    partial class MainMenuPage
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
            this.startbutton = new System.Windows.Forms.Button();
            this.settingbutton = new System.Windows.Forms.Button();
            this.Wellcome = new System.Windows.Forms.Label();
            this.quitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startbutton.Location = new System.Drawing.Point(313, 106);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(148, 67);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            // 
            // settingbutton
            // 
            this.settingbutton.Location = new System.Drawing.Point(329, 179);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(119, 32);
            this.settingbutton.TabIndex = 1;
            this.settingbutton.Text = "Setting";
            this.settingbutton.UseVisualStyleBackColor = true;
            this.settingbutton.Click += new System.EventHandler(this.settingbutton_Click);
            // 
            // Wellcome
            // 
            this.Wellcome.AutoSize = true;
            this.Wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wellcome.Location = new System.Drawing.Point(272, 37);
            this.Wellcome.Name = "Wellcome";
            this.Wellcome.Size = new System.Drawing.Size(241, 24);
            this.Wellcome.TabIndex = 2;
            this.Wellcome.Text = "WellCome To The Game";
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(329, 232);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(119, 32);
            this.quitbutton.TabIndex = 4;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // MainMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wellcome);
            this.Controls.Add(this.settingbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.quitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button settingbutton;
        private System.Windows.Forms.Label Wellcome;
        private System.Windows.Forms.Button quitbutton;
    }
}