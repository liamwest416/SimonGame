using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimonGame
{
    public partial class RunGame : UserControl
    {
        int simonColors;
        int listNum;
        int guessIndex;
        Random RandomColors = new Random();
        int guess;

        public RunGame()
        {

            InitializeComponent();

        }

        private void RunGame_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            this.Refresh();
            Thread.Sleep(1000);
            ComputerTurn();

        }
        public void ComputerTurn()
        {
            Refresh();
            Thread.Sleep(2000);
            guess = 0;
            simonColors = RandomColors.Next(0, 4);
            Form1.pattern.Add(simonColors);


            listNum = Form1.pattern.Count;
            for (int i = 0; i < listNum; i++)
            {
                if (Form1.pattern[i] == 0)
                {
                    guess = 0;
                    greenButton.BackColor = Color.PaleGreen;
                    Refresh();
                    Thread.Sleep(500);
                    greenButton.BackColor = Color.Lime;
               
                }
                else if (Form1.pattern[i] == 1)
                {
                    guess = 1;
                    redButton.BackColor = Color.LightCoral;
                    Refresh();
                    Thread.Sleep(500);
                    redButton.BackColor = Color.Red;
                   

                }
                else if (Form1.pattern[i] == 2)
                {
                    guess = 2;
                    blueButton.BackColor = Color.LightBlue;
                    Refresh();
                    Thread.Sleep(500);
                    blueButton.BackColor = Color.Blue;
                   
                }
                else if (Form1.pattern[i] == 3)
                {
                    guess = 3;
                    yellowButton.BackColor = Color.LightYellow;
                    Refresh();
                    Thread.Sleep(500);
                    yellowButton.BackColor = Color.Yellow;
                    
                }
                Refresh();
                Thread.Sleep(1500);
            }
            guessIndex = 0;
        }  

        private void greenButton_Click(object sender, EventArgs e)
        {
            
            if (Form1.pattern[guess] == 0)
            {
                ComputerTurn();
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            
            if (Form1.pattern[guess] == 1)
            {
                ComputerTurn();
            }
        }
        private void blueButton_Click(object sender, EventArgs e)
        {
            guess = 2;
            if (Form1.pattern[guess] == 2)
            {
                ComputerTurn();
            }
        }
        private void yellowButton_Click(object sender, EventArgs e)
        {
            guess = 3;
            if (Form1.pattern[guess] == 3)
            {
                ComputerTurn();
            }
        }
    }
}

