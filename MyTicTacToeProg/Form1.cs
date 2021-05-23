using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTicTacToeProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte turn = 0;

        private void btn_click(object sender, EventArgs e)
        {
            Button click = (Button)sender;
            if (turn % 2 == 0)
            {
                click.Text = "X";
                click.Enabled = false;
                click.BackColor = Color.LightGreen;
                turn += 1;
            }
            else
            {
                click.Text = "O";
                click.Enabled = false;
                click.BackColor = Color.LightPink;
                turn += 1;
            }
        }
    }
}
