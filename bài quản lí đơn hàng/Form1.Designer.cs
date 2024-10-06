

namespace bài_quản_lí_đơn_hàng
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lableLog = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelpassWord = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.toaNutTron3 = new bài_quản_lí_đơn_hàng.toaNutTron();
            this.toaNutTron1 = new bài_quản_lí_đơn_hàng.toaNutTron();
            this.roundedButton1 = new bonutgoc.RoundedButton();
            this.userControl12 = new bài_quản_lí_đơn_hàng.UserControl1();
            this.userControl11 = new bài_quản_lí_đơn_hàng.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lableLog
            // 
            this.lableLog.AutoSize = true;
            this.lableLog.BackColor = System.Drawing.Color.Transparent;
            this.lableLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lableLog.Location = new System.Drawing.Point(154, 53);
            this.lableLog.Name = "lableLog";
            this.lableLog.Size = new System.Drawing.Size(357, 135);
            this.lableLog.TabIndex = 0;
            this.lableLog.Text = "Login";
            this.lableLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lableLog.Click += new System.EventHandler(this.label1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(132, 262);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(116, 25);
            this.Username.TabIndex = 1;
            this.Username.Text = "User name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelpassWord
            // 
            this.labelpassWord.AutoSize = true;
            this.labelpassWord.BackColor = System.Drawing.Color.Transparent;
            this.labelpassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassWord.Location = new System.Drawing.Point(132, 405);
            this.labelpassWord.Name = "labelpassWord";
            this.labelpassWord.Size = new System.Drawing.Size(106, 25);
            this.labelpassWord.TabIndex = 4;
            this.labelpassWord.Text = "Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(78, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(342, 525);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 29);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 782);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Don’t have an account?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(368, 782);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(126, 21);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign up here";
            // 
            // toaNutTron3
            // 
            this.toaNutTron3.Image = ((System.Drawing.Image)(resources.GetObject("toaNutTron3.Image")));
            this.toaNutTron3.Location = new System.Drawing.Point(384, 672);
            this.toaNutTron3.Name = "toaNutTron3";
            this.toaNutTron3.Size = new System.Drawing.Size(64, 64);
            this.toaNutTron3.TabIndex = 11;
            this.toaNutTron3.UseVisualStyleBackColor = true;
            // 
            // toaNutTron1
            // 
            this.toaNutTron1.Image = ((System.Drawing.Image)(resources.GetObject("toaNutTron1.Image")));
            this.toaNutTron1.Location = new System.Drawing.Point(220, 672);
            this.toaNutTron1.Name = "toaNutTron1";
            this.toaNutTron1.Size = new System.Drawing.Size(64, 64);
            this.toaNutTron1.TabIndex = 9;
            this.toaNutTron1.UseVisualStyleBackColor = true;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(126, 581);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(425, 60);
            this.roundedButton1.TabIndex = 8;
            this.roundedButton1.Text = "Log In";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.Window;
            this.userControl12.BorderColor = System.Drawing.Color.Black;
            this.userControl12.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl12.BorderRadius = 8;
            this.userControl12.BorderSize = 2;
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl12.Location = new System.Drawing.Point(126, 445);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4);
            this.userControl12.Multiline = false;
            this.userControl12.Name = "userControl12";
            this.userControl12.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl12.PasswordChar = false;
            this.userControl12.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userControl12.PlaceholderText = "";
            this.userControl12.Size = new System.Drawing.Size(425, 44);
            this.userControl12.TabIndex = 5;
            this.userControl12.Texts = "";
            this.userControl12.UnderlinedStyle = false;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.Window;
            this.userControl11.BorderColor = System.Drawing.Color.Black;
            this.userControl11.BorderFocusColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl11.BorderRadius = 8;
            this.userControl11.BorderSize = 2;
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userControl11.Location = new System.Drawing.Point(126, 312);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4);
            this.userControl11.Multiline = false;
            this.userControl11.Name = "userControl11";
            this.userControl11.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userControl11.PasswordChar = false;
            this.userControl11.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userControl11.PlaceholderText = "";
            this.userControl11.Size = new System.Drawing.Size(425, 44);
            this.userControl11.TabIndex = 2;
            this.userControl11.Texts = "";
            this.userControl11.UnderlinedStyle = false;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 853);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toaNutTron3);
            this.Controls.Add(this.toaNutTron1);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.labelpassWord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.lableLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(694, 900);
            this.MinimumSize = new System.Drawing.Size(694, 900);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableLog;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBox1;
        private UserControl1 userControl11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelpassWord;
        private UserControl1 userControl12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private bonutgoc.RoundedButton roundedButton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private toaNutTron toaNutTron1;
        private toaNutTron toaNutTron3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

