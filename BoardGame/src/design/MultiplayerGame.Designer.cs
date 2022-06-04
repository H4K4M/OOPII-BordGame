
namespace BoardGame.src.design
{
    partial class MultiplayerGame
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
            this.Turn = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Turn
            // 
            this.Turn.AutoSize = true;
            this.Turn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Turn.Location = new System.Drawing.Point(329, 135);
            this.Turn.Name = "Turn";
            this.Turn.Size = new System.Drawing.Size(83, 32);
            this.Turn.TabIndex = 0;
            this.Turn.Text = "label1";
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Player.Location = new System.Drawing.Point(552, 9);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(41, 17);
            this.Player.TabIndex = 1;
            this.Player.Text = "label1";
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Location = new System.Drawing.Point(467, 43);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(94, 15);
            this.Player1Label.TabIndex = 2;
            this.Player1Label.Text = "Player 1\'s Score :";
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Location = new System.Drawing.Point(467, 80);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(94, 15);
            this.Player2Label.TabIndex = 3;
            this.Player2Label.Text = "Player 2\'s Score :";
            // 
            // MultiplayerGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 339);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Turn);
            this.Name = "MultiplayerGame";
            this.Text = "MultiplayerGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Turn;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
    }
}