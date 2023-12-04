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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void exit_CheckedChanged(object sender, EventArgs e)
        {
            Login Main = new Login();
            Main.Show();
            this.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
           Login Main = new Login();
           Main.Show();
           this.Hide();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            gk1 Main = new gk1();
            Main.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gk2 Main = new gk2();
            Main.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            gk3 Main = new gk3();
            Main.Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ga Main = new ga();
            Main.Show();
            this.Hide();
        }

        private void buttonfb_Click(object sender, EventArgs e)
        {

        }

        private void buttonig_Click(object sender, EventArgs e)
        {

        }

        private void buttonfb_MouseHover(object sender, EventArgs e)
        {
            this.buttonfb.BackColor = Color.Blue;
        }
    }
}
