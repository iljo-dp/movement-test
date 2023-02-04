using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace racing_game_smooth_movement
{
    public partial class Form1 : Form
    {

        bool goleft, goright;
        int snelheid = 5;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void beweegmiddelijn(int snelheid)
        {
            PictureBox[] pictures = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7 };

            foreach (PictureBox pic in pictures)
            {
                if (pic.Top >= 700)
                {
                    pic.Top = 0;
                }
                else
                {
                    pic.Top += snelheid;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Up && auto.Top > 35)
            {
                auto.Top -= snelheid + 1;
            }
            else if (e.KeyCode == Keys.Down && auto.Bottom < 700)
            {
                auto.Top += snelheid + 1;
            }
        }

        private void gameTimerEvent_Tick(object sender, EventArgs e)
        {
 

            beweegmiddelijn(snelheid);

            if (goleft == true && auto.Left > 10)
                {
                    auto.Left -= snelheid;
                }
                if (goright == true && auto.Left < 415)
                {
                    auto.Left += snelheid;
                }            
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

    }
}
