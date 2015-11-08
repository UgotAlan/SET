namespace SET
{
    partial class LobbyFinder
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
            this.lobbyList = new System.Windows.Forms.ListBox();
            this.lobbyNameLabel = new System.Windows.Forms.Label();
            this.playersInLobbyLabel = new System.Windows.Forms.Label();
            this.joinLobbyButton = new System.Windows.Forms.Button();
            this.createLobbyButton = new System.Windows.Forms.Button();
            this.exitLobbyFinderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lobbyList
            // 
            this.lobbyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lobbyList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lobbyList.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lobbyList.FormattingEnabled = true;
            this.lobbyList.ItemHeight = 33;
            this.lobbyList.Items.AddRange(new object[] {
            "Example Lobby 1                                  3/5",
            "Example Lobby 2                                  1/5",
            "Example Lobby 3                                  4/5",
            "Example Lobby 4                                  2/5",
            "Example Lobby 5                                  1/5",
            "Example Lobby 6                                  3/5",
            "Example Lobby 7                                  4/5",
            "Example Lobby 8                                  2/5",
            "Example Lobby 9                                  2/5",
            "Example Lobby 10                                3/5",
            "Example Lobby 11                                1/5",
            "Example Lobby 12                                4/5",
            "Example Lobby 13                                3/5",
            "Example Lobby 14                                4/5",
            "Example Lobby 15                                4/5",
            "Example Lobby 16                                1/5"});
            this.lobbyList.Location = new System.Drawing.Point(211, 123);
            this.lobbyList.Name = "lobbyList";
            this.lobbyList.Size = new System.Drawing.Size(460, 334);
            this.lobbyList.TabIndex = 0;
            // 
            // lobbyNameLabel
            // 
            this.lobbyNameLabel.AutoSize = true;
            this.lobbyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lobbyNameLabel.Location = new System.Drawing.Point(205, 88);
            this.lobbyNameLabel.Name = "lobbyNameLabel";
            this.lobbyNameLabel.Size = new System.Drawing.Size(185, 32);
            this.lobbyNameLabel.TabIndex = 1;
            this.lobbyNameLabel.Text = "Lobby Name";
            // 
            // playersInLobbyLabel
            // 
            this.playersInLobbyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playersInLobbyLabel.AutoSize = true;
            this.playersInLobbyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersInLobbyLabel.Location = new System.Drawing.Point(558, 88);
            this.playersInLobbyLabel.Name = "playersInLobbyLabel";
            this.playersInLobbyLabel.Size = new System.Drawing.Size(131, 32);
            this.playersInLobbyLabel.TabIndex = 2;
            this.playersInLobbyLabel.Text = "In Lobby";
            // 
            // joinLobbyButton
            // 
            this.joinLobbyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joinLobbyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLobbyButton.Location = new System.Drawing.Point(211, 464);
            this.joinLobbyButton.Name = "joinLobbyButton";
            this.joinLobbyButton.Size = new System.Drawing.Size(111, 44);
            this.joinLobbyButton.TabIndex = 3;
            this.joinLobbyButton.Text = "Join";
            this.joinLobbyButton.UseVisualStyleBackColor = true;
            // 
            // createLobbyButton
            // 
            this.createLobbyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createLobbyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLobbyButton.Location = new System.Drawing.Point(379, 464);
            this.createLobbyButton.Name = "createLobbyButton";
            this.createLobbyButton.Size = new System.Drawing.Size(119, 44);
            this.createLobbyButton.TabIndex = 5;
            this.createLobbyButton.Text = "Create";
            this.createLobbyButton.UseVisualStyleBackColor = true;
            // 
            // exitLobbyFinderButton
            // 
            this.exitLobbyFinderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLobbyFinderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLobbyFinderButton.Location = new System.Drawing.Point(552, 464);
            this.exitLobbyFinderButton.Name = "exitLobbyFinderButton";
            this.exitLobbyFinderButton.Size = new System.Drawing.Size(119, 44);
            this.exitLobbyFinderButton.TabIndex = 6;
            this.exitLobbyFinderButton.Text = "Exit";
            this.exitLobbyFinderButton.UseVisualStyleBackColor = true;
            // 
            // LobbyFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(882, 655);
            this.Controls.Add(this.exitLobbyFinderButton);
            this.Controls.Add(this.createLobbyButton);
            this.Controls.Add(this.joinLobbyButton);
            this.Controls.Add(this.playersInLobbyLabel);
            this.Controls.Add(this.lobbyNameLabel);
            this.Controls.Add(this.lobbyList);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "LobbyFinder";
            this.Text = "LobbyFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lobbyList;
        private System.Windows.Forms.Label lobbyNameLabel;
        private System.Windows.Forms.Label playersInLobbyLabel;
        private System.Windows.Forms.Button joinLobbyButton;
        private System.Windows.Forms.Button createLobbyButton;
        private System.Windows.Forms.Button exitLobbyFinderButton;
    }
}