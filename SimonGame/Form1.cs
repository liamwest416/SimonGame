﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// created by:

namespace SimonGame
{
    public partial class Form1 : Form
    {

        public static List<int> pattern = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            simonPicture.Visible = false;
            RunGame rg = new RunGame();
            this.Controls.Add(rg);

            






        }
    }
}
