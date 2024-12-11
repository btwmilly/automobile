using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawan_automobile
{
    internal class Passeggeri
    {
        private List<string> listaPasseggeri; 
        private const int maxPasseggeri = 4; 
        public Passeggeri()
        {
            listaPasseggeri = new List<string>();
        }

        public string AggiungiPasseggero(string nome)
        {
            if (listaPasseggeri.Count < maxPasseggeri)
            {
                listaPasseggeri.Add(nome);
                return $"Il passeggero {nome} è salito sull'auto.";
            }
            else
            {
                return "Non è possibile aggiungere altri passeggeri. L'auto è piena.";
            }
        }

        public string RimuoviPasseggero(string nome)
        {
            if (listaPasseggeri.Remove(nome))
            {
                return $"Il passeggero {nome} è sceso dall'auto.";
            }
            else
            {
                return $"Il passeggero {nome} non è presente nell'auto.";
            }
        }

        public List<string> OttieniPasseggeri()
        {
            return new List<string>(listaPasseggeri); 
        }

    }
}
