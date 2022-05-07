
namespace BoardGame
{
    partial class SettingPage
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
            this.ColourBox = new System.Windows.Forms.GroupBox();
            this.BlueColour = new System.Windows.Forms.CheckBox();
            this.GreenColour = new System.Windows.Forms.CheckBox();
            this.RedColour = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
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
            this.ShapeBox = new System.Windows.Forms.GroupBox();
            this.SettingsWarning = new System.Windows.Forms.Label();
            this.ColourBox.SuspendLayout();
            this.diffpanel.SuspendLayout();
            this.ShapeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColourBox
            // 
            this.ColourBox.Controls.Add(this.BlueColour);
            this.ColourBox.Controls.Add(this.GreenColour);
            this.ColourBox.Controls.Add(this.RedColour);
            this.ColourBox.Location = new System.Drawing.Point(145, 300);
            this.ColourBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColourBox.Name = "ColourBox";
            this.ColourBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColourBox.Size = new System.Drawing.Size(511, 55);
            this.ColourBox.TabIndex = 26;
            this.ColourBox.TabStop = false;
            this.ColourBox.Text = "Colour";
            // 
            // BlueColour
            // 
            this.BlueColour.AutoSize = true;
            this.BlueColour.Location = new System.Drawing.Point(215, 27);
            this.BlueColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BlueColour.Name = "BlueColour";
            this.BlueColour.Size = new System.Drawing.Size(49, 19);
            this.BlueColour.TabIndex = 2;
            this.BlueColour.Text = "Blue";
            this.BlueColour.UseVisualStyleBackColor = true;
            // 
            // GreenColour
            // 
            this.GreenColour.AutoSize = true;
            this.GreenColour.Location = new System.Drawing.Point(122, 27);
            this.GreenColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GreenColour.Name = "GreenColour";
            this.GreenColour.Size = new System.Drawing.Size(57, 19);
            this.GreenColour.TabIndex = 1;
            this.GreenColour.Text = "Green";
            this.GreenColour.UseVisualStyleBackColor = true;
            // 
            // RedColour
            // 
            this.RedColour.AutoSize = true;
            this.RedColour.Location = new System.Drawing.Point(28, 27);
            this.RedColour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RedColour.Name = "RedColour";
            this.RedColour.Size = new System.Drawing.Size(46, 19);
            this.RedColour.TabIndex = 0;
            this.RedColour.Text = "Red";
            this.RedColour.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(194, 22);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 19);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.Text = "Round";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(105, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 19);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Triangle";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 19);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Square";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(469, 369);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 22;
            this.cancelbutton.Text = "CANCEL";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(288, 369);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 21;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(462, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "X";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(487, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 23);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 23);
            this.textBox1.TabIndex = 17;
            // 
            // diffpanel
            // 
            this.diffpanel.Controls.Add(this.text);
            this.diffpanel.Controls.Add(this.custom);
            this.diffpanel.Controls.Add(this.hard);
            this.diffpanel.Controls.Add(this.normal);
            this.diffpanel.Controls.Add(this.easy);
            this.diffpanel.Location = new System.Drawing.Point(288, 113);
            this.diffpanel.Name = "diffpanel";
            this.diffpanel.Size = new System.Drawing.Size(256, 100);
            this.diffpanel.TabIndex = 16;
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
            this.difficulty.Location = new System.Drawing.Point(201, 110);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(62, 19);
            this.difficulty.TabIndex = 15;
            this.difficulty.Text = "Difficulty";
            // 
            // settinglabel
            // 
            this.settinglabel.AutoSize = true;
            this.settinglabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settinglabel.Location = new System.Drawing.Point(362, 59);
            this.settinglabel.Name = "settinglabel";
            this.settinglabel.Size = new System.Drawing.Size(73, 24);
            this.settinglabel.TabIndex = 14;
            this.settinglabel.Text = "Setting";
            // 
            // ShapeBox
            // 
            this.ShapeBox.Controls.Add(this.checkBox3);
            this.ShapeBox.Controls.Add(this.checkBox1);
            this.ShapeBox.Controls.Add(this.checkBox2);
            this.ShapeBox.Location = new System.Drawing.Point(145, 245);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(482, 50);
            this.ShapeBox.TabIndex = 27;
            this.ShapeBox.TabStop = false;
            this.ShapeBox.Text = "Shape";
            // 
            // SettingsWarning
            // 
            this.SettingsWarning.AutoSize = true;
            this.SettingsWarning.ForeColor = System.Drawing.Color.Red;
            this.SettingsWarning.Location = new System.Drawing.Point(145, 406);
            this.SettingsWarning.Name = "SettingsWarning";
            this.SettingsWarning.Size = new System.Drawing.Size(52, 15);
            this.SettingsWarning.TabIndex = 28;
            this.SettingsWarning.Text = "Warning";
            this.SettingsWarning.Visible = false;
            // 
            // SettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsWarning);
            this.Controls.Add(this.ShapeBox);
            this.Controls.Add(this.ColourBox);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.diffpanel);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.settinglabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingPage_Load);
            this.ColourBox.ResumeLayout(false);
            this.ColourBox.PerformLayout();
            this.diffpanel.ResumeLayout(false);
            this.diffpanel.PerformLayout();
            this.ShapeBox.ResumeLayout(false);
            this.ShapeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ColourBox;
        private System.Windows.Forms.CheckBox BlueColour;
        private System.Windows.Forms.CheckBox GreenColour;
        private System.Windows.Forms.CheckBox RedColour;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel diffpanel;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.RadioButton custom;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.Label difficulty;
        private System.Windows.Forms.Label settinglabel;
        private System.Windows.Forms.GroupBox ShapeBox;
        private System.Windows.Forms.Label SettingsWarning;
    }
}