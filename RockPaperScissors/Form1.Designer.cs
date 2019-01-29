namespace RockPaperScissors
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Scissors = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ScoreBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Scissors);
            this.groupBox1.Controls.Add(this.Paper);
            this.groupBox1.Controls.Add(this.Rock);
            this.groupBox1.Controls.Add(this.PlayerName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(7, 20);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(297, 20);
            this.PlayerName.TabIndex = 0;
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(7, 47);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(297, 23);
            this.Rock.TabIndex = 1;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(7, 77);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(297, 23);
            this.Paper.TabIndex = 2;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            // 
            // Scissors
            // 
            this.Scissors.Location = new System.Drawing.Point(7, 107);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(297, 23);
            this.Scissors.TabIndex = 3;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(330, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(458, 70);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(507, 13);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(100, 40);
            this.ScoreBox.TabIndex = 2;
            this.ScoreBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 164);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox ScoreBox;
    }
}

