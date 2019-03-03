using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est = new Estudiante();
           
            est.nombre = "Carlos";
            est.apellido = "Lemus";
            est.cum = 8.5f;
            Console.WriteLine(est.nombre);
            Console.WriteLine(est.apellido);
            Console.WriteLine(est.cum);
            Console.WriteLine(est.cuotaMensual);
            Console.ReadLine();
        }
    }
}
