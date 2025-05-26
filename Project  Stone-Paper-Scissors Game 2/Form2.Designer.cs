namespace Project__Stone_Paper_Scissors_Game_2
{
    partial class Form2
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
            this.lblRound = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnSccssior = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResultGame = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnComputer);
            this.panel1.Controls.Add(this.btnPlayer);
            this.panel1.Controls.Add(this.lblComputerResult);
            this.panel1.Controls.Add(this.lblPlayerResult);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(333, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 611);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblRound
            // 
            this.lblRound.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.Red;
            this.lblRound.Location = new System.Drawing.Point(436, 91);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(100, 56);
            this.lblRound.TabIndex = 11;
            this.lblRound.Text = "0";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(439, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Round";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnComputer
            // 
            this.btnComputer.BackgroundImage = global::Project__Stone_Paper_Scissors_Game_2.Properties.Resources.question_mark_96;
            this.btnComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComputer.Location = new System.Drawing.Point(530, 162);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(135, 117);
            this.btnComputer.TabIndex = 9;
            this.btnComputer.Tag = "Stone";
            this.btnComputer.UseVisualStyleBackColor = true;
            // 
            // btnPlayer
            // 
            this.btnPlayer.BackgroundImage = global::Project__Stone_Paper_Scissors_Game_2.Properties.Resources.question_mark_96;
            this.btnPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayer.Location = new System.Drawing.Point(316, 162);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(135, 117);
            this.btnPlayer.TabIndex = 7;
            this.btnPlayer.Tag = "Stone";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.BtnPlayer_Click);
            // 
            // lblComputerResult
            // 
            this.lblComputerResult.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerResult.ForeColor = System.Drawing.Color.Teal;
            this.lblComputerResult.Location = new System.Drawing.Point(558, 322);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(100, 23);
            this.lblComputerResult.TabIndex = 8;
            this.lblComputerResult.Text = "0";
            this.lblComputerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerResult.ForeColor = System.Drawing.Color.Teal;
            this.lblPlayerResult.Location = new System.Drawing.Point(330, 322);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "0";
            this.lblPlayerResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(545, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Computer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(330, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Player";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnPaper);
            this.panel2.Controls.Add(this.btnSccssior);
            this.panel2.Controls.Add(this.btnStone);
            this.panel2.Location = new System.Drawing.Point(24, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 371);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 49);
            this.label4.TabIndex = 6;
            this.label4.Text = "Paper";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "scissor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select an Option";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = global::Project__Stone_Paper_Scissors_Game_2.Properties.Resources.Paper;
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.Location = new System.Drawing.Point(30, 281);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 66);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Tag = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnSccssior
            // 
            this.btnSccssior.AutoSize = true;
            this.btnSccssior.BackgroundImage = global::Project__Stone_Paper_Scissors_Game_2.Properties.Resources.scissors1;
            this.btnSccssior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSccssior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSccssior.Location = new System.Drawing.Point(30, 189);
            this.btnSccssior.Name = "btnSccssior";
            this.btnSccssior.Size = new System.Drawing.Size(75, 66);
            this.btnSccssior.TabIndex = 1;
            this.btnSccssior.Tag = "Scissors";
            this.btnSccssior.UseVisualStyleBackColor = true;
            this.btnSccssior.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackgroundImage = global::Project__Stone_Paper_Scissors_Game_2.Properties.Resources.Stone;
            this.btnStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStone.Location = new System.Drawing.Point(30, 97);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 66);
            this.btnStone.TabIndex = 0;
            this.btnStone.Tag = "Stone";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(74, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 60);
            this.label8.TabIndex = 12;
            this.label8.Text = "Winner";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultGame
            // 
            this.lblResultGame.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultGame.ForeColor = System.Drawing.Color.Teal;
            this.lblResultGame.Location = new System.Drawing.Point(50, 246);
            this.lblResultGame.Name = "lblResultGame";
            this.lblResultGame.Size = new System.Drawing.Size(223, 97);
            this.lblResultGame.TabIndex = 13;
            this.lblResultGame.Text = "In Progress";
            this.lblResultGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Location = new System.Drawing.Point(57, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 88);
            this.button4.TabIndex = 14;
            this.button4.Text = "Restart Game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(52, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 61);
            this.label9.TabIndex = 15;
            this.label9.Text = "Enter the number of rounds?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox1_Validating);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1154, 577);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblResultGame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSccssior;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblPlayerResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResultGame;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPaper;
    }
}