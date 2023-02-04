using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Entidades;
using Tarea1.Negocios;

namespace Tarea1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Datos datos = new Datos();
            ClsDatos clsDatos = new ClsDatos();

            Console.WriteLine("Ingresa el primer numero");
            datos.Numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            datos.Numero2 = Convert.ToInt32(Console.ReadLine());

            String result = clsDatos.Validar(datos);

            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
