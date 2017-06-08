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
    public partial class treino : Form
    {
        public treino()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Físico mais bonito e principalmente uma saúde melhor, será sua recompensa  !");
            new recompensa2().Show();
            Hide();
        }
    }
}
