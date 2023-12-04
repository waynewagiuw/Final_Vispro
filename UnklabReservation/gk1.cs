using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnklabReservation
{
    public partial class gk1 : Form
    {
        public gk1()
        {
            InitializeComponent();
        }

        private void gk1_Load(object sender, EventArgs e)
        {
            this.ContainerGK.Hide();
            this.ContainerGK.BackColor = Color.Transparent;
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            Mainmenu Main = new Mainmenu();
            Main.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lantai5_Click(object sender, EventArgs e)
        {
            this.ContainerGK.Controls.Clear();
            this.ContainerGK.Show();

            UserControlGK GK501 = new UserControlGK();
            GK501.Description("");
            GK501.Room("501");
            this.ContainerGK.Controls.Add(GK501);

            UserControlGK GK502 = new UserControlGK();
            GK502.Description("");
            GK502.Room("502");
            this.ContainerGK.Controls.Add(GK502);

            UserControlGK GK503 = new UserControlGK();
            GK503.Description("");
            GK503.Room("503");
            this.ContainerGK.Controls.Add(GK503);

            UserControlGK GK504 = new UserControlGK();
            GK504.Description("");
            GK504.Room("504");
            this.ContainerGK.Controls.Add(GK504);

            UserControlGK GK505 = new UserControlGK();
            GK505.Description("");
            GK505.Room("505");
            this.ContainerGK.Controls.Add(GK505);

            UserControlGK GK506 = new UserControlGK();
            GK506.Description("");
            GK506.Room("506");
            this.ContainerGK.Controls.Add(GK506);
        }

        private void lantai4_Click(object sender, EventArgs e)
        {
            this.ContainerGK.Controls.Clear();
            this.ContainerGK.Show();

            UserControlGK GK401 = new UserControlGK();
            GK401.Description("");
            GK401.Room("401");
            this.ContainerGK.Controls.Add(GK401);

            UserControlGK GK402 = new UserControlGK();
            GK402.Description("");
            GK402.Room("402");
            this.ContainerGK.Controls.Add(GK402);

            UserControlGK GK403 = new UserControlGK();
            GK403.Description("");
            GK403.Room("403");
            this.ContainerGK.Controls.Add(GK403);

            UserControlGK GK404 = new UserControlGK();
            GK404.Description("");
            GK404.Room("404");
            this.ContainerGK.Controls.Add(GK404);

            UserControlGK GK405 = new UserControlGK();
            GK405.Description("");
            GK405.Room("405");
            this.ContainerGK.Controls.Add(GK405);

            UserControlGK GK406 = new UserControlGK();
            GK406.Description("");
            GK406.Room("406");
            this.ContainerGK.Controls.Add(GK406);
        }

        private void lantai3_Click(object sender, EventArgs e)
        {
            this.ContainerGK.Controls.Clear();
            this.ContainerGK.Show();

            UserControlGK GK301 = new UserControlGK();
            GK301.Description("");
            GK301.Room("301");
            this.ContainerGK.Controls.Add(GK301);

            UserControlGK GK302 = new UserControlGK();
            GK302.Description("");
            GK302.Room("302");
            this.ContainerGK.Controls.Add(GK302);

            UserControlGK GK303 = new UserControlGK();
            GK303.Description("");
            GK303.Room("303");
            this.ContainerGK.Controls.Add(GK303);

            UserControlGK GK304 = new UserControlGK();
            GK304.Description("");
            GK304.Room("304");
            this.ContainerGK.Controls.Add(GK304);

            UserControlGK GK305 = new UserControlGK();
            GK305.Description("");
            GK305.Room("305");
            this.ContainerGK.Controls.Add(GK305);

            UserControlGK GK306 = new UserControlGK();
            GK306.Description("");
            GK306.Room("306");
            this.ContainerGK.Controls.Add(GK306);

            UserControlGK GK307 = new UserControlGK();
            GK307.Description("");
            GK307.Room("307");
            this.ContainerGK.Controls.Add(GK307);

            UserControlGK GK308 = new UserControlGK();
            GK308.Description("");
            GK308.Room("308");
            this.ContainerGK.Controls.Add(GK308);
        }

        private void lantai2_Click(object sender, EventArgs e)
        {
            this.ContainerGK.Controls.Clear();
            this.ContainerGK.Show();

            UserControlGK GK201 = new UserControlGK();
            GK201.Description("");
            GK201.Room("201");
            this.ContainerGK.Controls.Add(GK201);

            UserControlGK GK202 = new UserControlGK();
            GK202.Description("");
            GK202.Room("202");
            this.ContainerGK.Controls.Add(GK202);

            UserControlGK GK203 = new UserControlGK();
            GK203.Description("");
            GK203.Room("203");
            this.ContainerGK.Controls.Add(GK203);

            UserControlGK GK204 = new UserControlGK();
            GK204.Description("");
            GK204.Room("204");
            this.ContainerGK.Controls.Add(GK204);

            UserControlGK GK205 = new UserControlGK();
            GK205.Description("");
            GK205.Room("205");
            this.ContainerGK.Controls.Add(GK205);

            UserControlGK GK206 = new UserControlGK();
            GK206.Description("");
            GK206.Room("206");
            this.ContainerGK.Controls.Add(GK206);

            UserControlGK GK207 = new UserControlGK();
            GK207.Description("");
            GK207.Room("207");
            this.ContainerGK.Controls.Add(GK207);

            UserControlGK GK208 = new UserControlGK();
            GK208.Description("");
            GK208.Room("208");
            this.ContainerGK.Controls.Add(GK208);
        }

        private void lantai1_Click(object sender, EventArgs e)
        {
            this.ContainerGK.Controls.Clear();
            this.ContainerGK.Show();

            UserControlGK GK101 = new UserControlGK();
            GK101.Description("Kapasitas : 70");
            GK101.Room("101");
            this.ContainerGK.Controls.Add(GK101);

            UserControlGK GK102 = new UserControlGK();
            GK102.Description("Kapasitas : 70");
            GK102.Room("102");
            this.ContainerGK.Controls.Add(GK102);

            UserControlGK GK103 = new UserControlGK();
            GK103.Description("Kapasitas : 40");
            GK103.Room("103");
            this.ContainerGK.Controls.Add(GK103);

            UserControlGK GK104 = new UserControlGK();
            GK104.Description("Kapasitas : 40");
            GK104.Room("104");
            this.ContainerGK.Controls.Add(GK104);

            UserControlGK GK105 = new UserControlGK();
            GK105.Description("Kapasitas : 40");
            GK105.Room("105");
            this.ContainerGK.Controls.Add(GK105);

            UserControlGK GK106 = new UserControlGK();
            GK106.Description("Kapasitas : 40");
            GK106.Room("106");
            this.ContainerGK.Controls.Add(GK106);

            UserControlGK GK107 = new UserControlGK();
            GK107.Description("Kapasitas : 40");
            GK107.Room("107");
            this.ContainerGK.Controls.Add(GK107);

            UserControlGK GK108 = new UserControlGK();
            GK108.Description("Kapasitas : 40");
            GK108.Room("108");
            this.ContainerGK.Controls.Add(GK108);
        }


        private void ContainerGK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Mainmenu Main = new Mainmenu();
            Main.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
