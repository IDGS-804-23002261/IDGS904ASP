using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Resistencia
    {
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public string Tolerancia { get; set; }

        public double Valor { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }


        public void Calcular()
        {
            int banda1 = ObtenerNumero(Color1);
            int banda2 = ObtenerNumero(Color2);

            int multiplicador = ObtenerMultiplicador(Color3);

            Valor = ((banda1 * 10) + banda2) * multiplicador;

            double tolerancia = 0;

            if (Tolerancia == "Oro")
            {
                tolerancia = 0.05;
            }
            else
            {
                tolerancia = 0.10;
            }

            Minimo = Valor - (Valor * tolerancia);
            Maximo = Valor + (Valor * tolerancia);
        }


        public int ObtenerNumero(string color)
        {
            switch (color)
            {
                case "Negro": return 0;
                case "Cafe": return 1;
                case "Rojo": return 2;
                case "Naranja": return 3;
                case "Amarillo": return 4;
                case "Verde": return 5;
                case "Azul": return 6;
                case "Violeta": return 7;
                case "Gris": return 8;
                case "Blanco": return 9;
            }

            return 0;
        }


        public int ObtenerMultiplicador(string color)
        {
            switch (color)
            {
                case "Negro": return 1;
                case "Cafe": return 10;
                case "Rojo": return 100;
                case "Naranja": return 1000;
                case "Amarillo": return 10000;
                case "Verde": return 100000;
                case "Azul": return 1000000;
                case "Violeta": return 10000000;
                case "Gris": return 100000000;
                case "Blanco": return 1000000000;
            }

            return 1;

        }

        public string ObtenerColorCss(string color)
        {
            switch (color)
            {
                case "Negro": return "black";
                case "Cafe": return "brown";
                case "Rojo": return "red";
                case "Naranja": return "orange";
                case "Amarillo": return "yellow";
                case "Verde": return "green";
                case "Azul": return "blue";
                case "Violeta": return "purple";
                case "Gris": return "gray";
                case "Blanco": return "white";
            }

            return "white";
        }
    }
}