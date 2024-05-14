using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkirApp.view;
using System.Windows.Forms;

namespace Parkir.controller
{
    internal class AboutC
    {
        public static void tutup()
        {
            Form.ActiveForm.Hide();
            var ss = new ParkirApp.view.Parkir();
            ss.Closed += (s, args) => Form.ActiveForm.Close();
            ss.Close();
        }
    }
}
