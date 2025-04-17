using PrintFlow2.Busisnes.ConfNontIcon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFlow2
{
    
    public partial class FInicio : Form
    {
        private TrayIconManager _trayIconManager;
        public FInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FCreatePrintFlow fCreatePrintFlow = new FCreatePrintFlow();
                this.Hide();
                fCreatePrintFlow.ShowDialog();
                this.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"{ex}");
                this.Hide();
                this.Close();
                this.Activate();

            }
        }

        private void BtnInicioPrintFlow_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            //this.Hide();
            //NotifyIcon notify = new NotifyIcon();
            //FoncionesNotifyIcon.NotifiIcon(notify);

            }catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
                TrayIconManager.IconM.DisposeResources();
                Application.Exit();
            }
            
            
        }
    }
}
