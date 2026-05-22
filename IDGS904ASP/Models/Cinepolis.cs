using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Cinepolis
    {
        public string Nombre { get; set; }
        public int Compradores { get; set; }
        public int Boletos { get; set; }
        public bool Cineco { get; set; }
        public double Total { get; set; }


        public void Calcular()
        {
            double subtotal = Boletos * 12;

            double descuento = 0;

            // validacion max 7 boletos
            if (Boletos > (Compradores * 7))
            {
                Total = -1;
                return;
            }

            // aplicamos descuentos
            if (Boletos > 5)
            {
                descuento = subtotal * 0.15;
            }
            else if (Boletos >= 3)
            {
                descuento = subtotal * 0.10;
            }

            subtotal -= descuento;

            // descuento tarjeta 
            if (Cineco)
            {
                subtotal -= subtotal * 0.10;
            }

            Total = subtotal;
        }
    }
}