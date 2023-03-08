using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Ingresa tu fecha de nacimiento");
            string fechanacimiento = Console.ReadLine();

            DateTime fecha = DateTime.Parse(fechanacimiento);
            int mes = fecha.Month;
            int dia = fecha.Day;

            string signoZodiaco = "";
            if ((mes == 1 && dia >= 1) || (mes == 2 && dia <= 31))
            {
                signoZodiaco = "Tauro";
            }
            
            if ((mes == 2 && dia >= 1) || (mes == 3 && dia <= 28))
            {
                signoZodiaco = "Aries";
            }
            Console.WriteLine("tu signo zodiacal es:" + signoZodiaco);
            Console.ReadLine();
        }
    }
}
