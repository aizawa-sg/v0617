﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0617
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int vx=-10;
        int vy=-10;


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = vx;
            label1.Left = vy;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
