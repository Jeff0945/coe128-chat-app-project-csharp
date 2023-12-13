using SelfLink.Constants;

namespace SelfLink
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
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
            this.messagesPanel.SuspendLayout();
            this.senderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderPicture)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicture)).BeginInit();
            this.userInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientsList
            // 
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
            this.messagesPanel.Location = new System.Drawing.Point(250, 12);
            this.messagesPanel.Name = "messagesPanel";
            this.messagesPanel.Size = new System.Drawing.Size(800, 595);
            this.messagesPanel.TabIndex = 1;
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
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(102)))), ((int)(((byte)(159)))));
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
            // Interface
            // 
            this.AcceptButton = this.sendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.userInfoPanel);
            this.Controls.Add(this.messagesPanel);
            this.Controls.Add(this.recipientsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Interface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelfLink";
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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