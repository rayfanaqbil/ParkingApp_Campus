﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ParkirApp.model
{
    class DataParkirM
    {
        public static int TotalTarif()
        {
            int result = 0;

            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT sum(tarif) as total_tarif FROM parkir_masuk WHERE tanggal_keluar is not null",Koneksi.ConnectionString );
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            if(sd.Rows.Count > 0)
            {
                result = int.Parse(sd.Rows[0]["total_tarif"].ToString());
            }
            return result;
        }
        public static DataTable GetListData()
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * from parkir_masuk where tanggal_keluar is not null", Koneksi.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            return sd;
        }

    }
}
