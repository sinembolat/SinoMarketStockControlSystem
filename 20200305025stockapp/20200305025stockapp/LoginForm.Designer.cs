namespace _20200305025stockapp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            label1 = new Label();
            textBox_Username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox_Password = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RosyBrown;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(124, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 36);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(65, 128);
            label1.Name = "label1";
            label1.Size = new Size(225, 29);
            label1.TabIndex = 1;
            label1.Text = "LOGIN TO SYSTEM";
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(168, 201);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(140, 23);
            textBox_Username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 206);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 3;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 260);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 4;
            label3.Text = "PASSWORD";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(168, 255);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(140, 23);
            textBox_Password.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 417);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Cooper Black", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(25, 18);
            label4.Name = "label4";
            label4.Size = new Size(326, 42);
            label4.TabIndex = 7;
            label4.Text = "WELCOME TO THE SINO MARKET\r\n STOCK CONTROL SYSTEM!";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(153, 417);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(315, 419);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(376, 468);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_Password);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_Username);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private TextBox textBox_Username;
        private Label label2;
        private Label label3;
        private TextBox textBox_Password;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MouseEventHandler btnLogin_MouseClick;
    }
}
