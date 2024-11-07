using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Administrativo : IEmpleado
    {
        public string nombreEmpleado { get; set; }
        public string Nombre() { return nombreEmpleado; }

        public double Sueldo() { return 1500; }
    }
}
