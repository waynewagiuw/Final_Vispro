using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace UnklabReservation
{
    public partial class ReservationForm : Form
    {
        public static string jam, date, alasan;
        public static int room;
        public static bool confirm = false;

        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public ReservationForm()
        {
            alamat = "server=localhost; database=student; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NamaBox.Text == "" || NamaBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Nama anda");
                return;
            }
            deletesql(false);
            gridDisplay();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (NamaBox.Text == "" || NamaBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Nama anda");
                return;
            }
            if (AlasanBox.Text == "" || AlasanBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Alasan peminjaman anda");
                return;
            }
            if (DateBox.Text == "" || DateBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Tanggal peminjaman");
                return;
            }
            if (TimeBox.Text == "" || TimeBox.Text == "-- Pilih --")
            {
                MessageBox.Show("Mohon Masukkan Jam peminjaman");
                return;
            }
            updatesql();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            roomBox.Text = UserControlGK.room;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (NamaBox.Text == "" || NamaBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Nama anda");
                return;
            }
            if (AlasanBox.Text == "" || AlasanBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Alasan peminjaman anda");
                return;
            }
            if (DateBox.Text == "" || DateBox.Text == " ")
            {
                MessageBox.Show("Mohon Masukkan Tanggal peminjaman");
                return;
            }
            if (TimeBox.Text == "" || TimeBox.Text == "-- Pilih --")
            {
                MessageBox.Show("Mohon Masukkan Jam peminjaman");
                return;
            }
            insertsql("Request Reservasi telah dikirim");
            gridDisplay();
        }

        private void insertsql(string output)
        {
            room = Convert.ToInt32(roomBox.Text);
            jam = TimeBox.Text;
            date = DateBox.Text;
            alasan = AlasanBox.Text;

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into `reservation gk1` (Room, Tanggal, Jam, Alasan, Nama) values ('{0}', '{1}', '{2}', '{3}', '{4}')", room, date, jam, alasan, NamaBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show(output);
                    ReservationForm_Load(null, null);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nama sudah ada");
            }
        }

        private void updatesql()
        {
            deletesql(true);
            insertsql("Request update Reservasi telah dikirim!");
            gridDisplay();
        }

        private void deletesql(bool update)
        {
            room = Convert.ToInt32(roomBox.Text);
            jam = TimeBox.Text;
            date = DateBox.Text;
            alasan = AlasanBox.Text;
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from `reservation gk1` where Room={0} and Nama='{1}'", room, NamaBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if(update == false)
                {
                    if (res == 1)
                    {
                        MessageBox.Show("Reservasi berhasil dihapus");
                        ReservationForm_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridDisplay()
        {
            try
            {
                koneksi.Open();

                query = string.Format("select * from `reservation gk1` where Nama = '{0}'", NamaBox.Text );
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                gunaDataGridView1.DataSource = ds.Tables[0];
                gunaDataGridView1.Columns[0].Width = 75;
                gunaDataGridView1.Columns[0].HeaderText = "Room";
                gunaDataGridView1.Columns[1].Width = 75;
                gunaDataGridView1.Columns[1].HeaderText = "Tanggal";
                gunaDataGridView1.Columns[2].Width = 75;
                gunaDataGridView1.Columns[2].HeaderText = "Jam";
                gunaDataGridView1.Columns[3].Width = 75;
                gunaDataGridView1.Columns[3].HeaderText = "Alasan";
                gunaDataGridView1.Columns[4].Width = 75;
                gunaDataGridView1.Columns[4].HeaderText = "Nama";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
