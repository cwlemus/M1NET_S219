using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_AMBITOS1
{
    public class Program
    {
        public string variablePublic="Variable publica";
        private string variablePrivate="Variable privada";
        internal string variableInternal="Variable interal";
        protected string variableProtected="Variable protegida";
        internal protected string variableInteralProtected="Variable protegida interna";
    }
    class PruebaAmbito
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.variablePublic);
            Console.WriteLine(p.variableInteralProtected);
            Console.WriteLine(p.variableInternal);
        }
    }
    class PruebaAmbitoHerencia : Program
    {       
        static void Main(string[] args)
        {
            PruebaAmbitoHerencia pr = new PruebaAmbitoHerencia();
            Console.WriteLine(pr.variablePublic);
            Console.WriteLine(pr.variableInternal);
            Console.WriteLine(pr.variableProtected);
            Console.WriteLine(pr.variableInteralProtected);
        }
    }
}
