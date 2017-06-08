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
    public partial class recompensa1 : Form
    {
        public recompensa1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Muito bem! o que acha de implementar mais rotinas?");
            new deixa().Show();
            Hide();
        }
    }
}
