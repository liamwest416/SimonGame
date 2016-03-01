using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class RunGame : UserControl
    {
      
        public RunGame()
        {

            InitializeComponent();

        }

        private void RunGame_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            this.Refresh();
            thread.sleep();

        }
    }
}

