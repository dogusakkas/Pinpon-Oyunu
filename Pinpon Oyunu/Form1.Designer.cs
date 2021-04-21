namespace Pinpon_Oyunu
{
    partial class gameForm
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
            this.playground_panel1 = new System.Windows.Forms.Panel();
            this.gameover_label3 = new System.Windows.Forms.Label();
            this.points_label2 = new System.Windows.Forms.Label();
            this.Score_label1 = new System.Windows.Forms.Label();
            this.ball_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.racket_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playground_panel1
            // 
            this.playground_panel1.BackColor = System.Drawing.Color.White;
            this.playground_panel1.Controls.Add(this.gameover_label3);
            this.playground_panel1.Controls.Add(this.points_label2);
            this.playground_panel1.Controls.Add(this.Score_label1);
            this.playground_panel1.Controls.Add(this.ball_pictureBox2);
            this.playground_panel1.Controls.Add(this.racket_pictureBox1);
            this.playground_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground_panel1.Location = new System.Drawing.Point(0, 0);
            this.playground_panel1.Name = "playground_panel1";
            this.playground_panel1.Size = new System.Drawing.Size(747, 450);
            this.playground_panel1.TabIndex = 0;
            // 
            // gameover_label3
            // 
            this.gameover_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover_label3.Location = new System.Drawing.Point(274, 72);
            this.gameover_label3.Name = "gameover_label3";
            this.gameover_label3.Size = new System.Drawing.Size(275, 165);
            this.gameover_label3.TabIndex = 4;
            this.gameover_label3.Text = "Game Over !\r\n\r\nRestart Game - F1\r\n\r\nQuit Game - ESC";
            // 
            // points_label2
            // 
            this.points_label2.AutoSize = true;
            this.points_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_label2.ForeColor = System.Drawing.Color.Red;
            this.points_label2.Location = new System.Drawing.Point(122, 13);
            this.points_label2.Name = "points_label2";
            this.points_label2.Size = new System.Drawing.Size(32, 33);
            this.points_label2.TabIndex = 3;
            this.points_label2.Text = "0";
            this.points_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score_label1
            // 
            this.Score_label1.AutoSize = true;
            this.Score_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Score_label1.Location = new System.Drawing.Point(13, 13);
            this.Score_label1.Name = "Score_label1";
            this.Score_label1.Size = new System.Drawing.Size(123, 33);
            this.Score_label1.TabIndex = 2;
            this.Score_label1.Text = "Score : ";
            // 
            // ball_pictureBox2
            // 
            this.ball_pictureBox2.BackColor = System.Drawing.Color.Red;
            this.ball_pictureBox2.Location = new System.Drawing.Point(354, 297);
            this.ball_pictureBox2.Name = "ball_pictureBox2";
            this.ball_pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.ball_pictureBox2.TabIndex = 1;
            this.ball_pictureBox2.TabStop = false;
            // 
            // racket_pictureBox1
            // 
            this.racket_pictureBox1.BackColor = System.Drawing.Color.Black;
            this.racket_pictureBox1.Location = new System.Drawing.Point(251, 396);
            this.racket_pictureBox1.Name = "racket_pictureBox1";
            this.racket_pictureBox1.Size = new System.Drawing.Size(200, 20);
            this.racket_pictureBox1.TabIndex = 0;
            this.racket_pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.playground_panel1);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameForm_KeyDown);
            this.playground_panel1.ResumeLayout(false);
            this.playground_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground_panel1;
        private System.Windows.Forms.Label gameover_label3;
        private System.Windows.Forms.Label points_label2;
        private System.Windows.Forms.Label Score_label1;
        private System.Windows.Forms.PictureBox ball_pictureBox2;
        private System.Windows.Forms.PictureBox racket_pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

