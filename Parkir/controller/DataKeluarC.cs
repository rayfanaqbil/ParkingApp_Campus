using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkirApp.view;
namespace ParkirApp.controller
{
    class DataKeluarC
    {
        public static void barcode()
        {
            Camera ca = new Camera();
            ca.Show();
        }
    }
}
