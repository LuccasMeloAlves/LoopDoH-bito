using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopDoHábito
{
    public partial class deixa : Form
    {
        public deixa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new treino().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new arrumarcasa().Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new estudando().Show();
            Hide();

        }
    }
}
