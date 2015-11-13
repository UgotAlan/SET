namespace SET
{
    /// <summary>
    /// This partial class contains all the information
    /// related to the LobbyFinder form.
    /// </summary>
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
            this.joinLabel = new System.Windows.Forms.Label();
            this.createLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lobbyList
            // 
            this.lobbyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lobbyList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lobbyList.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.lobbyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lobbyNameLabel.AutoSize = true;
            this.lobbyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lobbyNameLabel.ForeColor = System.Drawing.Color.White;
            this.lobbyNameLabel.Location = new System.Drawing.Point(205, 88);
            this.lobbyNameLabel.Name = "lobbyNameLabel";
            this.lobbyNameLabel.Size = new System.Drawing.Size(185, 32);
            this.lobbyNameLabel.TabIndex = 1;
            this.lobbyNameLabel.Text = "Lobby Name";
            // 
            // playersInLobbyLabel
            // 
            this.playersInLobbyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersInLobbyLabel.AutoSize = true;
            this.playersInLobbyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersInLobbyLabel.ForeColor = System.Drawing.Color.White;
            this.playersInLobbyLabel.Location = new System.Drawing.Point(558, 88);
            this.playersInLobbyLabel.Name = "playersInLobbyLabel";
            this.playersInLobbyLabel.Size = new System.Drawing.Size(131, 32);
            this.playersInLobbyLabel.TabIndex = 2;
            this.playersInLobbyLabel.Text = "In Lobby";
            // 
            // joinLabel
            // 
            this.joinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.joinLabel.AutoSize = true;
            this.joinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.joinLabel.ForeColor = System.Drawing.Color.White;
            this.joinLabel.Location = new System.Drawing.Point(205, 460);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(71, 36);
            this.joinLabel.TabIndex = 7;
            this.joinLabel.Text = "Join";
            this.joinLabel.Click += new System.EventHandler(this.JoinLabelClick);
            this.joinLabel.MouseEnter += new System.EventHandler(this.JoinLabelMouseEnter);
            this.joinLabel.MouseLeave += new System.EventHandler(this.JoinLabelMouseEnter);
            // 
            // createLabel
            // 
            this.createLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLabel.AutoSize = true;
            this.createLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.createLabel.ForeColor = System.Drawing.Color.White;
            this.createLabel.Location = new System.Drawing.Point(387, 460);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(102, 36);
            this.createLabel.TabIndex = 8;
            this.createLabel.Text = "Create";
            this.createLabel.Click += new System.EventHandler(this.CreateLabelClick);
            this.createLabel.MouseEnter += new System.EventHandler(this.CreateLabelMouseEnter);
            this.createLabel.MouseLeave += new System.EventHandler(this.CreateLabelMouseLeave);
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(606, 460);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(65, 36);
            this.exitLabel.TabIndex = 9;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabelClick);
            this.exitLabel.MouseEnter += new System.EventHandler(this.ExitLabelMouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.ExitLabelMouseLeave);
            // 
            // LobbyFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(882, 655);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.joinLabel);
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
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}