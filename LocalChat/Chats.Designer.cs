namespace LocalChat
{
    partial class Chats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chats));
            this.recipientsList = new System.Windows.Forms.FlowLayoutPanel();
            this.messagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.senderPanel = new System.Windows.Forms.Panel();
            this.senderMessage = new System.Windows.Forms.Label();
            this.senderName = new System.Windows.Forms.Label();
            this.senderPicture = new FontAwesome.Sharp.IconPictureBox();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.clientMessage = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.clientPicture = new FontAwesome.Sharp.IconPictureBox();
            this.userInfoPanel = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.Label();
            this.userDisplayName = new System.Windows.Forms.Label();
            this.userPicture = new FontAwesome.Sharp.IconPictureBox();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.sendButton = new FontAwesome.Sharp.IconButton();
            this.allPanel = new System.Windows.Forms.Panel();
            this.allPicture = new FontAwesome.Sharp.IconPictureBox();
            this.allName = new System.Windows.Forms.Label();
            this.recipientsList.SuspendLayout();
            this.messagesPanel.SuspendLayout();
            this.senderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderPicture)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).BeginInit();
            this.userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.allPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientsList
            // 
            this.recipientsList.Controls.Add(this.allPanel);
            this.recipientsList.Location = new System.Drawing.Point(12, 121);
            this.recipientsList.Name = "recipientsList";
            this.recipientsList.Size = new System.Drawing.Size(232, 540);
            this.recipientsList.TabIndex = 0;
            // 
            // messagesPanel
            // 
            this.messagesPanel.AutoScroll = true;
            this.messagesPanel.Controls.Add(this.senderPanel);
            this.messagesPanel.Controls.Add(this.clientPanel);
            this.messagesPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.messagesPanel.Location = new System.Drawing.Point(250, 12);
            this.messagesPanel.Name = "messagesPanel";
            this.messagesPanel.Size = new System.Drawing.Size(800, 595);
            this.messagesPanel.TabIndex = 1;
            // 
            // senderPanel
            // 
            this.senderPanel.AutoSize = true;
            this.senderPanel.BackColor = System.Drawing.Color.Transparent;
            this.senderPanel.Controls.Add(this.senderMessage);
            this.senderPanel.Controls.Add(this.senderName);
            this.senderPanel.Controls.Add(this.senderPicture);
            this.senderPanel.Location = new System.Drawing.Point(15, 15);
            this.senderPanel.Margin = new System.Windows.Forms.Padding(15, 15, 30, 3);
            this.senderPanel.MaximumSize = new System.Drawing.Size(735, 0);
            this.senderPanel.MinimumSize = new System.Drawing.Size(735, 91);
            this.senderPanel.Name = "senderPanel";
            this.senderPanel.Size = new System.Drawing.Size(735, 91);
            this.senderPanel.TabIndex = 0;
            // 
            // senderMessage
            // 
            this.senderMessage.AutoSize = true;
            this.senderMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.senderMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.senderMessage.Location = new System.Drawing.Point(56, 38);
            this.senderMessage.Margin = new System.Windows.Forms.Padding(3, 0, 0, 15);
            this.senderMessage.MaximumSize = new System.Drawing.Size(675, 0);
            this.senderMessage.Name = "senderMessage";
            this.senderMessage.Padding = new System.Windows.Forms.Padding(9);
            this.senderMessage.Size = new System.Drawing.Size(135, 38);
            this.senderMessage.TabIndex = 4;
            this.senderMessage.Text = "Sender message";
            this.senderMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // senderName
            // 
            this.senderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.senderName.Location = new System.Drawing.Point(56, 3);
            this.senderName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.senderName.MinimumSize = new System.Drawing.Size(0, 9);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(675, 32);
            this.senderName.TabIndex = 3;
            this.senderName.Text = "User Display Name";
            this.senderName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // senderPicture
            // 
            this.senderPicture.BackColor = System.Drawing.Color.Transparent;
            this.senderPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.senderPicture.IconChar = FontAwesome.Sharp.IconChar.User;
            this.senderPicture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.senderPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.senderPicture.IconSize = 38;
            this.senderPicture.Location = new System.Drawing.Point(0, 38);
            this.senderPicture.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.senderPicture.Name = "senderPicture";
            this.senderPicture.Size = new System.Drawing.Size(38, 38);
            this.senderPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.senderPicture.TabIndex = 2;
            this.senderPicture.TabStop = false;
            // 
            // clientPanel
            // 
            this.clientPanel.AutoSize = true;
            this.clientPanel.BackColor = System.Drawing.Color.Transparent;
            this.clientPanel.Controls.Add(this.clientMessage);
            this.clientPanel.Controls.Add(this.clientName);
            this.clientPanel.Controls.Add(this.clientPicture);
            this.clientPanel.Location = new System.Drawing.Point(50, 112);
            this.clientPanel.Margin = new System.Windows.Forms.Padding(50, 3, 15, 15);
            this.clientPanel.MaximumSize = new System.Drawing.Size(735, 0);
            this.clientPanel.MinimumSize = new System.Drawing.Size(735, 91);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(735, 151);
            this.clientPanel.TabIndex = 1;
            // 
            // clientMessage
            // 
            this.clientMessage.AutoSize = true;
            this.clientMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.clientMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.clientMessage.Location = new System.Drawing.Point(3, 38);
            this.clientMessage.Margin = new System.Windows.Forms.Padding(3, 0, 0, 15);
            this.clientMessage.MaximumSize = new System.Drawing.Size(675, 0);
            this.clientMessage.Name = "clientMessage";
            this.clientMessage.Padding = new System.Windows.Forms.Padding(9);
            this.clientMessage.Size = new System.Drawing.Size(675, 98);
            this.clientMessage.TabIndex = 4;
            this.clientMessage.Text = resources.GetString("clientMessage.Text");
            this.clientMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientName
            // 
            this.clientName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.clientName.Location = new System.Drawing.Point(3, 3);
            this.clientName.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.clientName.MinimumSize = new System.Drawing.Size(0, 9);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(675, 32);
            this.clientName.TabIndex = 3;
            this.clientName.Text = "User Display Name";
            this.clientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientPicture
            // 
            this.clientPicture.BackColor = System.Drawing.Color.Transparent;
            this.clientPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.clientPicture.IconChar = FontAwesome.Sharp.IconChar.User;
            this.clientPicture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.clientPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clientPicture.IconSize = 38;
            this.clientPicture.Location = new System.Drawing.Point(696, 38);
            this.clientPicture.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.clientPicture.Name = "clientPicture";
            this.clientPicture.Size = new System.Drawing.Size(38, 38);
            this.clientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.clientPicture.TabIndex = 2;
            this.clientPicture.TabStop = false;
            // 
            // userInfoPanel
            // 
            this.userInfoPanel.Controls.Add(this.userName);
            this.userInfoPanel.Controls.Add(this.userDisplayName);
            this.userInfoPanel.Controls.Add(this.userPicture);
            this.userInfoPanel.Location = new System.Drawing.Point(12, 12);
            this.userInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.userInfoPanel.Name = "userInfoPanel";
            this.userInfoPanel.Size = new System.Drawing.Size(232, 106);
            this.userInfoPanel.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.userName.Location = new System.Drawing.Point(59, 53);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(152, 32);
            this.userName.TabIndex = 2;
            this.userName.Text = "User Name";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userDisplayName
            // 
            this.userDisplayName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.userDisplayName.Location = new System.Drawing.Point(59, 21);
            this.userDisplayName.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.userDisplayName.Name = "userDisplayName";
            this.userDisplayName.Size = new System.Drawing.Size(152, 32);
            this.userDisplayName.TabIndex = 1;
            this.userDisplayName.Text = "User Display Name";
            this.userDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.userPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.userPicture.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userPicture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.userPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userPicture.Location = new System.Drawing.Point(21, 21);
            this.userPicture.Margin = new System.Windows.Forms.Padding(3, 3, 3, 21);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(32, 32);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // messageInput
            // 
            this.messageInput.AcceptsTab = true;
            this.messageInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.messageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(66)))), ((int)(((byte)(85)))));
            this.messageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.messageInput.Location = new System.Drawing.Point(250, 613);
            this.messageInput.Multiline = true;
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(746, 48);
            this.messageInput.TabIndex = 2;
            this.messageInput.Text = "Test Text";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(137)))), ((int)(((byte)(255)))));
            this.sendButton.FlatAppearance.BorderSize = 0;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.sendButton.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.sendButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.sendButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sendButton.IconSize = 32;
            this.sendButton.Location = new System.Drawing.Point(1002, 613);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(48, 48);
            this.sendButton.TabIndex = 3;
            this.sendButton.UseVisualStyleBackColor = false;
            // 
            // allPanel
            // 
            this.allPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.allPanel.Controls.Add(this.allName);
            this.allPanel.Controls.Add(this.allPicture);
            this.allPanel.Location = new System.Drawing.Point(15, 0);
            this.allPanel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.allPanel.Name = "allPanel";
            this.allPanel.Size = new System.Drawing.Size(202, 64);
            this.allPanel.TabIndex = 0;
            // 
            // allPicture
            // 
            this.allPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.allPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.allPicture.IconChar = FontAwesome.Sharp.IconChar.User;
            this.allPicture.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.allPicture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.allPicture.Location = new System.Drawing.Point(6, 16);
            this.allPicture.Name = "allPicture";
            this.allPicture.Size = new System.Drawing.Size(32, 32);
            this.allPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.allPicture.TabIndex = 3;
            this.allPicture.TabStop = false;
            // 
            // allName
            // 
            this.allName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.allName.Location = new System.Drawing.Point(44, 16);
            this.allName.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.allName.Name = "allName";
            this.allName.Size = new System.Drawing.Size(152, 32);
            this.allName.TabIndex = 3;
            this.allName.Text = "Everyone";
            this.allName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Chats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.messagesPanel);
            this.Controls.Add(this.recipientsList);
            this.Name = "Chats";
            this.Text = "LocalChat";
            this.recipientsList.ResumeLayout(false);
            this.messagesPanel.ResumeLayout(false);
            this.messagesPanel.PerformLayout();
            this.senderPanel.ResumeLayout(false);
            this.senderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderPicture)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).EndInit();
            this.userInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.allPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label allName;

        public FontAwesome.Sharp.IconPictureBox allPicture;

        public System.Windows.Forms.Panel allPanel;

        public System.Windows.Forms.Panel clientPanel;
        public FontAwesome.Sharp.IconPictureBox clientPicture;

        public System.Windows.Forms.Label userName;
        public System.Windows.Forms.Label clientName;
        public System.Windows.Forms.Label clientMessage;
        public System.Windows.Forms.Label senderName;
        public System.Windows.Forms.Label senderMessage;

        public FontAwesome.Sharp.IconButton sendButton;

        public System.Windows.Forms.TextBox messageInput;

        public FontAwesome.Sharp.IconPictureBox senderPicture;

        public System.Windows.Forms.Panel senderPanel;

        public System.Windows.Forms.Label userDisplayName;

        public FontAwesome.Sharp.IconPictureBox userPicture;

        public System.Windows.Forms.Panel userInfoPanel;

        public System.Windows.Forms.FlowLayoutPanel messagesPanel;

        public System.Windows.Forms.FlowLayoutPanel recipientsList;

        #endregion
    }
}