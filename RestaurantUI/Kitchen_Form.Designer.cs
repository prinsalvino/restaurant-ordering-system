namespace Restaurant_UI
{
    partial class Kitchen_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen_Form));
            this.panelBar = new System.Windows.Forms.Panel();
            this.lbl_Datetime = new System.Windows.Forms.Label();
            this.btn_PrepareMany = new System.Windows.Forms.Button();
            this.dgviewOrders = new System.Windows.Forms.DataGridView();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewOrders)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.Controls.Add(this.lbl_Datetime);
            this.panelBar.Controls.Add(this.btn_PrepareMany);
            this.panelBar.Controls.Add(this.dgviewOrders);
            this.panelBar.Location = new System.Drawing.Point(12, 89);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(934, 583);
            this.panelBar.TabIndex = 3;
            // 
            // lbl_Datetime
            // 
            this.lbl_Datetime.AutoSize = true;
            this.lbl_Datetime.ForeColor = System.Drawing.Color.Green;
            this.lbl_Datetime.Location = new System.Drawing.Point(608, 547);
            this.lbl_Datetime.Name = "lbl_Datetime";
            this.lbl_Datetime.Size = new System.Drawing.Size(93, 17);
            this.lbl_Datetime.TabIndex = 3;
            this.lbl_Datetime.Text = "Current Date ";
            // 
            // btn_PrepareMany
            // 
            this.btn_PrepareMany.Location = new System.Drawing.Point(14, 518);
            this.btn_PrepareMany.Name = "btn_PrepareMany";
            this.btn_PrepareMany.Size = new System.Drawing.Size(290, 49);
            this.btn_PrepareMany.TabIndex = 2;
            this.btn_PrepareMany.Text = "Process  the order";
            this.btn_PrepareMany.UseVisualStyleBackColor = true;
            this.btn_PrepareMany.Click += new System.EventHandler(this.btn_PrepareMany_Click);
            // 
            // dgviewOrders
            // 
            this.dgviewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewOrders.Location = new System.Drawing.Point(14, 13);
            this.dgviewOrders.Name = "dgviewOrders";
            this.dgviewOrders.RowHeadersWidth = 51;
            this.dgviewOrders.RowTemplate.Height = 24;
            this.dgviewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewOrders.Size = new System.Drawing.Size(905, 499);
            this.dgviewOrders.TabIndex = 1;
            this.dgviewOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgviewOrders_DataError_1);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.pictureBoxExit);
            this.panelMenu.Location = new System.Drawing.Point(12, 15);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(934, 68);
            this.panelMenu.TabIndex = 8;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(809, 4);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(110, 61);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // Kitchen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 684);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kitchen_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Kitchen_Form_Load);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewOrders)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button btn_PrepareMany;
        public System.Windows.Forms.DataGridView dgviewOrders;
        private System.Windows.Forms.Label lbl_Datetime;
    }
}