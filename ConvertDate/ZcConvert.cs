using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDate
{
    public class ZcConvert
    {
        public string MiladiToShamsi(DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            var shamsi = $"{pc.GetYear(dt)}/{pc.GetMonth(dt)}/{pc.GetDayOfMonth(dt)}";
            return shamsi;
        }

        public int Pow(int dig)
        {
            return dig * dig;
        }
    }
}
