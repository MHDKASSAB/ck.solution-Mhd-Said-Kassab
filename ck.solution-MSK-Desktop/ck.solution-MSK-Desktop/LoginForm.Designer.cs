
namespace ck.solution_MSK_Desktop
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Label();
            this.showpassword_checkBox = new System.Windows.Forms.CheckBox();
            this.reg_btn = new System.Windows.Forms.LinkLabel();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close_btn);
            this.panel1.Controls.Add(this.showpassword_checkBox);
            this.panel1.Controls.Add(this.reg_btn);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.password_txt);
            this.panel1.Controls.Add(this.username_txt);
            this.panel1.Controls.Add(this.password_lbl);
            this.panel1.Controls.Add(this.username_lbl);
            this.panel1.Controls.Add(this.login_lbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 247);
            this.panel1.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.close_btn.Location = new System.Drawing.Point(0, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(14, 13);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "X";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // showpassword_checkBox
            // 
            this.showpassword_checkBox.Location = new System.Drawing.Point(0, 0);
            this.showpassword_checkBox.Name = "showpassword_checkBox";
            this.showpassword_checkBox.Size = new System.Drawing.Size(104, 24);
            this.showpassword_checkBox.TabIndex = 6;
            // 
            // reg_btn
            // 
            this.reg_btn.AutoSize = true;
            this.reg_btn.Location = new System.Drawing.Point(217, 177);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(72, 13);
            this.reg_btn.TabIndex = 3;
            this.reg_btn.TabStop = true;
            this.reg_btn.Text = "Register Here";
            this.reg_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reg_btn_LinkClicked);
            // 
            // login_btn
            // 
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Bw Modelica Hairline", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.login_btn.Location = new System.Drawing.Point(96, 165);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(105, 34);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Log In";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(96, 118);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(139, 20);
            this.password_txt.TabIndex = 1;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(96, 73);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(139, 20);
            this.username_txt.TabIndex = 0;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.password_lbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.password_lbl.Location = new System.Drawing.Point(21, 119);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(74, 17);
            this.password_lbl.TabIndex = 0;
            this.password_lbl.Text = "Password";
            this.password_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_lbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.username_lbl.Location = new System.Drawing.Point(13, 77);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(82, 17);
            this.username_lbl.TabIndex = 0;
            this.username_lbl.Text = "User Name";
            this.username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.login_lbl.Location = new System.Drawing.Point(114, 17);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(56, 25);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "LogIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dieses Projekt wurde von Mhd Said Kassab für CK.Solution entworfen";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.LinkLabel reg_btn;
        public System.Windows.Forms.Button login_btn;
        public System.Windows.Forms.TextBox password_txt;
        public System.Windows.Forms.TextBox username_txt;
        public System.Windows.Forms.Label password_lbl;
        public System.Windows.Forms.Label username_lbl;
        public System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.CheckBox showpassword_checkBox;
        public System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Label label2;
    }
}

