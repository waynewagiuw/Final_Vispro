using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnklabReservation
{
    public partial class ga : Form
    {
        public ga()
        {
            InitializeComponent();
        }

        private void kembali3_Click(object sender, EventArgs e)
        {
            Mainmenu Main = new Mainmenu();
            Main.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Mainmenu Main = new Mainmenu();
            Main.Show();
        }
    }
}
