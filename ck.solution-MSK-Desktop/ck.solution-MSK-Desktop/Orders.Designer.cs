
namespace ck.solution_MSK_Desktop
{
    partial class Orders
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
            this.date_lbl = new System.Windows.Forms.Label();
            this.order_dvg = new System.Windows.Forms.DataGridView();
            this.cart_dvg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items_dvg = new System.Windows.Forms.DataGridView();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.itemname_txt = new System.Windows.Forms.TextBox();
            this.itemqty_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.addtocart_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.euro_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.list_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_dvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date_lbl);
            this.panel1.Controls.Add(this.order_dvg);
            this.panel1.Controls.Add(this.cart_dvg);
            this.panel1.Controls.Add(this.items_dvg);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price_lbl);
            this.panel1.Controls.Add(this.itemname_txt);
            this.panel1.Controls.Add(this.itemqty_txt);
            this.panel1.Controls.Add(this.price_txt);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.addtocart_btn);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.euro_lbl);
            this.panel1.Controls.Add(this.total_lbl);
            this.panel1.Controls.Add(this.list_lbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 464);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(49, 34);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(30, 13);
            this.date_lbl.TabIndex = 12;
            this.date_lbl.Text = "Date";
            // 
            // order_dvg
            // 
            this.order_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_dvg.Location = new System.Drawing.Point(335, 231);
            this.order_dvg.Name = "order_dvg";
            this.order_dvg.Size = new System.Drawing.Size(472, 150);
            this.order_dvg.TabIndex = 11;
            // 
            // cart_dvg
            // 
            this.cart_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart_dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.cart_dvg.Location = new System.Drawing.Point(265, 34);
            this.cart_dvg.Name = "cart_dvg";
            this.cart_dvg.Size = new System.Drawing.Size(552, 150);
            this.cart_dvg.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // items_dvg
            // 
            this.items_dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.items_dvg.Location = new System.Drawing.Point(36, 231);
            this.items_dvg.Name = "items_dvg";
            this.items_dvg.Size = new System.Drawing.Size(258, 150);
            this.items_dvg.TabIndex = 11;
            this.items_dvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.items_dvg_CellContentClick);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(44, 107);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 6;
            this.name_lbl.Text = "Name";
            this.name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(48, 164);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(31, 13);
            this.price_lbl.TabIndex = 8;
            this.price_lbl.Text = "Price";
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemname_txt
            // 
            this.itemname_txt.Location = new System.Drawing.Point(98, 103);
            this.itemname_txt.Name = "itemname_txt";
            this.itemname_txt.Size = new System.Drawing.Size(161, 20);
            this.itemname_txt.TabIndex = 5;
            // 
            // itemqty_txt
            // 
            this.itemqty_txt.Location = new System.Drawing.Point(98, 161);
            this.itemqty_txt.Name = "itemqty_txt";
            this.itemqty_txt.Size = new System.Drawing.Size(161, 20);
            this.itemqty_txt.TabIndex = 10;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(98, 132);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(161, 20);
            this.price_txt.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(509, 405);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // addtocart_btn
            // 
            this.addtocart_btn.Location = new System.Drawing.Point(131, 187);
            this.addtocart_btn.Name = "addtocart_btn";
            this.addtocart_btn.Size = new System.Drawing.Size(75, 23);
            this.addtocart_btn.TabIndex = 1;
            this.addtocart_btn.Text = "Add to Cart";
            this.addtocart_btn.UseVisualStyleBackColor = true;
            this.addtocart_btn.Click += new System.EventHandler(this.addtocart_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(15, 427);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // euro_lbl
            // 
            this.euro_lbl.AutoSize = true;
            this.euro_lbl.Location = new System.Drawing.Point(560, 202);
            this.euro_lbl.Name = "euro_lbl";
            this.euro_lbl.Size = new System.Drawing.Size(13, 13);
            this.euro_lbl.TabIndex = 0;
            this.euro_lbl.Text = "€";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(523, 202);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(31, 13);
            this.total_lbl.TabIndex = 0;
            this.total_lbl.Text = "Total";
            // 
            // list_lbl
            // 
            this.list_lbl.AutoSize = true;
            this.list_lbl.Location = new System.Drawing.Point(33, 215);
            this.list_lbl.Name = "list_lbl";
            this.list_lbl.Size = new System.Drawing.Size(51, 13);
            this.list_lbl.TabIndex = 0;
            this.list_lbl.Text = "Items List";
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
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dieses Projekt wurde von Mhd Said Kassab für CK.Solution entworfen";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cart_dvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items_dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_btn;
        public System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Button addtocart_btn;
        private System.Windows.Forms.Label list_lbl;
        private System.Windows.Forms.DataGridView cart_dvg;
        private System.Windows.Forms.DataGridView items_dvg;
        public System.Windows.Forms.Label name_lbl;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox itemname_txt;
        public System.Windows.Forms.TextBox itemqty_txt;
        public System.Windows.Forms.Label price_lbl;
        public System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label euro_lbl;
        private System.Windows.Forms.DataGridView order_dvg;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}