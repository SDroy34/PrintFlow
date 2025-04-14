using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFlow2.Busisnes.ContainerDepen
{
    internal interface IServiceContainerBd
    {
         static IServiceContainerBd _Service { get; private set; }
    }
}
