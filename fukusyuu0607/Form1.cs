﻿using System;
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
        int vx =-10;
        int vy = -10;

        public Form1()
        {
            InitializeComponent();
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
