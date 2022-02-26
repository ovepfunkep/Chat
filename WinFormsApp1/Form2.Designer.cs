
namespace WinFormsApp1
{
    partial class Form2
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.enterLoginBox = new System.Windows.Forms.TextBox();
            this.enterPasswordBox = new System.Windows.Forms.TextBox();
            this.enterBt = new System.Windows.Forms.Button();
            this.regBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(207, 44);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(57, 15);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // enterLoginBox
            // 
            this.enterLoginBox.Location = new System.Drawing.Point(143, 80);
            this.enterLoginBox.Name = "enterLoginBox";
            this.enterLoginBox.Size = new System.Drawing.Size(204, 23);
            this.enterLoginBox.TabIndex = 1;
            this.enterLoginBox.Text = "Enter login";
            this.enterLoginBox.Enter += new System.EventHandler(this.EnterLoginBox_Enter);
            this.enterLoginBox.Leave += new System.EventHandler(this.EnterLoginBox_Leave);
            // 
            // enterPasswordBox
            // 
            this.enterPasswordBox.Location = new System.Drawing.Point(143, 118);
            this.enterPasswordBox.Name = "enterPasswordBox";
            this.enterPasswordBox.PasswordChar = '*';
            this.enterPasswordBox.Size = new System.Drawing.Size(204, 23);
            this.enterPasswordBox.TabIndex = 2;
            this.enterPasswordBox.Text = "Enter password";
            this.enterPasswordBox.Enter += new System.EventHandler(this.EnterPasswordBox_Enter);
            this.enterPasswordBox.Leave += new System.EventHandler(this.EnterPasswordBox_Leave);
            // 
            // enterBt
            // 
            this.enterBt.Location = new System.Drawing.Point(143, 162);
            this.enterBt.Name = "enterBt";
            this.enterBt.Size = new System.Drawing.Size(75, 23);
            this.enterBt.TabIndex = 3;
            this.enterBt.Text = "Enter";
            this.enterBt.UseVisualStyleBackColor = true;
            this.enterBt.Click += new System.EventHandler(this.EnterBt_Click);
            // 
            // regBt
            // 
            this.regBt.Location = new System.Drawing.Point(272, 162);
            this.regBt.Name = "regBt";
            this.regBt.Size = new System.Drawing.Size(75, 23);
            this.regBt.TabIndex = 4;
            this.regBt.Text = "Register";
            this.regBt.UseVisualStyleBackColor = true;
            this.regBt.Click += new System.EventHandler(this.RegBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regBt);
            this.Controls.Add(this.enterBt);
            this.Controls.Add(this.enterPasswordBox);
            this.Controls.Add(this.enterLoginBox);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox enterLoginBox;
        private System.Windows.Forms.TextBox enterPasswordBox;
        private System.Windows.Forms.Button enterBt;
        private System.Windows.Forms.Button regBt;
        private System.Windows.Forms.Label label2;
    }
}