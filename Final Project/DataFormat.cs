using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Final_Project
{
    public class DataFormat
    {
        public String formatCurrency(String currency)
        {
            decimal thecurrency = decimal.Parse(currency);
            return formatCurrency(thecurrency);
        }
        public String formatCurrency(decimal thecurrency)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            return string.Format(cultureInfo, "{0:C}", thecurrency);
        }
    }
}
