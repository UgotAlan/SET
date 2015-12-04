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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pingResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ramResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
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
            this.lobbyList.ItemHeight = 27;
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
            this.lobbyList.Location = new System.Drawing.Point(158, 100);
            this.lobbyList.Margin = new System.Windows.Forms.Padding(2);
            this.lobbyList.Name = "lobbyList";
            this.lobbyList.Size = new System.Drawing.Size(346, 247);
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
            this.lobbyNameLabel.Location = new System.Drawing.Point(154, 72);
            this.lobbyNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lobbyNameLabel.Name = "lobbyNameLabel";
            this.lobbyNameLabel.Size = new System.Drawing.Size(146, 26);
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
            this.playersInLobbyLabel.Location = new System.Drawing.Point(418, 72);
            this.playersInLobbyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playersInLobbyLabel.Name = "playersInLobbyLabel";
            this.playersInLobbyLabel.Size = new System.Drawing.Size(103, 26);
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
            this.joinLabel.Location = new System.Drawing.Point(154, 374);
            this.joinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(58, 29);
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
            this.createLabel.Location = new System.Drawing.Point(290, 374);
            this.createLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(85, 29);
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
            this.exitLabel.Location = new System.Drawing.Point(454, 374);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(52, 29);
            this.exitLabel.TabIndex = 9;
            this.exitLabel.Text = "Exit";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabelClick);
            this.exitLabel.MouseEnter += new System.EventHandler(this.ExitLabelMouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.ExitLabelMouseLeave);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pingResult,
            this.toolStripStatusLabel3,
            this.ramResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(663, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(40, 17);
            this.toolStripStatusLabel1.Text = " Ping: ";
            // 
            // pingResult
            // 
            this.pingResult.ForeColor = System.Drawing.Color.White;
            this.pingResult.Name = "pingResult";
            this.pingResult.Size = new System.Drawing.Size(29, 17);
            this.pingResult.Text = "N/A";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel3.Text = " Free Memory: ";
            // 
            // ramResult
            // 
            this.ramResult.ForeColor = System.Drawing.Color.White;
            this.ramResult.Name = "ramResult";
            this.ramResult.Size = new System.Drawing.Size(29, 17);
            this.ramResult.Text = "N/A";
            // 
            // LobbyFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(663, 532);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.playersInLobbyLabel);
            this.Controls.Add(this.lobbyNameLabel);
            this.Controls.Add(this.lobbyList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.MinimumSize = new System.Drawing.Size(679, 373);
            this.Name = "LobbyFinder";
            this.Text = "LobbyFinder";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel pingResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ramResult;
    }
}