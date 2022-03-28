
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
            this.ColourBox = new System.Windows.Forms.GroupBox();
            this.BlueColour = new System.Windows.Forms.CheckBox();
            this.GreenColour = new System.Windows.Forms.CheckBox();
            this.RedColour = new System.Windows.Forms.CheckBox();
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
            this.ColourBox.SuspendLayout();
            this.diffpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startbutton.Location = new System.Drawing.Point(358, 141);
            this.startbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(169, 89);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            // 
            // settingbutton
            // 
            this.settingbutton.Location = new System.Drawing.Point(376, 239);
            this.settingbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(136, 43);
            this.settingbutton.TabIndex = 1;
            this.settingbutton.Text = "Setting";
            this.settingbutton.UseVisualStyleBackColor = true;
            this.settingbutton.Click += new System.EventHandler(this.settingbutton_Click);
            // 
            // Wellcome
            // 
            this.Wellcome.AutoSize = true;
            this.Wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wellcome.Location = new System.Drawing.Point(207, 27);
            this.Wellcome.Name = "Wellcome";
            this.Wellcome.Size = new System.Drawing.Size(302, 29);
            this.Wellcome.TabIndex = 2;
            this.Wellcome.Text = "WellCome To The Game";
            // 
            // settingpage
            // 
            this.settingpage.Controls.Add(this.ColourBox);
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
            this.settingpage.Location = new System.Drawing.Point(14, 16);
            this.settingpage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingpage.Name = "settingpage";
            this.settingpage.Size = new System.Drawing.Size(887, 568);
            this.settingpage.TabIndex = 3;
            // 
            // ColourBox
            // 
            this.ColourBox.Controls.Add(this.BlueColour);
            this.ColourBox.Controls.Add(this.GreenColour);
            this.ColourBox.Controls.Add(this.RedColour);
            this.ColourBox.Location = new System.Drawing.Point(129, 362);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Size = new System.Drawing.Size(584, 73);
            this.ColourBox.TabIndex = 13;
            this.ColourBox.TabStop = false;
            this.ColourBox.Text = "Colour";
            this.ColourBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BlueColour
            // 
            this.BlueColour.AutoSize = true;
            this.BlueColour.Location = new System.Drawing.Point(246, 37);
            this.BlueColour.Name = "BlueColour";
            this.BlueColour.Size = new System.Drawing.Size(60, 24);
            this.BlueColour.TabIndex = 2;
            this.BlueColour.Text = "Blue";
            this.BlueColour.UseVisualStyleBackColor = true;
            this.BlueColour.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // GreenColour
            // 
            this.GreenColour.AutoSize = true;
            this.GreenColour.Location = new System.Drawing.Point(139, 37);
            this.GreenColour.Name = "GreenColour";
            this.GreenColour.Size = new System.Drawing.Size(70, 24);
            this.GreenColour.TabIndex = 1;
            this.GreenColour.Text = "Green";
            this.GreenColour.UseVisualStyleBackColor = true;
            // 
            // RedColour
            // 
            this.RedColour.AutoSize = true;
            this.RedColour.Location = new System.Drawing.Point(32, 37);
            this.RedColour.Name = "RedColour";
            this.RedColour.Size = new System.Drawing.Size(57, 24);
            this.RedColour.TabIndex = 0;
            this.RedColour.Text = "Red";
            this.RedColour.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(487, 313);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 24);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Round";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(385, 313);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Triangle";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(293, 313);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Square";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(499, 455);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(86, 31);
            this.cancelbutton.TabIndex = 9;
            this.cancelbutton.Text = "CANCEL";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(293, 455);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(86, 31);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // shapetext
            // 
            this.shapetext.AutoSize = true;
            this.shapetext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shapetext.Location = new System.Drawing.Point(193, 311);
            this.shapetext.Name = "shapetext";
            this.shapetext.Size = new System.Drawing.Size(58, 22);
            this.shapetext.TabIndex = 6;
            this.shapetext.Text = "Shape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(491, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(520, 255);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 27);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(453, 255);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 27);
            this.textBox1.TabIndex = 3;
            // 
            // diffpanel
            // 
            this.diffpanel.Controls.Add(this.text);
            this.diffpanel.Controls.Add(this.custom);
            this.diffpanel.Controls.Add(this.hard);
            this.diffpanel.Controls.Add(this.normal);
            this.diffpanel.Controls.Add(this.easy);
            this.diffpanel.Location = new System.Drawing.Point(293, 113);
            this.diffpanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diffpanel.Name = "diffpanel";
            this.diffpanel.Size = new System.Drawing.Size(293, 133);
            this.diffpanel.TabIndex = 2;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.ForeColor = System.Drawing.Color.DarkCyan;
            this.text.Location = new System.Drawing.Point(155, 113);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(134, 20);
            this.text.TabIndex = 4;
            this.text.Text = "Enter size of board";
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custom.Location = new System.Drawing.Point(155, 76);
            this.custom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(106, 30);
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
            this.hard.Location = new System.Drawing.Point(3, 76);
            this.hard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(82, 30);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.normal.Location = new System.Drawing.Point(155, 12);
            this.normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(106, 30);
            this.normal.TabIndex = 1;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.easy.Location = new System.Drawing.Point(3, 12);
            this.easy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(76, 30);
            this.easy.TabIndex = 0;
            this.easy.TabStop = true;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = true;
            this.difficulty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficulty.Location = new System.Drawing.Point(193, 109);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(86, 22);
            this.difficulty.TabIndex = 1;
            this.difficulty.Text = "Difficulty";
            // 
            // settinglabel
            // 
            this.settinglabel.AutoSize = true;
            this.settinglabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settinglabel.Location = new System.Drawing.Point(377, 41);
            this.settinglabel.Name = "settinglabel";
            this.settinglabel.Size = new System.Drawing.Size(95, 31);
            this.settinglabel.TabIndex = 0;
            this.settinglabel.Text = "Setting";
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(376, 309);
            this.quitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(136, 43);
            this.quitbutton.TabIndex = 4;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // MainMenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.settingpage);
            this.Controls.Add(this.Wellcome);
            this.Controls.Add(this.settingbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.quitbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainMenuPage_Load);
            this.settingpage.ResumeLayout(false);
            this.settingpage.PerformLayout();
            this.ColourBox.ResumeLayout(false);
            this.ColourBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox ColourBox;
        private System.Windows.Forms.CheckBox RedColour;
        private System.Windows.Forms.CheckBox BlueColour;
        private System.Windows.Forms.CheckBox GreenColour;
    }
}