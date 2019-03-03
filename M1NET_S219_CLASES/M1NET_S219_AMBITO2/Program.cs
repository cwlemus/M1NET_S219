using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programA1=M1NET_S219_AMBITOS1.Program;

namespace M1NET_S219_AMBITO2
{    
    class Program
    {
      
        static void Main(string[] args)
        {
            programA1 prA1 = new programA1();
            Console.WriteLine(prA1);
        }
    }
    class EjemploAmbito2:programA1
    {
        static void Main(string[] args)
        {
            EjemploAmbito2 prA1 = new EjemploAmbito2();
            Console.WriteLine(prA1.variablePublic);
            Console.WriteLine(prA1.variableProtected);
            Console.WriteLine(prA1.variableInteralProtected);
        }
    }
}
