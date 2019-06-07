using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyuu0607
{
    public partial class Form1 : Form
    {
        //疑似乱数
        //ランダムのシード（種）を指定して初期化したら、
        //それを使い続ける.
        private static Random rand = new Random();
        int vx =rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int time = 100 * 5;

        public Form1()
        {
            InitializeComponent();
            //いかに、label1.Leftとlabel1.Topの座標をランダムで求めよう
            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Left += vx;
            label1.Top += vy;

            Point p = PointToClient(MousePosition);

            if ((p.X>=label1.Left)
                &&(p.X<label1.Right)
                &&(p.Y>=label1.Top)
                &&(p.Y<label1.Bottom)
                )
            {
                timer1.Enabled = false;
            }
         label1.Left += vx;
            label1.Top += vy;
            if (label1.Left<=0)
            {
                vx =-vx;
            }
            if (label1.Top<=0)
            {
                vy =-vy;
            }
            if (label1.Left>=ClientSize.Width-label1.Width)
            {
                vx=-Math.Abs(-vx);
            }
            if (label1.Top>=ClientSize.Height-label1.Height)
            {
                vy = -Math.Abs(-vy);
            }
        }
    }
}
