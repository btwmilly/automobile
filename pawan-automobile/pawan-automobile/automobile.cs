using System.ComponentModel;

public class Automobile
{
  
    
        private string telaio;
        private string targa;
        private string modello;
        private string produttore;
        private bool accesa = false;
        private int limiti; 
        private int velocita = 0;
        private int infrazioni = 0;
        private bool limiteSuperato = false;

        public Automobile(string telaio, string targa, string modello, string produttore)
        {
            this.telaio = telaio;
            this.targa = targa;
            this.produttore = produttore;
            this.modello = modello;
        }

        public string Telaio { get { return telaio; } }
        public string Targa { get { return targa; } }
        public string Modello { get { return modello; } }
        public string Produttore { get { return produttore; } }
        public bool Accesa { get { return accesa; } }
        public int Velocita { get { return velocita; } }
        public int Limiti { get { return limiti; } } 
        public int Infrazioni { get { return infrazioni; } }

        
        public void Accendi() 
        {   
            accesa = true;
        }
        public void Spegni()
        {
            accesa = false;
            velocita = 0; 
           // limiteSuperato = false; // Reset flag per evitare incrementi multipli
            infrazioni = 0; 
            limiti = 0;
        }

        public void ImpostaLimiti(int velocitaMax) { limiti = velocitaMax; }

        public void Accelera(int incremento)
        {
            if (!accesa)
            {
                Console.WriteLine("Motore spento. Accendi il motore per accelerare.");
                return;
            }

            velocita += incremento;
            Console.WriteLine($"Velocità attuale: {velocita} km/h.");

            // Verifica se il limite è stato superato
            if (velocita > limiti)
            {
                if (!limiteSuperato)
                {
                    infrazioni++; // Incrementa infrazioni solo una volta per il superamento 
                    Console.WriteLine("Hai superato il limite di velocità!");
                }
            }
            else
            {
                limiteSuperato = false; // Resetta il flag se la velocità è inferiore al limite
            }
        }
    }






