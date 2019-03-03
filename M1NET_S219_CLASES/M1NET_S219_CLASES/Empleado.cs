using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_CLASES
{
    class Empleado
    {
        public string nombre;
        public string apellido;
        public decimal sueldo;
        public int edad;

        public void ImprimirEmpleado()
        {        
            Console.WriteLine("Informacion del empleado");
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Apellido: "+apellido);
            Console.WriteLine("Sueldo: "+sueldo);
            Console.WriteLine("Edad: "+edad);

            Console.WriteLine("Ingrese descuentos: ");
            decimal desc = decimal.Parse(Console.ReadLine());
            decimal salNeto = SalarioNeto(desc);
            Console.WriteLine("Salario neto: " + salNeto);

            if (salNeto < 500)
            {
                Console.WriteLine("Aplica para bono: " + (salNeto * 0.1m));
            }
        }

        public decimal SalarioNeto(decimal descuentos)
        {
            return (sueldo - descuentos);
        }
    }
}
