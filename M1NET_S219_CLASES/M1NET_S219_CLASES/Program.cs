using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Console.WriteLine("Ingrese nombre: ");
            empleado.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido: ");
            empleado.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo");
            empleado.sueldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Edad: ");
            empleado.edad = int.Parse(Console.ReadLine());

            empleado.ImprimirEmpleado();
            

        }
    }
}
