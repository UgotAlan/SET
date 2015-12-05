namespace SET
{
    /// <summary>
    /// This partial class contains all information
    /// related to the Lobby form.
    /// </summary>
    partial class Lobby
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
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.singleColorModeRadioButton = new System.Windows.Forms.RadioButton();
            this.normalModeRadioButton = new System.Windows.Forms.RadioButton();
            this.numberOfSetsLabel = new System.Windows.Forms.Label();
            this.numberOfSetsTextBox = new System.Windows.Forms.TextBox();
            this.tutorialModeRadioButton = new System.Windows.Forms.RadioButton();
            this.beginnerModeRadioButton = new System.Windows.Forms.RadioButton();
            this.playerList = new System.Windows.Forms.GroupBox();
            this.player5Label = new System.Windows.Forms.Label();
            this.player4Label = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.quitLabel = new System.Windows.Forms.Label();
            this.optionsGroupBox.SuspendLayout();
            this.playerList.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.singleColorModeRadioButton);
            this.optionsGroupBox.Controls.Add(this.normalModeRadioButton);
            this.optionsGroupBox.Controls.Add(this.numberOfSetsLabel);
            this.optionsGroupBox.Controls.Add(this.numberOfSetsTextBox);
            this.optionsGroupBox.Controls.Add(this.tutorialModeRadioButton);
            this.optionsGroupBox.Controls.Add(this.beginnerModeRadioButton);
            this.optionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.optionsGroupBox.Location = new System.Drawing.Point(95, 137);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(266, 242);
            this.optionsGroupBox.TabIndex = 6;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // singleColorModeRadioButton
            // 
            this.singleColorModeRadioButton.AutoSize = true;
            this.singleColorModeRadioButton.Location = new System.Drawing.Point(24, 34);
            this.singleColorModeRadioButton.Name = "singleColorModeRadioButton";
            this.singleColorModeRadioButton.Size = new System.Drawing.Size(236, 33);
            this.singleColorModeRadioButton.TabIndex = 6;
            this.singleColorModeRadioButton.Text = "Single Color Mode";
            this.singleColorModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalModeRadioButton
            // 
            this.normalModeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.normalModeRadioButton.AutoSize = true;
            this.normalModeRadioButton.Checked = true;
            this.normalModeRadioButton.ForeColor = System.Drawing.Color.White;
            this.normalModeRadioButton.Location = new System.Drawing.Point(24, 152);
            this.normalModeRadioButton.Name = "normalModeRadioButton";
            this.normalModeRadioButton.Size = new System.Drawing.Size(181, 33);
            this.normalModeRadioButton.TabIndex = 5;
            this.normalModeRadioButton.TabStop = true;
            this.normalModeRadioButton.Text = "Normal Mode";
            this.normalModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberOfSetsLabel
            // 
            this.numberOfSetsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfSetsLabel.AutoSize = true;
            this.numberOfSetsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfSetsLabel.Location = new System.Drawing.Point(18, 195);
            this.numberOfSetsLabel.Name = "numberOfSetsLabel";
            this.numberOfSetsLabel.Size = new System.Drawing.Size(180, 29);
            this.numberOfSetsLabel.TabIndex = 4;
            this.numberOfSetsLabel.Text = "Number of Sets";
            // 
            // numberOfSetsTextBox
            // 
            this.numberOfSetsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfSetsTextBox.Location = new System.Drawing.Point(201, 194);
            this.numberOfSetsTextBox.MaxLength = 2;
            this.numberOfSetsTextBox.Name = "numberOfSetsTextBox";
            this.numberOfSetsTextBox.Size = new System.Drawing.Size(35, 34);
            this.numberOfSetsTextBox.TabIndex = 3;
            this.numberOfSetsTextBox.WordWrap = false;
            // 
            // tutorialModeRadioButton
            // 
            this.tutorialModeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tutorialModeRadioButton.AutoSize = true;
            this.tutorialModeRadioButton.ForeColor = System.Drawing.Color.White;
            this.tutorialModeRadioButton.Location = new System.Drawing.Point(24, 113);
            this.tutorialModeRadioButton.Name = "tutorialModeRadioButton";
            this.tutorialModeRadioButton.Size = new System.Drawing.Size(184, 33);
            this.tutorialModeRadioButton.TabIndex = 2;
            this.tutorialModeRadioButton.Text = "Tutorial Mode";
            this.tutorialModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // beginnerModeRadioButton
            // 
            this.beginnerModeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beginnerModeRadioButton.AutoSize = true;
            this.beginnerModeRadioButton.ForeColor = System.Drawing.Color.White;
            this.beginnerModeRadioButton.Location = new System.Drawing.Point(24, 73);
            this.beginnerModeRadioButton.Name = "beginnerModeRadioButton";
            this.beginnerModeRadioButton.Size = new System.Drawing.Size(200, 33);
            this.beginnerModeRadioButton.TabIndex = 1;
            this.beginnerModeRadioButton.Text = "Beginner Mode";
            this.beginnerModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.Controls.Add(this.player5Label);
            this.playerList.Controls.Add(this.player4Label);
            this.playerList.Controls.Add(this.player3Label);
            this.playerList.Controls.Add(this.player2Label);
            this.playerList.Controls.Add(this.player1Label);
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.ForeColor = System.Drawing.Color.White;
            this.playerList.Location = new System.Drawing.Point(561, 107);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(200, 324);
            this.playerList.TabIndex = 7;
            this.playerList.TabStop = false;
            this.playerList.Text = "Players";
            // 
            // player5Label
            // 
            this.player5Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player5Label.AutoSize = true;
            this.player5Label.ForeColor = System.Drawing.Color.White;
            this.player5Label.Location = new System.Drawing.Point(6, 270);
            this.player5Label.Name = "player5Label";
            this.player5Label.Size = new System.Drawing.Size(102, 29);
            this.player5Label.TabIndex = 4;
            this.player5Label.Text = "1 - Chris";
            // 
            // player4Label
            // 
            this.player4Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player4Label.AutoSize = true;
            this.player4Label.ForeColor = System.Drawing.Color.White;
            this.player4Label.Location = new System.Drawing.Point(6, 210);
            this.player4Label.Name = "player4Label";
            this.player4Label.Size = new System.Drawing.Size(102, 29);
            this.player4Label.TabIndex = 3;
            this.player4Label.Text = "1 - Chris";
            // 
            // player3Label
            // 
            this.player3Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player3Label.AutoSize = true;
            this.player3Label.ForeColor = System.Drawing.Color.White;
            this.player3Label.Location = new System.Drawing.Point(6, 150);
            this.player3Label.Name = "player3Label";
            this.player3Label.Size = new System.Drawing.Size(102, 29);
            this.player3Label.TabIndex = 2;
            this.player3Label.Text = "1 - Chris";
            // 
            // player2Label
            // 
            this.player2Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player2Label.AutoSize = true;
            this.player2Label.ForeColor = System.Drawing.Color.White;
            this.player2Label.Location = new System.Drawing.Point(6, 90);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(102, 29);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "1 - Chris";
            // 
            // player1Label
            // 
            this.player1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player1Label.AutoSize = true;
            this.player1Label.ForeColor = System.Drawing.Color.White;
            this.player1Label.Location = new System.Drawing.Point(6, 30);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(102, 29);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "1 - Chris";
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.AutoSize = true;
            this.startLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(191, 395);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(77, 36);
            this.startLabel.TabIndex = 8;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.StartLabelClick);
            this.startLabel.MouseEnter += new System.EventHandler(this.StartLabelMouseEnter);
            this.startLabel.MouseLeave += new System.EventHandler(this.StartLabelMouseLeave);
            // 
            // quitLabel
            // 
            this.quitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitLabel.AutoSize = true;
            this.quitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.quitLabel.ForeColor = System.Drawing.Color.White;
            this.quitLabel.Location = new System.Drawing.Point(627, 444);
            this.quitLabel.Name = "quitLabel";
            this.quitLabel.Size = new System.Drawing.Size(69, 36);
            this.quitLabel.TabIndex = 9;
            this.quitLabel.Text = "Quit";
            this.quitLabel.Click += new System.EventHandler(this.QuitLabelClick);
            this.quitLabel.MouseEnter += new System.EventHandler(this.QuitLabelMouseEnter);
            this.quitLabel.MouseLeave += new System.EventHandler(this.QuitLabelMouseLeave);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(882, 655);
            this.Controls.Add(this.quitLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.optionsGroupBox);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.playerList.ResumeLayout(false);
            this.playerList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.GroupBox playerList;
        private System.Windows.Forms.Label numberOfSetsLabel;
        private System.Windows.Forms.TextBox numberOfSetsTextBox;
        private System.Windows.Forms.RadioButton tutorialModeRadioButton;
        private System.Windows.Forms.RadioButton beginnerModeRadioButton;
        private System.Windows.Forms.Label player5Label;
        private System.Windows.Forms.Label player4Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.RadioButton normalModeRadioButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label quitLabel;
        private System.Windows.Forms.RadioButton singleColorModeRadioButton;
    }
}