using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFlow2.Busisnes.Services
{
    public class ShowFolderDialog
    {
        public static string PachtFolder()
        {
            string rutaCarpeta;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            rutaCarpeta = folderBrowserDialog.SelectedPath;
             return rutaCarpeta;

        }
    }
}
