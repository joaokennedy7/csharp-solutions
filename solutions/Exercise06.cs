using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutions
{
    internal class Exercise06
    {

        public void Exercise6()
        {
            var frutas = new List<string>();

            frutas.Add("🍓");
            frutas.Add("🍌");
            frutas.Add("🍉");
            frutas.Add("🍍");
            frutas.Add("🍑");

            bool filtrar = frutas.FirstOrDefault();

            Console.WriteLine(filtrar);

          
           
        }
    }
}
