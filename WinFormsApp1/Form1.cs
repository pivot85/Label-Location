﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(92,50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(170,63);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(92, 112);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(50, 63);
        }
    }
}
