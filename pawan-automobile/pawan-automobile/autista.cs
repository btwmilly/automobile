using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawan_automobile
{
    internal class autista 
    {
        public string Nome { get; private set; }
        public bool allaGuida { get; private set; }

        public autista(string nome)
        {
            Nome = nome;
            allaGuida = false; 
        }

        public void SalireAllaGuida()
        {
            allaGuida = true;
            Console.WriteLine($"{Nome} è salito alla guida.");
        }

        public void ScendereDallaGuida()
        {
            allaGuida = false;
            Console.WriteLine($"{Nome} è sceso dalla guida.");
        }
    }
}
