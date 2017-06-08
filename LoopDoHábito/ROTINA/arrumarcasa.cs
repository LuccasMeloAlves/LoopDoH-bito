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
    public partial class arrumarcasa : Form
    {
        public arrumarcasa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Casa limpa e organizada para receber visitas será sua recompensa!");
            new recompensa1().Show();
            Hide();
        }
    }
}
