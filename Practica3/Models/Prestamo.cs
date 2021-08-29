using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica3.Models
{
    public class Prestamo
    {
        public double Monto { get; set; }
        public double Cuota { get; set; }
        public double Capital { get; set; }
        public double Interes { get; set; }
        public int Tiempo {  get; set; }
        public int Mes { get; set; }
    }
}
