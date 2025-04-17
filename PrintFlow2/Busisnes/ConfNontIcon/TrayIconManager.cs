using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlow2.Busisnes.ConfNontIcon
{
    public class TrayIconManager
    {
        private readonly static TrayIconManager _iconM = new TrayIconManager();

        private static Form _ventanaIcono;
        private static UVentanaIcono _controlIcono;
        private static NotifyIcon _icono;
        public static TrayIconManager IconM {  get { return _iconM; } }

        private TrayIconManager() { }

        public void Initialize(NotifyIcon icon)
        {
            _icono = icon;
            _icono.Click += Icono_Click;

            
            string imagenPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IconoPF.ico");
            _icono.Icon = new Icon(@"C:\Users\asgar\source\repos\PrintFlow\PrintFlow2\IconosDeAplición\IconoPF.ico");
            _icono.Text = "Print flow";
            _icono.Visible = true;
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            var args = e as MouseEventArgs;
            if (args != null && args.Button == MouseButtons.Left)
            {
                MostrarVentanaIcono();
            }
        }

        private  void MostrarVentanaIcono()
        {
            if (_ventanaIcono == null || _ventanaIcono.IsDisposed)
            {
                _ventanaIcono = new Form
                {
                    FormBorderStyle = FormBorderStyle.None,
                    ShowInTaskbar = false,
                    StartPosition = FormStartPosition.Manual,
                    Size = new Size(300, 400) // Ajusta según tus necesidades
                };

                _controlIcono = new UVentanaIcono();
                _ventanaIcono.Controls.Add(_controlIcono);

                // Posicionar la ventana cerca del icono
                _ventanaIcono.Location = new Point(
                    Cursor.Position.X - _ventanaIcono.Width / 2,
                    Cursor.Position.Y - _ventanaIcono.Height);
            }

            if (!_ventanaIcono.Visible)
            {
                _ventanaIcono.Show();
            }
            else
            {
                _ventanaIcono.Hide();
            }
        }

        public void DisposeResources()
        {
            if (_ventanaIcono != null)
            {
                _ventanaIcono.Dispose();
                _ventanaIcono = null;
            }

            if (_icono != null)
            {
                _icono.Dispose();
                _icono = null;
            }
        }
    }
}
