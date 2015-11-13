namespace SET
{
    /// <summary>
    /// This partial class contains all information
    /// related to the GameBoard form.
    /// </summary>
    partial class GameBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player1Score = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.hintText = new System.Windows.Forms.Label();
            this.optionsButton = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.player2Score = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.player4Score = new System.Windows.Forms.Label();
            this.player4Label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.player3Score = new System.Windows.Forms.Label();
            this.player3Label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.player5Score = new System.Windows.Forms.Label();
            this.player5Label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 650);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.player1Score);
            this.panel2.Controls.Add(this.player1Label);
            this.panel2.Location = new System.Drawing.Point(806, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 41);
            this.panel2.TabIndex = 1;
            // 
            // player1Score
            // 
            this.player1Score.BackColor = System.Drawing.Color.Transparent;
            this.player1Score.Font = new System.Drawing.Font("Arial", 12F);
            this.player1Score.ForeColor = System.Drawing.Color.White;
            this.player1Score.Location = new System.Drawing.Point(50, 0);
            this.player1Score.Name = "player1Score";
            this.player1Score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player1Score.Size = new System.Drawing.Size(119, 42);
            this.player1Score.TabIndex = 6;
            this.player1Score.Text = "0";
            this.player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player1Label
            // 
            this.player1Label.Font = new System.Drawing.Font("Arial", 12F);
            this.player1Label.ForeColor = System.Drawing.Color.White;
            this.player1Label.Location = new System.Drawing.Point(0, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player1Label.Size = new System.Drawing.Size(237, 42);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "P1:";
            this.player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.Goldenrod;
            this.setButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setButton.Font = new System.Drawing.Font("Arial Black", 35F);
            this.setButton.ForeColor = System.Drawing.Color.White;
            this.setButton.Location = new System.Drawing.Point(806, 245);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(240, 200);
            this.setButton.TabIndex = 2;
            this.setButton.Text = "SET!";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.SetButtonClick);
            this.setButton.MouseEnter += new System.EventHandler(this.SetButtonMouseOver);
            this.setButton.MouseLeave += new System.EventHandler(this.SetButtonMouseLeave);
            // 
            // hintText
            // 
            this.hintText.Font = new System.Drawing.Font("Arial", 8F);
            this.hintText.ForeColor = System.Drawing.Color.White;
            this.hintText.Location = new System.Drawing.Point(806, 455);
            this.hintText.Name = "hintText";
            this.hintText.Size = new System.Drawing.Size(240, 48);
            this.hintText.TabIndex = 3;
            this.hintText.Text = "Select three cards that form a set, then hit the yellow button.\r\n";
            this.hintText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsButton
            // 
            this.optionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionsButton.Font = new System.Drawing.Font("Arial Black", 15F);
            this.optionsButton.ForeColor = System.Drawing.Color.White;
            this.optionsButton.Location = new System.Drawing.Point(809, 550);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(237, 46);
            this.optionsButton.TabIndex = 4;
            this.optionsButton.Text = "OPTIONS";
            this.optionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionsButton.Click += new System.EventHandler(this.OptionsButtonClick);
            this.optionsButton.MouseEnter += new System.EventHandler(this.OptionsButtonMouseOver);
            this.optionsButton.MouseLeave += new System.EventHandler(this.OptionsButtonMouseLeave);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Arial Black", 15F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(806, 605);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(240, 42);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "EXIT";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButtonMouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButtonMouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.player2Score);
            this.panel3.Controls.Add(this.player2Label);
            this.panel3.Location = new System.Drawing.Point(806, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 41);
            this.panel3.TabIndex = 2;
            // 
            // player2Score
            // 
            this.player2Score.BackColor = System.Drawing.Color.Transparent;
            this.player2Score.Font = new System.Drawing.Font("Arial", 12F);
            this.player2Score.ForeColor = System.Drawing.Color.White;
            this.player2Score.Location = new System.Drawing.Point(50, 0);
            this.player2Score.Name = "player2Score";
            this.player2Score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player2Score.Size = new System.Drawing.Size(119, 42);
            this.player2Score.TabIndex = 2;
            this.player2Score.Text = "0";
            this.player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player2Label
            // 
            this.player2Label.Font = new System.Drawing.Font("Arial", 12F);
            this.player2Label.ForeColor = System.Drawing.Color.White;
            this.player2Label.Location = new System.Drawing.Point(0, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player2Label.Size = new System.Drawing.Size(237, 42);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "P2:";
            this.player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.player4Score);
            this.panel4.Controls.Add(this.player4Label);
            this.panel4.Location = new System.Drawing.Point(806, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 41);
            this.panel4.TabIndex = 4;
            // 
            // player4Score
            // 
            this.player4Score.BackColor = System.Drawing.Color.Transparent;
            this.player4Score.Font = new System.Drawing.Font("Arial", 12F);
            this.player4Score.ForeColor = System.Drawing.Color.White;
            this.player4Score.Location = new System.Drawing.Point(50, -1);
            this.player4Score.Name = "player4Score";
            this.player4Score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player4Score.Size = new System.Drawing.Size(119, 42);
            this.player4Score.TabIndex = 4;
            this.player4Score.Text = "0";
            this.player4Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player4Label
            // 
            this.player4Label.Font = new System.Drawing.Font("Arial", 12F);
            this.player4Label.ForeColor = System.Drawing.Color.White;
            this.player4Label.Location = new System.Drawing.Point(0, 0);
            this.player4Label.Name = "player4Label";
            this.player4Label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player4Label.Size = new System.Drawing.Size(237, 42);
            this.player4Label.TabIndex = 3;
            this.player4Label.Text = "P4:";
            this.player4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel5.Controls.Add(this.player3Score);
            this.panel5.Controls.Add(this.player3Label);
            this.panel5.Location = new System.Drawing.Point(806, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 41);
            this.panel5.TabIndex = 3;
            // 
            // player3Score
            // 
            this.player3Score.BackColor = System.Drawing.Color.Transparent;
            this.player3Score.Font = new System.Drawing.Font("Arial", 12F);
            this.player3Score.ForeColor = System.Drawing.Color.White;
            this.player3Score.Location = new System.Drawing.Point(50, 0);
            this.player3Score.Name = "player3Score";
            this.player3Score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player3Score.Size = new System.Drawing.Size(119, 42);
            this.player3Score.TabIndex = 3;
            this.player3Score.Text = "0";
            this.player3Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player3Label
            // 
            this.player3Label.Font = new System.Drawing.Font("Arial", 12F);
            this.player3Label.ForeColor = System.Drawing.Color.White;
            this.player3Label.Location = new System.Drawing.Point(0, 0);
            this.player3Label.Name = "player3Label";
            this.player3Label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player3Label.Size = new System.Drawing.Size(237, 42);
            this.player3Label.TabIndex = 2;
            this.player3Label.Text = "P3:";
            this.player3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel6.Controls.Add(this.player5Score);
            this.panel6.Controls.Add(this.player5Label);
            this.panel6.Location = new System.Drawing.Point(806, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 41);
            this.panel6.TabIndex = 5;
            // 
            // player5Score
            // 
            this.player5Score.BackColor = System.Drawing.Color.Transparent;
            this.player5Score.Font = new System.Drawing.Font("Arial", 12F);
            this.player5Score.ForeColor = System.Drawing.Color.White;
            this.player5Score.Location = new System.Drawing.Point(50, 0);
            this.player5Score.Name = "player5Score";
            this.player5Score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player5Score.Size = new System.Drawing.Size(119, 42);
            this.player5Score.TabIndex = 5;
            this.player5Score.Text = "0";
            this.player5Score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // player5Label
            // 
            this.player5Label.Font = new System.Drawing.Font("Arial", 12F);
            this.player5Label.ForeColor = System.Drawing.Color.White;
            this.player5Label.Location = new System.Drawing.Point(0, 0);
            this.player5Label.Name = "player5Label";
            this.player5Label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.player5Label.Size = new System.Drawing.Size(237, 42);
            this.player5Label.TabIndex = 4;
            this.player5Label.Text = "P5:";
            this.player5Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.hintText);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Set";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label hintText;
        private System.Windows.Forms.Label optionsButton;
        private System.Windows.Forms.Label exitButton;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player3Label;
        private System.Windows.Forms.Label player4Label;
        private System.Windows.Forms.Label player5Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label player3Score;
        private System.Windows.Forms.Label player4Score;
        private System.Windows.Forms.Label player5Score;
    }
}