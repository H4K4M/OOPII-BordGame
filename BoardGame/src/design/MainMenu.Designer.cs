
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
            this.settingbutton = new System.Windows.Forms.Button();
            this.quitbutton = new System.Windows.Forms.Button();
            this.Profilebut = new System.Windows.Forms.Button();
            this.managebut = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.BoardPanel = new System.Windows.Forms.Panel();
            this.helpbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingbutton
            // 
            this.settingbutton.Location = new System.Drawing.Point(12, 70);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(102, 23);
            this.settingbutton.TabIndex = 1;
            this.settingbutton.Text = "Setting";
            this.settingbutton.UseVisualStyleBackColor = true;
            this.settingbutton.Click += new System.EventHandler(this.settingbutton_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(12, 128);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(102, 23);
            this.quitbutton.TabIndex = 4;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // Profilebut
            // 
            this.Profilebut.Location = new System.Drawing.Point(12, 41);
            this.Profilebut.Name = "Profilebut";
            this.Profilebut.Size = new System.Drawing.Size(75, 23);
            this.Profilebut.TabIndex = 5;
            this.Profilebut.Text = "Profile";
            this.Profilebut.UseVisualStyleBackColor = true;
            this.Profilebut.Click += new System.EventHandler(this.Profilebut_Click);
            // 
            // managebut
            // 
            this.managebut.Location = new System.Drawing.Point(12, 12);
            this.managebut.Name = "managebut";
            this.managebut.Size = new System.Drawing.Size(102, 23);
            this.managebut.TabIndex = 6;
            this.managebut.Text = "ManageUsers";
            this.managebut.UseVisualStyleBackColor = true;
            this.managebut.Click += new System.EventHandler(this.managebut_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(12, 99);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(102, 23);
            this.AboutButton.TabIndex = 7;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // BoardPanel
            // 
            this.BoardPanel.Location = new System.Drawing.Point(156, 12);
            this.BoardPanel.Name = "BoardPanel";
            this.BoardPanel.Size = new System.Drawing.Size(426, 426);
            this.BoardPanel.TabIndex = 8;
            // 
            // helpbutton
            // 
            this.helpbutton.Location = new System.Drawing.Point(12, 157);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(75, 23);
            this.helpbutton.TabIndex = 9;
            this.helpbutton.Text = "Help";
            this.helpbutton.UseVisualStyleBackColor = true;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // MainMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 651);
            this.Controls.Add(this.helpbutton);
            this.Controls.Add(this.BoardPanel);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.managebut);
            this.Controls.Add(this.Profilebut);
            this.Controls.Add(this.settingbutton);
            this.Controls.Add(this.quitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainMenuPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button settingbutton;
        private System.Windows.Forms.Button quitbutton;
        private System.Windows.Forms.Button Profilebut;
        private System.Windows.Forms.Button managebut;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Panel BoardPanel;
        private System.Windows.Forms.Button helpbutton;
    }
}