using Practica3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica3.Services
{
    public class CalculandoPrestamo
    {

        private List<Prestamo> _tablaDelPrestamo;
        private double _resultado;
        public CalculandoPrestamo()
        {
            _tablaDelPrestamo = new List<Prestamo>();
        }
        public double Cuotas(double montoDelPrestamo, int tiempo)
        {
            _resultado = montoDelPrestamo / tiempo;
            return _resultado;
        }

        public double Interes(double montoDelPrestamo, double interes, int tiempo) 
        {
            _resultado = (((montoDelPrestamo * interes) / 100) * tiempo) / tiempo;
            return _resultado;
        }

        public double DescuentoAlCapital(double capital, int tiempo) 
        {
            _resultado = capital / tiempo;
            return _resultado;
        }

        public List<Prestamo> PrestamoCalculado(double montoDelPrestamo, double interes, int tiempo) 
        {
            int count = 0;
            for (int i = 1; i < tiempo; i++)
            {
                //...
                _tablaDelPrestamo.Add(
                    new Prestamo()
                    {
                        Cuota = Cuotas(montoDelPrestamo, tiempo) + Interes(montoDelPrestamo, interes, tiempo),
                        Capital = DescuentoAlCapital(montoDelPrestamo, tiempo),
                        Interes = Interes(montoDelPrestamo, interes, tiempo),
                        Mes = (count > i) ? DateTime.Today.Month + i : DateTime.Today.Month
                    });
                count++;
            }
            return _tablaDelPrestamo;
        }
    }
}
