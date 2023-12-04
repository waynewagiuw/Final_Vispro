using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnklabReservation
{
    internal class koneksi
    {
        string conectionstring = "Server=localhost;Database=student;Uid=myUsername;Pwd=;";
        MySql.Data.MySqlClient.MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySql.Data.MySqlClient.MySqlConnection(conectionstring);
            kon.Open();

        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }
    }
}
