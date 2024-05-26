namespace _20200305025stockapp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            btnInformation = new Button();
            btnTransactions = new Button();
            SuspendLayout();
            // 
            // btnInformation
            // 
            btnInformation.BackColor = SystemColors.ActiveCaption;
            btnInformation.Font = new Font("Goudy Stout", 9F);
            btnInformation.Location = new Point(94, 290);
            btnInformation.Name = "btnInformation";
            btnInformation.Size = new Size(217, 61);
            btnInformation.TabIndex = 0;
            btnInformation.Text = "INFORMATION ABOUT \r\nSTOCKS";
            btnInformation.TextAlign = ContentAlignment.BottomCenter;
            btnInformation.UseVisualStyleBackColor = false;
            btnInformation.Click += btnInformation_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = SystemColors.ActiveCaption;
            btnTransactions.Font = new Font("Goudy Stout", 10F);
            btnTransactions.ImageAlign = ContentAlignment.BottomCenter;
            btnTransactions.Location = new Point(602, 290);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(217, 61);
            btnTransactions.TabIndex = 1;
            btnTransactions.Text = "ALL TRANSACTIONS";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(863, 589);
            Controls.Add(btnTransactions);
            Controls.Add(btnInformation);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU FORM";
            ResumeLayout(false);
        }

        #endregion

        private Button btnInformation;
        private Button btnTransactions;
    }
}