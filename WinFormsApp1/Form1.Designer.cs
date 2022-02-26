
namespace WinFormsApp1
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.loadChatBt = new System.Windows.Forms.Button();
            this.sendMessageBt = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.Location = new System.Drawing.Point(123, 102);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(338, 180);
            this.chatBox.TabIndex = 1;
            this.chatBox.Text = "";
            // 
            // loadChatBt
            // 
            this.loadChatBt.Location = new System.Drawing.Point(319, 55);
            this.loadChatBt.Name = "loadChatBt";
            this.loadChatBt.Size = new System.Drawing.Size(75, 23);
            this.loadChatBt.TabIndex = 2;
            this.loadChatBt.Text = "button1";
            this.loadChatBt.UseVisualStyleBackColor = true;
            this.loadChatBt.Click += new System.EventHandler(this.LoadChatBt_Click);
            // 
            // sendMessageBt
            // 
            this.sendMessageBt.Location = new System.Drawing.Point(254, 341);
            this.sendMessageBt.Name = "sendMessageBt";
            this.sendMessageBt.Size = new System.Drawing.Size(75, 23);
            this.sendMessageBt.TabIndex = 3;
            this.sendMessageBt.Text = "button2";
            this.sendMessageBt.UseVisualStyleBackColor = true;
            this.sendMessageBt.Visible = false;
            this.sendMessageBt.Click += new System.EventHandler(this.SendMessageBt_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(123, 278);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(338, 57);
            this.messageBox.TabIndex = 4;
            this.messageBox.Text = "Enter your message";
            this.messageBox.Visible = false;
            this.messageBox.Enter += new System.EventHandler(this.MessageBox_Enter);
            this.messageBox.Leave += new System.EventHandler(this.messageBox_Leave);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(486, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(59, 15);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // logoutBt
            // 
            this.logoutBt.Location = new System.Drawing.Point(551, 9);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(21, 15);
            this.logoutBt.TabIndex = 6;
            this.logoutBt.Text = "logoutBt";
            this.logoutBt.UseVisualStyleBackColor = true;
            this.logoutBt.Visible = false;
            this.logoutBt.Click += new System.EventHandler(this.LogoutBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.logoutBt);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendMessageBt);
            this.Controls.Add(this.loadChatBt);
            this.Controls.Add(this.chatBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox chatBox;
        public System.Windows.Forms.Label usernameLabel;
        public System.Windows.Forms.Button logoutBt;
        public System.Windows.Forms.Button loadChatBt;
        public System.Windows.Forms.RichTextBox messageBox;
        public System.Windows.Forms.Button sendMessageBt;
    }
}

