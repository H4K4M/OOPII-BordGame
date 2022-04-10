
namespace BoardGame.src.design
{
    partial class UserManagment
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
            this.userlist = new System.Windows.Forms.ListBox();
            this.userlistlabel = new System.Windows.Forms.Label();
            this.updatinfoubut = new System.Windows.Forms.Button();
            this.deletebut = new System.Windows.Forms.Button();
            this.adduserbut = new System.Windows.Forms.Button();
            this.refreshbut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.savebut = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlist
            // 
            this.userlist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userlist.FormattingEnabled = true;
            this.userlist.ItemHeight = 20;
            this.userlist.Location = new System.Drawing.Point(30, 59);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(112, 264);
            this.userlist.TabIndex = 0;
            // 
            // userlistlabel
            // 
            this.userlistlabel.AutoSize = true;
            this.userlistlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userlistlabel.Location = new System.Drawing.Point(30, 18);
            this.userlistlabel.Name = "userlistlabel";
            this.userlistlabel.Size = new System.Drawing.Size(112, 25);
            this.userlistlabel.TabIndex = 1;
            this.userlistlabel.Text = "All User List";
            // 
            // updatinfoubut
            // 
            this.updatinfoubut.Location = new System.Drawing.Point(148, 59);
            this.updatinfoubut.Name = "updatinfoubut";
            this.updatinfoubut.Size = new System.Drawing.Size(116, 23);
            this.updatinfoubut.TabIndex = 2;
            this.updatinfoubut.Text = "Update User Info";
            this.updatinfoubut.UseVisualStyleBackColor = true;
            this.updatinfoubut.Click += new System.EventHandler(this.updatinfoubut_Click);
            // 
            // deletebut
            // 
            this.deletebut.Location = new System.Drawing.Point(148, 89);
            this.deletebut.Name = "deletebut";
            this.deletebut.Size = new System.Drawing.Size(75, 23);
            this.deletebut.TabIndex = 4;
            this.deletebut.Text = "Delete User";
            this.deletebut.UseVisualStyleBackColor = true;
            this.deletebut.Click += new System.EventHandler(this.deletebut_Click);
            // 
            // adduserbut
            // 
            this.adduserbut.Location = new System.Drawing.Point(148, 118);
            this.adduserbut.Name = "adduserbut";
            this.adduserbut.Size = new System.Drawing.Size(96, 23);
            this.adduserbut.TabIndex = 5;
            this.adduserbut.Text = "Add New User";
            this.adduserbut.UseVisualStyleBackColor = true;
            this.adduserbut.Click += new System.EventHandler(this.adduserbut_Click);
            // 
            // refreshbut
            // 
            this.refreshbut.Location = new System.Drawing.Point(46, 329);
            this.refreshbut.Name = "refreshbut";
            this.refreshbut.Size = new System.Drawing.Size(75, 23);
            this.refreshbut.TabIndex = 6;
            this.refreshbut.Text = "Refresh";
            this.refreshbut.UseVisualStyleBackColor = true;
            this.refreshbut.Click += new System.EventHandler(this.refreshbut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.savebut);
            this.panel1.Controls.Add(this.mail);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.country);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.city);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(321, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 293);
            this.panel1.TabIndex = 7;
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(199, 255);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(75, 23);
            this.savebut.TabIndex = 24;
            this.savebut.Text = "Save";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(256, 192);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(41, 15);
            this.mail.TabIndex = 23;
            this.mail.Text = "E-mail";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(20, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(91, 15);
            this.name.TabIndex = 14;
            this.name.Text = "Name-Surname";
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(19, 192);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(50, 15);
            this.country.TabIndex = 22;
            this.country.Text = "Country";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 23);
            this.textBox2.TabIndex = 13;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(256, 105);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(28, 15);
            this.city.TabIndex = 21;
            this.city.Text = "City";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 23);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(256, 26);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(88, 15);
            this.Phone.TabIndex = 15;
            this.Phone.Text = "Phone Number";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(256, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 23);
            this.textBox6.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 123);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 55);
            this.textBox3.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(20, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 23);
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(256, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 23);
            this.textBox4.TabIndex = 17;
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshbut);
            this.Controls.Add(this.adduserbut);
            this.Controls.Add(this.deletebut);
            this.Controls.Add(this.updatinfoubut);
            this.Controls.Add(this.userlistlabel);
            this.Controls.Add(this.userlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagment";
            this.Load += new System.EventHandler(this.UserManagment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userlist;
        private System.Windows.Forms.Label userlistlabel;
        private System.Windows.Forms.Button updatinfoubut;
        private System.Windows.Forms.Button deletebut;
        private System.Windows.Forms.Button adduserbut;
        private System.Windows.Forms.Button refreshbut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}