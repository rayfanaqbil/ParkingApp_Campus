using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ParkirApp.model
{
    class DataUserM
    {
        public static DataTable GetListData()
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT id_petugas,nama,alamat,no_Hp,Privillage from login", Koneksi.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            return sd;
        }

        public static void HapusData(string idPetugas)
        {
            using (MySqlConnection connection = new MySqlConnection(Koneksi.ConnectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM login WHERE id_petugas = @id_petugas";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id_petugas", idPetugas);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

