
namespace ck.solution_MSK_Desktop
{
    partial class ManageUsers
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
            this.close_btn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.users_dvg = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.mobile_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.mobile_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dvg)).BeginInit();
            this.SuspendLayout();
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
            this.close_btn.TabIndex = 16;
            this.close_btn.Text = "X";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.users_dvg);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.mobile_lbl);
            this.panel1.Controls.Add(this.password_lbl);
            this.panel1.Controls.Add(this.username_lbl);
            this.panel1.Controls.Add(this.mobile_txt);
            this.panel1.Controls.Add(this.password_txt);
            this.panel1.Controls.Add(this.username_txt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 464);
            this.panel1.TabIndex = 17;
            // 
            // users_dvg
            // 
            this.users_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dvg.Location = new System.Drawing.Point(296, 15);
            this.users_dvg.Name = "users_dvg";
            this.users_dvg.Size = new System.Drawing.Size(521, 419);
            this.users_dvg.TabIndex = 3;
            this.users_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.users_dvg_CellContentClick);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(15, 427);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(177, 196);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 5;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(96, 196);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 196);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // mobile_lbl
            // 
            this.mobile_lbl.AutoSize = true;
            this.mobile_lbl.Location = new System.Drawing.Point(52, 148);
            this.mobile_lbl.Name = "mobile_lbl";
            this.mobile_lbl.Size = new System.Drawing.Size(38, 13);
            this.mobile_lbl.TabIndex = 1;
            this.mobile_lbl.Text = "Mobile";
            this.mobile_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(37, 115);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Password";
            this.password_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Location = new System.Drawing.Point(35, 75);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(55, 13);
            this.username_lbl.TabIndex = 1;
            this.username_lbl.Text = "Username";
            this.username_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobile_txt
            // 
            this.mobile_txt.Location = new System.Drawing.Point(114, 145);
            this.mobile_txt.Name = "mobile_txt";
            this.mobile_txt.Size = new System.Drawing.Size(161, 20);
            this.mobile_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(114, 112);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(161, 20);
            this.password_txt.TabIndex = 1;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(114, 72);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(161, 20);
            this.username_txt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dieses Projekt wurde von Mhd Said Kassab für CK.Solution entworfen";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView users_dvg;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        public System.Windows.Forms.Label mobile_lbl;
        public System.Windows.Forms.Label password_lbl;
        public System.Windows.Forms.Label username_lbl;
        public System.Windows.Forms.TextBox mobile_txt;
        public System.Windows.Forms.TextBox password_txt;
        public System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label2;
    }
}