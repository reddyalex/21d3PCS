using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgW9
{
    public class LibraryInvoice
    {

        public static void formatPhoneNumber(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType() == typeof(String))
            {
                String v = e.Value.ToString();
                if (v.Length == 10)
                {
                    e.Value = v.Substring(0, 3) + "-" +
                              v.Substring(3, 3) + "-" +
                              v.Substring(6, 4);
                }
            }

        }


        public static void unFormatPhoneNumber(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType() == typeof(String))
            {
                string v = e.Value.ToString();
                e.Value = v.Replace("-", "");

            }
        }

    }
}
