
namespace ck.solution_MSK_Desktop
{
    partial class Items
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
            this.items_dvg = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.items_dvg);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.del_btn);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.desc_lbl);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price_lbl);
            this.panel1.Controls.Add(this.desc_txt);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.qty_txt);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 464);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // items_dvg
            // 
            this.items_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_dvg.Location = new System.Drawing.Point(296, 15);
            this.items_dvg.Name = "items_dvg";
            this.items_dvg.Size = new System.Drawing.Size(521, 414);
            this.items_dvg.TabIndex = 8;
            this.items_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.items_dvg_CellContentClick);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(15, 427);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(177, 263);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 6;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(96, 263);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 263);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Location = new System.Drawing.Point(35, 160);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(60, 13);
            this.desc_lbl.TabIndex = 1;
            this.desc_lbl.Text = "Description";
            this.desc_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(60, 47);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Name";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(64, 76);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(31, 13);
            this.price_lbl.TabIndex = 1;
            this.price_lbl.Text = "Price";
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(114, 127);
            this.desc_txt.Multiline = true;
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(161, 78);
            this.desc_txt.TabIndex = 3;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(114, 43);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(161, 20);
            this.name_txt.TabIndex = 0;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(114, 101);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(161, 20);
            this.qty_txt.TabIndex = 2;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(114, 72);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(161, 20);
            this.price_txt.TabIndex = 1;
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
            this.close_btn.TabIndex = 18;
            this.close_btn.Text = "X";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dieses Projekt wurde von Mhd Said Kassab für CK.Solution entworfen";
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.items_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView items_dvg;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        public System.Windows.Forms.Label desc_lbl;
        public System.Windows.Forms.Label price_lbl;
        public System.Windows.Forms.TextBox desc_txt;
        public System.Windows.Forms.TextBox price_txt;
        public System.Windows.Forms.Label close_btn;
        public System.Windows.Forms.Label name_lbl;
        public System.Windows.Forms.TextBox name_txt;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Label label2;
    }
}