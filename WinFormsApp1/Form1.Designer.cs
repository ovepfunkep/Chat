
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.loadChatBt = new System.Windows.Forms.Button();
            this.sendMessageBt = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            this.messageBox.Multiline = false;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(338, 57);
            this.messageBox.TabIndex = 4;
            this.messageBox.Text = "Enter your message";
            this.messageBox.Visible = false;
            this.messageBox.Enter += new System.EventHandler(this.MessageBox_Enter);
            this.messageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.messageBox_KeyPress);
            this.messageBox.Leave += new System.EventHandler(this.messageBox_Leave);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(482, 9);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(78, 15);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "press to login";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.LoadChatBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.label1);
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
        public System.Windows.Forms.Button loadChatBt;
        public System.Windows.Forms.RichTextBox messageBox;
        public System.Windows.Forms.Button sendMessageBt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

