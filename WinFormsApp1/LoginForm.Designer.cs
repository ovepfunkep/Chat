
namespace WinFormsApp1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.enterLoginBox = new System.Windows.Forms.TextBox();
            this.enterPasswordBox = new System.Windows.Forms.TextBox();
            this.enterBt = new System.Windows.Forms.Button();
            this.regBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLoginBox
            // 
            this.enterLoginBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterLoginBox.Location = new System.Drawing.Point(209, 164);
            this.enterLoginBox.MaxLength = 15;
            this.enterLoginBox.Name = "enterLoginBox";
            this.enterLoginBox.Size = new System.Drawing.Size(219, 32);
            this.enterLoginBox.TabIndex = 1;
            this.enterLoginBox.Text = "Enter login";
            this.enterLoginBox.Enter += new System.EventHandler(this.EnterLoginBox_Enter);
            this.enterLoginBox.Leave += new System.EventHandler(this.EnterLoginBox_Leave);
            // 
            // enterPasswordBox
            // 
            this.enterPasswordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enterPasswordBox.Location = new System.Drawing.Point(210, 206);
            this.enterPasswordBox.MaxLength = 15;
            this.enterPasswordBox.Name = "enterPasswordBox";
            this.enterPasswordBox.PasswordChar = '*';
            this.enterPasswordBox.Size = new System.Drawing.Size(218, 32);
            this.enterPasswordBox.TabIndex = 2;
            this.enterPasswordBox.Text = "Enter password";
            this.enterPasswordBox.Enter += new System.EventHandler(this.EnterPasswordBox_Enter);
            this.enterPasswordBox.Leave += new System.EventHandler(this.EnterPasswordBox_Leave);
            // 
            // enterBt
            // 
            this.enterBt.BackColor = System.Drawing.SystemColors.Control;
            this.enterBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterBt.BackgroundImage")));
            this.enterBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enterBt.FlatAppearance.BorderSize = 0;
            this.enterBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBt.Location = new System.Drawing.Point(159, 278);
            this.enterBt.Name = "enterBt";
            this.enterBt.Size = new System.Drawing.Size(151, 30);
            this.enterBt.TabIndex = 3;
            this.enterBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.enterBt.UseVisualStyleBackColor = false;
            this.enterBt.Click += new System.EventHandler(this.EnterBt_Click);
            // 
            // regBt
            // 
            this.regBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regBt.BackgroundImage")));
            this.regBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.regBt.FlatAppearance.BorderSize = 0;
            this.regBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBt.Location = new System.Drawing.Point(336, 278);
            this.regBt.Name = "regBt";
            this.regBt.Size = new System.Drawing.Size(150, 30);
            this.regBt.TabIndex = 4;
            this.regBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.regBt.UseVisualStyleBackColor = true;
            this.regBt.Click += new System.EventHandler(this.RegBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(296, 311);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(55, 15);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 405);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regBt);
            this.Controls.Add(this.enterBt);
            this.Controls.Add(this.enterPasswordBox);
            this.Controls.Add(this.enterLoginBox);
            this.Name = "LoginForm";
            this.Text = "MyChat login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox enterLoginBox;
        private System.Windows.Forms.TextBox enterPasswordBox;
        private System.Windows.Forms.Button enterBt;
        private System.Windows.Forms.Button regBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}