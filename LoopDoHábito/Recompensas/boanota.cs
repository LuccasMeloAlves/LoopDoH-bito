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
    public partial class boanota : Form
    {
        public boanota()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            new deixa().Show();
            Hide();
            DialogResult dialogResult = MessageBox.Show("Muito bem! o que acha de implementar mais rotinas?");

        }
    }
}
