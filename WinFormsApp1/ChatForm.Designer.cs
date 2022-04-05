
namespace WinFormsApp1
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.loadChatBt = new System.Windows.Forms.Button();
            this.sendMessageBt = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.SystemColors.Window;
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chatBox.HideSelection = false;
            this.chatBox.Location = new System.Drawing.Point(58, 66);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(440, 499);
            this.chatBox.TabIndex = 1;
            this.chatBox.Text = "";
            // 
            // loadChatBt
            // 
            this.loadChatBt.BackColor = System.Drawing.Color.Transparent;
            this.loadChatBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadChatBt.FlatAppearance.BorderSize = 0;
            this.loadChatBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loadChatBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loadChatBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadChatBt.Location = new System.Drawing.Point(420, 579);
            this.loadChatBt.Name = "loadChatBt";
            this.loadChatBt.Size = new System.Drawing.Size(41, 33);
            this.loadChatBt.TabIndex = 2;
            this.loadChatBt.UseVisualStyleBackColor = false;
            this.loadChatBt.Click += new System.EventHandler(this.LoadChatBt_Click);
            // 
            // sendMessageBt
            // 
            this.sendMessageBt.BackColor = System.Drawing.Color.Transparent;
            this.sendMessageBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessageBt.FlatAppearance.BorderSize = 0;
            this.sendMessageBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendMessageBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendMessageBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessageBt.Location = new System.Drawing.Point(467, 579);
            this.sendMessageBt.Name = "sendMessageBt";
            this.sendMessageBt.Size = new System.Drawing.Size(32, 33);
            this.sendMessageBt.TabIndex = 3;
            this.sendMessageBt.UseVisualStyleBackColor = false;
            this.sendMessageBt.Click += new System.EventHandler(this.SendMessageBt_Click);
            // 
            // messageBox
            // 
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageBox.Location = new System.Drawing.Point(69, 579);
            this.messageBox.Multiline = false;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(345, 32);
            this.messageBox.TabIndex = 4;
            this.messageBox.Text = "Enter your message";
            this.messageBox.Enter += new System.EventHandler(this.MessageBox_Enter);
            this.messageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.messageBox_KeyPress);
            this.messageBox.Leave += new System.EventHandler(this.messageBox_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameTextBox.Location = new System.Drawing.Point(60, 23);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ReadOnly = true;
            this.UsernameTextBox.Size = new System.Drawing.Size(131, 24);
            this.UsernameTextBox.TabIndex = 7;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Location = new System.Drawing.Point(189, 23);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(21, 24);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.sendMessageBt);
            this.Controls.Add(this.loadChatBt);
            this.Controls.Add(this.chatBox);
            this.Name = "ChatForm";
            this.Text = "MyChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox chatBox;
        public System.Windows.Forms.Button loadChatBt;
        public System.Windows.Forms.RichTextBox messageBox;
        public System.Windows.Forms.Button sendMessageBt;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button logoutButton;
    }
}

