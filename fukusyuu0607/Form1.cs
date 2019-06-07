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
        //疑似乱数
        //ランダムのシード（種）を指定して初期化したら、
        //それを使い続ける.
        private static Random rand = new Random();
       
        int time = 100 * 5;
        
        int[] velx = new int[3];
        int[] vely = new int[3];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3;i++ )
            {
                velx[i] = rand.Next(-10, 11);
                vely[i] = rand.Next(-10, 11);
            }
            
               
            
            //いかに、label1.Leftとlabel1.Topの座標をランダムで求めよう
            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);

            label2.Left = rand.Next(ClientSize.Width - label2.Width);
            label2.Top = rand.Next(ClientSize.Height - label2.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Left += velx[0];
            label1.Top += vely[0];
        
            label2.Left += velx[1];
            label2.Top += vely[1];
            
            label3.Left += velx[2];
            label3.Top += vely[2];
            Point p = PointToClient(MousePosition);
            Point o = PointToClient(MousePosition);
            Point u = PointToClient(MousePosition);

            if ((p.X>=label1.Left)
                &&(p.X<label1.Right)
                &&(p.Y>=label1.Top)
                &&(p.Y<label1.Bottom)
                )
                 {
                timer1.Enabled = false;
            }

                if ((o.X >= label2.Left)
               && (o.X < label2.Right)
               && (o.Y >= label2.Top)
               && (o.Y < label2.Bottom)
               )
                {
                    timer1.Enabled = false;
                }

                    if ((p.X >= label3.Left)
               && (u.X < label3.Right)
               && (u.Y >= label3.Top)
               && (u.Y < label3.Bottom)
               )
            {
                timer1.Enabled = false;
            }

         label1.Left += velx[0];
            label1.Top += velx[0];
            if (label1.Left<=0)
            {
                velx[0] =-velx[0];
            }
            if (label1.Top<=0)
            {
                vely[0] =-vely[0];
            }
            if (label1.Left>=ClientSize.Width-label1.Width)
            {
                velx[0]=-Math.Abs(-velx[0]);
            }
            if (label1.Top>=ClientSize.Height-label1.Height)
            {
                vely[0] = -Math.Abs(-vely[0]);
            }

            label2.Left += velx[1];
            label2.Top += velx[1];
            if (label2.Left <= 0)
            {
                velx[1] = -velx[1];
            }
            if (label2.Top <= 0)
            {
                vely[1] = -vely[1];
            }
            if (label2.Left >= ClientSize.Width - label2.Width)
            {
                velx[1] = -Math.Abs(-velx[1]);
            }
            if (label2.Top >= ClientSize.Height - label2.Height)
            {
                vely[1] = -Math.Abs(-vely[1]);
            }

            label3.Left += velx[2];
            label3.Top += velx[2];
            if (label3.Left <= 0)
            {
                velx[2] = -velx[2];
            }
            if (label3.Top <= 0)
            {
                vely[2] = -vely[2];
            }
            if (label3.Left >= ClientSize.Width - label3.Width)
            {
                velx[2] = -Math.Abs(-velx[2]);
            }
            if (label3.Top >= ClientSize.Height - label3.Height)
            {
                vely[2] = -Math.Abs(-vely[2]);
            }
        }
    }
}
