namespace Restaurant_UI
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.lblusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbllogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(139, 169);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(93, 17);
            this.lblusername.TabIndex = 20;
            this.lblusername.Text = "USERNAME";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(245, 165);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(212, 22);
            this.txtusername.TabIndex = 21;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(136, 223);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(96, 17);
            this.lblpassword.TabIndex = 22;
            this.lblpassword.Text = "PASSWORD";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(245, 219);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '•';
            this.txtpassword.Size = new System.Drawing.Size(212, 22);
            this.txtpassword.TabIndex = 23;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(245, 274);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(213, 59);
            this.btnlogin.TabIndex = 24;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_UI.Properties.Resources.image_6_;
            this.pictureBox1.Location = new System.Drawing.Point(505, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.Location = new System.Drawing.Point(295, 114);
            this.lbllogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(86, 33);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "Login";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbllogin;
    }
}

