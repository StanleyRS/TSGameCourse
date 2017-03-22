using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSGameCourse
{
    public partial class Form1 : Form
    {
        int _x;
        int _y;
        
        int BallWidth = 50;
        int BallHeight = 50;

        Random rnd = new Random();

        int startPos;

        int speed = 7;
        bool away = true;

        public Form1()
        {
            InitializeComponent();

            _x = rnd.Next(panel1.Width - BallWidth);
            _y = rnd.Next(panel1.Height / 2);

            startPos = _y + BallHeight;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.DeepSkyBlue, _x, _y, BallWidth, BallHeight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer.Start();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (away)
            {
                _y += speed;

                if (_y >= panel1.Height - BallHeight)
                {
                    myTimer.Interval = 65;

                    _y -= speed;

                    away = false;
                }
            }
            else
            {
                _y -= speed;

                if (_y <= startPos)
                {
                    myTimer.Stop();

                    this.Refresh();
                
                }
            }

            this.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
