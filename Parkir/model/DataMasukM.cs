using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace ParkirApp.model
{
    class DataMasukM
    { 
        public static void simpan(string x,string y)
        {
           
            if (!string.IsNullOrEmpty(y))
            {
                string insertQuery = "INSERT INTO parkir_masuk(`no_kendaraan`, `id_kendaraan`, `tanggal_Masuk`, `jam_Masuk`) VALUES ('" + x + "','" + int.Parse(y) + "', CURDATE(), curtime());";
                Koneksi.ExecuteMyQuery(insertQuery);
            }
             
        }
        public static int Nomasuk()
        {
            int result = 0;

            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT no_masuk FROM parkir_masuk ORDER BY no_masuk DESC LIMIT 1", Koneksi.ConnectionString );
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            if(sd.Rows.Count > 0)
            {
                result = int.Parse(sd.Rows[0]["no_masuk"].ToString());
                
            }
            return result;
        }
        public static string Nokendaraan()
        {
            string result = "0";
      

            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT no_kendaraan FROM parkir_masuk ORDER BY no_masuk DESC LIMIT 1", Koneksi.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            if (sd.Rows.Count > 0)
            {
                result = sd.Rows[0]["no_kendaraan"].ToString();
        
            }
            return result;
        }
    }
}
