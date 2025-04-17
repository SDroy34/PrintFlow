using PrintFlow2.Busisnes.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrintFlow2.Busisnes.VisorFiles
{
    internal class VisorFiles
    {
        public void VisorDoc(string pathCarp, string filter, bool estado, string aliasDoc, int copias,string namePrint)
        {
            StringBuilder sb = new StringBuilder();
            sb.Insert(0, pathCarp);
            var sb2 = new StringBuilder();
            sb2.Append(filter);

            FileSystemWatcher watcher = new FileSystemWatcher
            {
                Path = @$"{sb.ToString()}",
                Filter = $"{sb2.ToString()}",
                NotifyFilter = NotifyFilters.LastWrite & NotifyFilters.FileName,
                EnableRaisingEvents = estado
            };
            watcher.Created += (sender, e) =>
            {
                if (e.Name.StartsWith(aliasDoc) && e.Name.EndsWith(filter))
                {
                    PdfStrategy.PdfInstance.PrintDoc(sb.ToString(), copias,namePrint);
                }
            };

            
        }
    }
}
