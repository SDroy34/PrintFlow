using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlow2.Busisnes.Services
{
    internal class ConfiguracionesDeBox
    {
        public static void AllBoxConf(ComboBox Cmbox, List<string> data)
        {
            Cmbox.DataSource = data;
            Cmbox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static void AllBoxConf(TextBox txb, int maxLength)
        {
            txb.MaxLength = maxLength;
        }
        public static void AllBoxConf(TextBox txb, int maxLength, string text)
        {
            txb.MaxLength = maxLength;
            txb.PlaceholderText = text;
        }

    }
}
