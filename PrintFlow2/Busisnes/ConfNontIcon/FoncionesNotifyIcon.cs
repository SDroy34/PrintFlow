using BdConnetion.Connection;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PrintFlow2.Busisnes.ConfNontIcon
{
    internal class FoncionesNotifyIcon
    {

        public static void NotifiIcon(NotifyIcon icon)
        {

            icon.Text = "PrintFlow";
            icon.Visible = true;
            icon.Icon = new Icon("");
            icon.MouseClick += (sender, e) =>
            {
                
                ClicDer(icon);

                
            };
        }
        public static void ClicDer(NotifyIcon icon)
        {
            icon.Click += (sender, e) =>
            {
                 Form form = new Form();
                UVentanaIcono v = new UVentanaIcono();
                form.Controls.Add(v);
                form.ShowDialog();
            };
        }
    }
}
