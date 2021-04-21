using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinpon_Oyunu
{
    public partial class gameForm : Form
    {
        public int speed_left = 3;
        public int speed_top = 3;
        public int point = 0;

        

        public gameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket_pictureBox1.Top = playground_panel1.Bottom - (playground_panel1.Bottom / 10);   // Racketi ortalama yaptım
            racket_pictureBox1.Left = playground_panel1.Bottom - (playground_panel1.Bottom / 5);

            gameover_label3.Left = (playground_panel1.Width / 2) - (gameover_label3.Width / 2);    // gameover labeli ortaladım
            gameover_label3.Top = (playground_panel1.Height / 2) - (gameover_label3.Height / 2);
            gameover_label3.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket_pictureBox1.Left = Cursor.Position.X - (racket_pictureBox1.Width / 2);
            ball_pictureBox2.Left += speed_left;
            ball_pictureBox2.Top += speed_top;

            

            if (ball_pictureBox2.Left <= playground_panel1.Left)  // Duvarlara çarpma kod satırı
            {
                speed_left = -speed_left;
            }
            if (ball_pictureBox2.Right >= playground_panel1.Right)
            {
                speed_left = -speed_left;
            }
            if (ball_pictureBox2.Top <= playground_panel1.Top)
            {
                speed_top = -speed_top;
            }
            if (ball_pictureBox2.Bottom >= playground_panel1.Bottom)
            {
                gameover_label3.Visible = true;
                timer1.Enabled = false;
            }

            


            if (ball_pictureBox2.Bottom >= racket_pictureBox1.Top &&
                ball_pictureBox2.Bottom <= racket_pictureBox1.Bottom &&            
                ball_pictureBox2.Left >= racket_pictureBox1.Left &&
                ball_pictureBox2.Right <= racket_pictureBox1.Right)  // Raket top oyunlarında çarpma kullanımı
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top;

                point+= 1;         // top rakete çarptğında point artışı sağlama
                points_label2.Text = point.ToString();

                Random r=new Random();       // Top rakete çarptığında panelin rengini değiştirme
                playground_panel1.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));

            }
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode==Keys.F1)
            {
                ball_pictureBox2.Top = 90;    // Oyunu kaybedersek oluşacak durumlar
                ball_pictureBox2.Top = 90;
                speed_left = 1;
                //points_label2.Text = "0";
                timer1.Enabled = true;
                gameover_label3.Visible = false;
                playground_panel1.BackColor=Color.White;
            }
        }
    }
}
