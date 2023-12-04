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
    public partial class UserControlGK : UserControl
    {
        public static string room;

        public UserControlGK()
        {
            InitializeComponent();
        }


        public void Desc_Click(object sender, EventArgs e)
        {
            room = RoomName.Text;
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
        }

        public void UserControlGK_Load(object sender, EventArgs e)
        {

        }

        public void Description(string Desc)
        {
            DescGk.Text = Desc;
        }

        public void Room(string room)
        {
            RoomName.Text = room;
        }
    }
}
