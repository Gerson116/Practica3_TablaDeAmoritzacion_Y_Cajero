using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica3.Models;
using Practica3.Services;

namespace Practica3.Pages 
{
    public class TablaDePrestamosModel : PageModel
    {
        public Prestamo prestamo = new Prestamo();
        public List<Prestamo> tablaDelPrestamo = new List<Prestamo>();
        private CalculandoPrestamo calculandoPrestamo = new CalculandoPrestamo();
        private CalculandoPrestamo _calculadora = new CalculandoPrestamo();

        public TablaDePrestamosModel()
        {
            //....
        }
        public void OnGet(double montoDelPrestamoSolicitado, double interes, int tiempo)
        {
            //...
            this.tablaDelPrestamo = _calculadora.PrestamoCalculado(montoDelPrestamo: montoDelPrestamoSolicitado,
                interes: interes, tiempo: tiempo);
        }
    }
}
