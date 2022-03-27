
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
            this.settingpage = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.shapetext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.diffpanel = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.Label();
            this.custom = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.easy = new System.Windows.Forms.RadioButton();
            this.difficulty = new System.Windows.Forms.Label();
            this.settinglabel = new System.Windows.Forms.Label();
            this.quitbutton = new System.Windows.Forms.Button();
            this.settingpage.SuspendLayout();
            this.diffpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.Wellcome.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wellcome.Location = new System.Drawing.Point(181, 20);
            this.Wellcome.Name = "Wellcome";
            this.Wellcome.Size = new System.Drawing.Size(412, 23);
            this.Wellcome.TabIndex = 2;
            this.Wellcome.Text = "WellCome To The Game";
            // 
            // settingpage
            // 
            this.settingpage.Controls.Add(this.checkBox3);
            this.settingpage.Controls.Add(this.checkBox2);
            this.settingpage.Controls.Add(this.checkBox1);
            this.settingpage.Controls.Add(this.cancelbutton);
            this.settingpage.Controls.Add(this.savebutton);
            this.settingpage.Controls.Add(this.shapetext);
            this.settingpage.Controls.Add(this.label1);
            this.settingpage.Controls.Add(this.textBox2);
            this.settingpage.Controls.Add(this.textBox1);
            this.settingpage.Controls.Add(this.diffpanel);
            this.settingpage.Controls.Add(this.difficulty);
            this.settingpage.Controls.Add(this.settinglabel);
            this.settingpage.Location = new System.Drawing.Point(12, 12);
            this.settingpage.Name = "settingpage";
            this.settingpage.Size = new System.Drawing.Size(776, 426);
            this.settingpage.TabIndex = 3;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(426, 235);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 19);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Round";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(337, 235);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 19);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Triangle";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(256, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Square";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(437, 341);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 9;
            this.cancelbutton.Text = "CANCEL";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(256, 341);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // shapetext
            // 
            this.shapetext.AutoSize = true;
            this.shapetext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shapetext.Location = new System.Drawing.Point(169, 233);
            this.shapetext.Name = "shapetext";
            this.shapetext.Size = new System.Drawing.Size(47, 19);
            this.shapetext.TabIndex = 6;
            this.shapetext.Text = "Shape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(430, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 23);
            this.textBox1.TabIndex = 3;
            // 
            // diffpanel
            // 
            this.diffpanel.Controls.Add(this.text);
            this.diffpanel.Controls.Add(this.custom);
            this.diffpanel.Controls.Add(this.hard);
            this.diffpanel.Controls.Add(this.normal);
            this.diffpanel.Controls.Add(this.easy);
            this.diffpanel.Location = new System.Drawing.Point(256, 85);
            this.diffpanel.Name = "diffpanel";
            this.diffpanel.Size = new System.Drawing.Size(256, 100);
            this.diffpanel.TabIndex = 2;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.ForeColor = System.Drawing.Color.DarkCyan;
            this.text.Location = new System.Drawing.Point(136, 85);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(104, 15);
            this.text.TabIndex = 4;
            this.text.Text = "Enter size of board";
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custom.Location = new System.Drawing.Point(136, 57);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(84, 26);
            this.custom.TabIndex = 3;
            this.custom.TabStop = true;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.CheckedChanged += new System.EventHandler(this.custom_CheckedChanged);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hard.Location = new System.Drawing.Point(3, 57);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(65, 26);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.normal.Location = new System.Drawing.Point(136, 9);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(85, 26);
            this.normal.TabIndex = 1;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.easy.Location = new System.Drawing.Point(3, 9);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(62, 26);
            this.easy.TabIndex = 0;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficulty.Location = new System.Drawing.Point(169, 82);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(62, 19);
            this.difficulty.TabIndex = 1;
            this.difficulty.Text = "Difficulty";
            // 
            // settinglabel
            // 
            this.settinglabel.AutoSize = true;
            this.settinglabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settinglabel.Location = new System.Drawing.Point(330, 31);
            this.settinglabel.Name = "settinglabel";
            this.settinglabel.Size = new System.Drawing.Size(73, 24);
            this.settinglabel.TabIndex = 0;
            this.settinglabel.Text = "Setting";
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
            this.Controls.Add(this.settingpage);
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
            this.Load += new System.EventHandler(this.MainMenuPage_Load);
            this.settingpage.ResumeLayout(false);
            this.settingpage.PerformLayout();
            this.diffpanel.ResumeLayout(false);
            this.diffpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button settingbutton;
        private System.Windows.Forms.Label Wellcome;
        private System.Windows.Forms.Panel settingpage;
        private System.Windows.Forms.Panel diffpanel;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.Label settinglabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label shapetext;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button quitbutton;
    }
}