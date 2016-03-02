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
      
              
        public RunGame()
        {

            InitializeComponent();

        }

        private void RunGame_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            this.Refresh();
            Thread.Sleep(1000);

        }
        public void ComputerTurn()
        {
            Random RandomColors = new Random();
            RandomColors.Next(0, 4);
            simonColors = RandomColors.Next(0, 4);
            Form1.pattern.Add(simonColors);


            listNum = Form1.pattern.Count;
            for (int i = 0; i < listNum; i++)
            {
                if (i == 0)
                {
                    greenButton.BackColor = Color.PaleGreen;
                }
                else if (i == 1)
                {
                    redButton.BackColor = Color.LightCoral;

                }
                else if (i == 2)
                {
                    blueButton.BackColor = Color.LightBlue;
                }
                else if (i == 3)
                {
                    yellowButton.BackColor = Color.LightYellow;
                }
            }
            guessIndex = 0;
        }  

        private void greenButton_Click(object sender, EventArgs e)
        {
            
        }

        private void redButton_Click(object sender, EventArgs e)
        {

        }
    }
}

