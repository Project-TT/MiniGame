using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayGame1(object sender, EventArgs e)
        {
            this.Hide();
            Game1 game = new Game1();
            game.ShowDialog();
            this.Show();
        }
    }
}
