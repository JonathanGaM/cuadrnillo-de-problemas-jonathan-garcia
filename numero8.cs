using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanzaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diastrabajado, suelsemana, tsueldosemanal;

            Console.WriteLine("Ingresa el sueldo semanal");
            suelsemana = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa los dias trabajados");
            diastrabajado = Double.Parse(Console.ReadLine());
            tsueldosemanal = suelsemana / 6 * diastrabajado;
            Console.WriteLine("El total del sueldo semanal es: " + tsueldosemanal);
        }
    }
}

