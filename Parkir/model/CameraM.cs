using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace ParkirApp.model
{
    class CameraM
    { 
            public static DataTable keluar(string decoded)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM db_parkir.parkir_masuk where no_masuk='" + decoded + "'", Koneksi.ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        public static void update(string decoded)
        {
            string updateQuery = @"UPDATE parkir_masuk AS a
                                  JOIN biaya_parkir AS b ON a.id_kendaraan = b.id_kendaraan
                                  SET a.tanggal_keluar = CURDATE(), a.jam_keluar = CURTIME(), a.Tarif = b.Tarif
                                  WHERE a.no_masuk ='" + decoded + "'";
            Koneksi.ExecuteMyQuery(updateQuery);
        }
    }
}

