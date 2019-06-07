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
        int vx =-10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (vx>0)
            {
                vx = Math.Abs(vx);
            }
            if (vy>0)
            {
                vy = Math.Abs(vy);
            }

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }
    }
}
