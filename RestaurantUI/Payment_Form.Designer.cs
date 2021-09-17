namespace Restaurant_UI
{
    partial class Payment_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment_Form));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tax_txt_bx = new System.Windows.Forms.TextBox();
            this.Tiptxt_bx = new System.Windows.Forms.TextBox();
            this.Total_txt_bx = new System.Windows.Forms.TextBox();
            this.OrdersListView = new System.Windows.Forms.ListView();
            this.Desription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashRadiobtn = new System.Windows.Forms.RadioButton();
            this.PinRadiobtn = new System.Windows.Forms.RadioButton();
            this.creditCardRdbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PayOrderbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Table_Numberlbl = new System.Windows.Forms.TextBox();
            this.tbNumberlbl = new System.Windows.Forms.Label();
            this.AddTip_lbl = new System.Windows.Forms.Label();
            this.commentstxt_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(265, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total due";
            // 
            // Tax_txt_bx
            // 
            this.Tax_txt_bx.BackColor = System.Drawing.SystemColors.Control;
            this.Tax_txt_bx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tax_txt_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_txt_bx.Location = new System.Drawing.Point(345, 225);
            this.Tax_txt_bx.Name = "Tax_txt_bx";
            this.Tax_txt_bx.ReadOnly = true;
            this.Tax_txt_bx.Size = new System.Drawing.Size(48, 14);
            this.Tax_txt_bx.TabIndex = 39;
            // 
            // Tiptxt_bx
            // 
            this.Tiptxt_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiptxt_bx.Location = new System.Drawing.Point(345, 408);
            this.Tiptxt_bx.Name = "Tiptxt_bx";
            this.Tiptxt_bx.Size = new System.Drawing.Size(48, 21);
            this.Tiptxt_bx.TabIndex = 38;
            this.Tiptxt_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tiptxt_bx.Visible = false;
            this.Tiptxt_bx.TextChanged += new System.EventHandler(this.Tiptxt_bx_TextChanged);
            // 
            // Total_txt_bx
            // 
            this.Total_txt_bx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_txt_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_txt_bx.Location = new System.Drawing.Point(345, 247);
            this.Total_txt_bx.Name = "Total_txt_bx";
            this.Total_txt_bx.ReadOnly = true;
            this.Total_txt_bx.Size = new System.Drawing.Size(48, 14);
            this.Total_txt_bx.TabIndex = 37;
            // 
            // OrdersListView
            // 
            this.OrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Desription,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.OrdersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersListView.Location = new System.Drawing.Point(11, 33);
            this.OrdersListView.Name = "OrdersListView";
            this.OrdersListView.Size = new System.Drawing.Size(382, 180);
            this.OrdersListView.TabIndex = 36;
            this.OrdersListView.UseCompatibleStateImageBehavior = false;
            this.OrdersListView.View = System.Windows.Forms.View.Details;
            // 
            // Desription
            // 
            this.Desription.Text = "Description";
            this.Desription.Width = 211;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.Width = 35;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cashRadiobtn);
            this.groupBox1.Controls.Add(this.PinRadiobtn);
            this.groupBox1.Controls.Add(this.creditCardRdbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 73);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select payment method ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurant_UI.Properties.Resources.Icons8_Ios7_Finance_Amex_Copyrighted1;
            this.pictureBox2.Location = new System.Drawing.Point(300, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_UI.Properties.Resources.Custom_Icon_Design_Flatastic_3_Payment_creditcard_visa;
            this.pictureBox1.Location = new System.Drawing.Point(334, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(143, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "(Mandatory)";
            // 
            // cashRadiobtn
            // 
            this.cashRadiobtn.AutoSize = true;
            this.cashRadiobtn.Location = new System.Drawing.Point(17, 28);
            this.cashRadiobtn.Name = "cashRadiobtn";
            this.cashRadiobtn.Size = new System.Drawing.Size(53, 19);
            this.cashRadiobtn.TabIndex = 18;
            this.cashRadiobtn.TabStop = true;
            this.cashRadiobtn.Text = "Cash";
            this.cashRadiobtn.UseVisualStyleBackColor = true;
            this.cashRadiobtn.CheckedChanged += new System.EventHandler(this.CashRadiobtn_CheckedChanged);
            // 
            // PinRadiobtn
            // 
            this.PinRadiobtn.AutoSize = true;
            this.PinRadiobtn.Location = new System.Drawing.Point(128, 28);
            this.PinRadiobtn.Name = "PinRadiobtn";
            this.PinRadiobtn.Size = new System.Drawing.Size(43, 19);
            this.PinRadiobtn.TabIndex = 17;
            this.PinRadiobtn.TabStop = true;
            this.PinRadiobtn.Text = "Pin";
            this.PinRadiobtn.UseVisualStyleBackColor = true;
            this.PinRadiobtn.CheckedChanged += new System.EventHandler(this.PinRadiobtn_CheckedChanged);
            // 
            // creditCardRdbtn
            // 
            this.creditCardRdbtn.AutoSize = true;
            this.creditCardRdbtn.Location = new System.Drawing.Point(220, 28);
            this.creditCardRdbtn.Name = "creditCardRdbtn";
            this.creditCardRdbtn.Size = new System.Drawing.Size(83, 19);
            this.creditCardRdbtn.TabIndex = 28;
            this.creditCardRdbtn.TabStop = true;
            this.creditCardRdbtn.Text = "CreditCard";
            this.creditCardRdbtn.UseVisualStyleBackColor = true;
            this.creditCardRdbtn.CheckedChanged += new System.EventHandler(this.CreditCardRdbtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PayOrderbtn);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CancelBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 538);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 104);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process payment ";
            // 
            // PayOrderbtn
            // 
            this.PayOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayOrderbtn.Image = global::Restaurant_UI.Properties.Resources.Tatice_Cristal_Intense_Ok1;
            this.PayOrderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayOrderbtn.Location = new System.Drawing.Point(17, 43);
            this.PayOrderbtn.Name = "PayOrderbtn";
            this.PayOrderbtn.Size = new System.Drawing.Size(131, 40);
            this.PayOrderbtn.TabIndex = 54;
            this.PayOrderbtn.Text = "      Pay Order";
            this.PayOrderbtn.UseVisualStyleBackColor = true;
            this.PayOrderbtn.Click += new System.EventHandler(this.PayOrderbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(109, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "(Mandatory)";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Image = global::Restaurant_UI.Properties.Resources.Gakuseisean_Ivista_Error;
            this.CancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBtn.Location = new System.Drawing.Point(233, 43);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(131, 40);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = " Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Comments";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(83, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "(Optional)";
            // 
            // Table_Numberlbl
            // 
            this.Table_Numberlbl.BackColor = System.Drawing.SystemColors.Menu;
            this.Table_Numberlbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Table_Numberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table_Numberlbl.ForeColor = System.Drawing.Color.Red;
            this.Table_Numberlbl.Location = new System.Drawing.Point(245, 10);
            this.Table_Numberlbl.Name = "Table_Numberlbl";
            this.Table_Numberlbl.Size = new System.Drawing.Size(39, 17);
            this.Table_Numberlbl.TabIndex = 52;
            // 
            // tbNumberlbl
            // 
            this.tbNumberlbl.AutoSize = true;
            this.tbNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberlbl.Location = new System.Drawing.Point(125, 9);
            this.tbNumberlbl.Name = "tbNumberlbl";
            this.tbNumberlbl.Size = new System.Drawing.Size(120, 18);
            this.tbNumberlbl.TabIndex = 51;
            this.tbNumberlbl.Text = "Table number :";
            // 
            // AddTip_lbl
            // 
            this.AddTip_lbl.AutoSize = true;
            this.AddTip_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTip_lbl.ForeColor = System.Drawing.Color.Red;
            this.AddTip_lbl.Location = new System.Drawing.Point(278, 413);
            this.AddTip_lbl.Name = "AddTip_lbl";
            this.AddTip_lbl.Size = new System.Drawing.Size(63, 16);
            this.AddTip_lbl.TabIndex = 53;
            this.AddTip_lbl.Text = "Add Tip";
            // 
            // commentstxt_box
            // 
            this.commentstxt_box.Location = new System.Drawing.Point(11, 447);
            this.commentstxt_box.Multiline = true;
            this.commentstxt_box.Name = "commentstxt_box";
            this.commentstxt_box.Size = new System.Drawing.Size(382, 85);
            this.commentstxt_box.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "21% alcoholic beverages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "6% non-alcoholic beverages and foods";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 65);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tax";
            // 
            // Payment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 654);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.commentstxt_box);
            this.Controls.Add(this.AddTip_lbl);
            this.Controls.Add(this.Table_Numberlbl);
            this.Controls.Add(this.tbNumberlbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tax_txt_bx);
            this.Controls.Add(this.Tiptxt_bx);
            this.Controls.Add(this.Total_txt_bx);
            this.Controls.Add(this.OrdersListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAY ORDER";
            this.Load += new System.EventHandler(this.Payment_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tax_txt_bx;
        private System.Windows.Forms.TextBox Tiptxt_bx;
        private System.Windows.Forms.TextBox Total_txt_bx;
        private System.Windows.Forms.ListView OrdersListView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PinRadiobtn;
        private System.Windows.Forms.RadioButton cashRadiobtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.RadioButton creditCardRdbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Table_Numberlbl;
        private System.Windows.Forms.Label tbNumberlbl;
        private System.Windows.Forms.Label AddTip_lbl;
        private System.Windows.Forms.Button PayOrderbtn;
        private System.Windows.Forms.TextBox commentstxt_box;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader Desription;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}