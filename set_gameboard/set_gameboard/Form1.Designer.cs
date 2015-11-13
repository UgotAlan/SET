namespace set_gameboard
{
    partial class Set
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
            this.P1_score = new System.Windows.Forms.Label();
            this.P1_label = new System.Windows.Forms.Label();
            this.set_button = new System.Windows.Forms.Button();
            this.hint_text = new System.Windows.Forms.Label();
            this.options_button = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.P2_score = new System.Windows.Forms.Label();
            this.P2_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.P4_score = new System.Windows.Forms.Label();
            this.P4_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.P3_score = new System.Windows.Forms.Label();
            this.P3_label = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.P5_score = new System.Windows.Forms.Label();
            this.P5_label = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.P1_score);
            this.panel2.Controls.Add(this.P1_label);
            this.panel2.Location = new System.Drawing.Point(806, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 41);
            this.panel2.TabIndex = 1;
            // 
            // P1_score
            // 
            this.P1_score.BackColor = System.Drawing.Color.Transparent;
            this.P1_score.Font = new System.Drawing.Font("Arial", 12F);
            this.P1_score.ForeColor = System.Drawing.Color.White;
            this.P1_score.Location = new System.Drawing.Point(50, 0);
            this.P1_score.Name = "P1_score";
            this.P1_score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P1_score.Size = new System.Drawing.Size(119, 42);
            this.P1_score.TabIndex = 6;
            this.P1_score.Text = "0";
            this.P1_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P1_label
            // 
            this.P1_label.Font = new System.Drawing.Font("Arial", 12F);
            this.P1_label.ForeColor = System.Drawing.Color.White;
            this.P1_label.Location = new System.Drawing.Point(0, 0);
            this.P1_label.Name = "P1_label";
            this.P1_label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P1_label.Size = new System.Drawing.Size(237, 42);
            this.P1_label.TabIndex = 0;
            this.P1_label.Text = "P1:";
            this.P1_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // set_button
            // 
            this.set_button.BackColor = System.Drawing.Color.Goldenrod;
            this.set_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.set_button.Font = new System.Drawing.Font("Arial Black", 35F);
            this.set_button.ForeColor = System.Drawing.Color.White;
            this.set_button.Location = new System.Drawing.Point(806, 245);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(240, 200);
            this.set_button.TabIndex = 2;
            this.set_button.Text = "SET!";
            this.set_button.UseVisualStyleBackColor = false;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            this.set_button.MouseEnter += new System.EventHandler(this.set_button_MouseEnter);
            this.set_button.MouseLeave += new System.EventHandler(this.set_button_MouseLeave);
            // 
            // hint_text
            // 
            this.hint_text.Font = new System.Drawing.Font("Arial", 8F);
            this.hint_text.ForeColor = System.Drawing.Color.White;
            this.hint_text.Location = new System.Drawing.Point(806, 455);
            this.hint_text.Name = "hint_text";
            this.hint_text.Size = new System.Drawing.Size(240, 48);
            this.hint_text.TabIndex = 3;
            this.hint_text.Text = "Select three cards that form a set, then hit the yellow button.\r\n";
            this.hint_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // options_button
            // 
            this.options_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options_button.Font = new System.Drawing.Font("Arial Black", 15F);
            this.options_button.ForeColor = System.Drawing.Color.White;
            this.options_button.Location = new System.Drawing.Point(809, 550);
            this.options_button.Name = "options_button";
            this.options_button.Size = new System.Drawing.Size(237, 46);
            this.options_button.TabIndex = 4;
            this.options_button.Text = "OPTIONS";
            this.options_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.options_button.Click += new System.EventHandler(this.options_button_Click);
            this.options_button.MouseEnter += new System.EventHandler(this.options_button_MouseEnter);
            this.options_button.MouseLeave += new System.EventHandler(this.options_button_MouseLeave);
            // 
            // exit_button
            // 
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.Font = new System.Drawing.Font("Arial Black", 15F);
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(806, 605);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(240, 42);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "EXIT";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            this.exit_button.MouseEnter += new System.EventHandler(this.exit_button_MouseEnter);
            this.exit_button.MouseLeave += new System.EventHandler(this.exit_button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.P2_score);
            this.panel3.Controls.Add(this.P2_label);
            this.panel3.Location = new System.Drawing.Point(806, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 41);
            this.panel3.TabIndex = 2;
            // 
            // P2_score
            // 
            this.P2_score.BackColor = System.Drawing.Color.Transparent;
            this.P2_score.Font = new System.Drawing.Font("Arial", 12F);
            this.P2_score.ForeColor = System.Drawing.Color.White;
            this.P2_score.Location = new System.Drawing.Point(50, 0);
            this.P2_score.Name = "P2_score";
            this.P2_score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P2_score.Size = new System.Drawing.Size(119, 42);
            this.P2_score.TabIndex = 2;
            this.P2_score.Text = "0";
            this.P2_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P2_label
            // 
            this.P2_label.Font = new System.Drawing.Font("Arial", 12F);
            this.P2_label.ForeColor = System.Drawing.Color.White;
            this.P2_label.Location = new System.Drawing.Point(0, 0);
            this.P2_label.Name = "P2_label";
            this.P2_label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P2_label.Size = new System.Drawing.Size(237, 42);
            this.P2_label.TabIndex = 1;
            this.P2_label.Text = "P2:";
            this.P2_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.P4_score);
            this.panel4.Controls.Add(this.P4_label);
            this.panel4.Location = new System.Drawing.Point(806, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 41);
            this.panel4.TabIndex = 4;
            // 
            // P4_score
            // 
            this.P4_score.BackColor = System.Drawing.Color.Transparent;
            this.P4_score.Font = new System.Drawing.Font("Arial", 12F);
            this.P4_score.ForeColor = System.Drawing.Color.White;
            this.P4_score.Location = new System.Drawing.Point(50, -1);
            this.P4_score.Name = "P4_score";
            this.P4_score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P4_score.Size = new System.Drawing.Size(119, 42);
            this.P4_score.TabIndex = 4;
            this.P4_score.Text = "0";
            this.P4_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P4_label
            // 
            this.P4_label.Font = new System.Drawing.Font("Arial", 12F);
            this.P4_label.ForeColor = System.Drawing.Color.White;
            this.P4_label.Location = new System.Drawing.Point(0, 0);
            this.P4_label.Name = "P4_label";
            this.P4_label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P4_label.Size = new System.Drawing.Size(237, 42);
            this.P4_label.TabIndex = 3;
            this.P4_label.Text = "P4:";
            this.P4_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel5.Controls.Add(this.P3_score);
            this.panel5.Controls.Add(this.P3_label);
            this.panel5.Location = new System.Drawing.Point(806, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 41);
            this.panel5.TabIndex = 3;
            // 
            // P3_score
            // 
            this.P3_score.BackColor = System.Drawing.Color.Transparent;
            this.P3_score.Font = new System.Drawing.Font("Arial", 12F);
            this.P3_score.ForeColor = System.Drawing.Color.White;
            this.P3_score.Location = new System.Drawing.Point(50, 0);
            this.P3_score.Name = "P3_score";
            this.P3_score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P3_score.Size = new System.Drawing.Size(119, 42);
            this.P3_score.TabIndex = 3;
            this.P3_score.Text = "0";
            this.P3_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P3_label
            // 
            this.P3_label.Font = new System.Drawing.Font("Arial", 12F);
            this.P3_label.ForeColor = System.Drawing.Color.White;
            this.P3_label.Location = new System.Drawing.Point(0, 0);
            this.P3_label.Name = "P3_label";
            this.P3_label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P3_label.Size = new System.Drawing.Size(237, 42);
            this.P3_label.TabIndex = 2;
            this.P3_label.Text = "P3:";
            this.P3_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.panel6.Controls.Add(this.P5_score);
            this.panel6.Controls.Add(this.P5_label);
            this.panel6.Location = new System.Drawing.Point(806, 198);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 41);
            this.panel6.TabIndex = 5;
            // 
            // P5_score
            // 
            this.P5_score.BackColor = System.Drawing.Color.Transparent;
            this.P5_score.Font = new System.Drawing.Font("Arial", 12F);
            this.P5_score.ForeColor = System.Drawing.Color.White;
            this.P5_score.Location = new System.Drawing.Point(50, 0);
            this.P5_score.Name = "P5_score";
            this.P5_score.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P5_score.Size = new System.Drawing.Size(119, 42);
            this.P5_score.TabIndex = 5;
            this.P5_score.Text = "0";
            this.P5_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // P5_label
            // 
            this.P5_label.Font = new System.Drawing.Font("Arial", 12F);
            this.P5_label.ForeColor = System.Drawing.Color.White;
            this.P5_label.Location = new System.Drawing.Point(0, 0);
            this.P5_label.Name = "P5_label";
            this.P5_label.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.P5_label.Size = new System.Drawing.Size(237, 42);
            this.P5_label.TabIndex = 4;
            this.P5_label.Text = "P5:";
            this.P5_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.options_button);
            this.Controls.Add(this.hint_text);
            this.Controls.Add(this.set_button);
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.Label hint_text;
        private System.Windows.Forms.Label P1_label;
        private System.Windows.Forms.Label options_button;
        private System.Windows.Forms.Label exit_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label P2_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label P4_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label P3_label;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label P5_label;
        private System.Windows.Forms.Label P1_score;
        private System.Windows.Forms.Label P2_score;
        private System.Windows.Forms.Label P4_score;
        private System.Windows.Forms.Label P3_score;
        private System.Windows.Forms.Label P5_score;
    }
}

