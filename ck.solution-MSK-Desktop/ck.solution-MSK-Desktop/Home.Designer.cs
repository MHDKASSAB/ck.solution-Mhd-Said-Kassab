
namespace ck.solution_MSK_Desktop
{
    partial class Home
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
            this.users_btn = new System.Windows.Forms.Button();
            this.items_btn = new System.Windows.Forms.Button();
            this.orders_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // users_btn
            // 
            this.users_btn.Location = new System.Drawing.Point(33, 86);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(75, 23);
            this.users_btn.TabIndex = 0;
            this.users_btn.Text = "Users";
            this.users_btn.UseVisualStyleBackColor = true;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // items_btn
            // 
            this.items_btn.Location = new System.Drawing.Point(114, 86);
            this.items_btn.Name = "items_btn";
            this.items_btn.Size = new System.Drawing.Size(75, 23);
            this.items_btn.TabIndex = 1;
            this.items_btn.Text = "Items";
            this.items_btn.UseVisualStyleBackColor = true;
            this.items_btn.Click += new System.EventHandler(this.items_btn_Click);
            // 
            // orders_btn
            // 
            this.orders_btn.Location = new System.Drawing.Point(195, 86);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(75, 23);
            this.orders_btn.TabIndex = 2;
            this.orders_btn.Text = "Orders";
            this.orders_btn.UseVisualStyleBackColor = true;
            this.orders_btn.Click += new System.EventHandler(this.orders_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(247, 236);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "LogOut";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
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
            this.close_btn.TabIndex = 17;
            this.close_btn.Text = "X";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dieses Projekt wurde von Mhd Said Kassab für CK.Solution entworfen";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.orders_btn);
            this.Controls.Add(this.items_btn);
            this.Controls.Add(this.users_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button items_btn;
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Button logout_btn;
        public System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Label label2;
    }
}