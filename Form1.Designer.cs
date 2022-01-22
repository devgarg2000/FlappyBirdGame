
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Score = new System.Windows.Forms.Label();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuBoxGameOver = new System.Windows.Forms.Label();
            this.menuBoxPlayAgain = new System.Windows.Forms.Label();
            this.menuBoxQuit = new System.Windows.Forms.Label();
            this.menuBoxScore = new System.Windows.Forms.Label();
            this.menuBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            this.menuBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(295, 454);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(77, 25);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score :";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // Ground
            // 
            this.Ground.Image = global::WindowsFormsApp1.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(2, 422);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(800, 84);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::WindowsFormsApp1.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(644, -4);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(84, 186);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 2;
            this.PipeTop.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::WindowsFormsApp1.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(508, 336);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(90, 126);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 1;
            this.PipeBottom.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::WindowsFormsApp1.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(71, 166);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(76, 60);
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // menuBoxGameOver
            // 
            this.menuBoxGameOver.AllowDrop = true;
            this.menuBoxGameOver.AutoSize = true;
            this.menuBoxGameOver.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBoxGameOver.ForeColor = System.Drawing.Color.White;
            this.menuBoxGameOver.Location = new System.Drawing.Point(79, 22);
            this.menuBoxGameOver.Name = "menuBoxGameOver";
            this.menuBoxGameOver.Size = new System.Drawing.Size(117, 23);
            this.menuBoxGameOver.TabIndex = 7;
            this.menuBoxGameOver.Text = "Game Over!!";
            this.menuBoxGameOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.menuBoxGameOver.Click += new System.EventHandler(this.menuBoxGameOver_Click);
            // 
            // menuBoxPlayAgain
            // 
            this.menuBoxPlayAgain.AutoSize = true;
            this.menuBoxPlayAgain.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBoxPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.menuBoxPlayAgain.Location = new System.Drawing.Point(81, 106);
            this.menuBoxPlayAgain.Name = "menuBoxPlayAgain";
            this.menuBoxPlayAgain.Size = new System.Drawing.Size(117, 27);
            this.menuBoxPlayAgain.TabIndex = 8;
            this.menuBoxPlayAgain.Text = "Play Again";
            this.menuBoxPlayAgain.Click += new System.EventHandler(this.menuBoxPlayAgain_Click);
            // 
            // menuBoxQuit
            // 
            this.menuBoxQuit.AutoSize = true;
            this.menuBoxQuit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBoxQuit.ForeColor = System.Drawing.Color.Red;
            this.menuBoxQuit.Location = new System.Drawing.Point(105, 162);
            this.menuBoxQuit.Name = "menuBoxQuit";
            this.menuBoxQuit.Size = new System.Drawing.Size(54, 27);
            this.menuBoxQuit.TabIndex = 9;
            this.menuBoxQuit.Text = "Quit";
            this.menuBoxQuit.Click += new System.EventHandler(this.menuBoxQuit_Click);
            // 
            // menuBoxScore
            // 
            this.menuBoxScore.AutoSize = true;
            this.menuBoxScore.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBoxScore.Location = new System.Drawing.Point(97, 56);
            this.menuBoxScore.Name = "menuBoxScore";
            this.menuBoxScore.Size = new System.Drawing.Size(78, 27);
            this.menuBoxScore.TabIndex = 10;
            this.menuBoxScore.Text = "Score :";
            this.menuBoxScore.Click += new System.EventHandler(this.menuBoxScore_Click);
            // 
            // menuBox
            // 
            this.menuBox.Controls.Add(this.menuBoxGameOver);
            this.menuBox.Controls.Add(this.menuBoxQuit);
            this.menuBox.Controls.Add(this.menuBoxScore);
            this.menuBox.Controls.Add(this.menuBoxPlayAgain);
            this.menuBox.Location = new System.Drawing.Point(228, 67);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(284, 222);
            this.menuBox.TabIndex = 11;
            this.menuBox.TabStop = false;
            this.menuBox.Text = "menu";
            this.menuBox.Enter += new System.EventHandler(this.menuBox_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 503);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            this.menuBox.ResumeLayout(false);
            this.menuBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label menuBoxGameOver;
        private System.Windows.Forms.Label menuBoxPlayAgain;
        private System.Windows.Forms.Label menuBoxQuit;
        private System.Windows.Forms.Label menuBoxScore;
        private System.Windows.Forms.GroupBox menuBox;
    }
}

