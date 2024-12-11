namespace pawan_automobile
{
    public partial class Form1 : Form
    {
        private Automobile auto;
        private autista conducente;
        private Passeggeri passeggeri;

        public Form1()
        {
            InitializeComponent();
            conducente = new autista("Diego Bernini");
            auto = new Automobile("12345AB", "AB123CD", "Fiat", "Punto");
            passeggeri = new Passeggeri();
            button_auto.Text = "Motore Spento";
            button_auto.BackColor = System.Drawing.Color.Red;
            button_accelera.Enabled = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void AggiornaListaPasseggeri()
        {
            listBox_passeggeri.Items.Clear();
            foreach (string passeggero in passeggeri.OttieniPasseggeri())
            {
                listBox_passeggeri.Items.Add(passeggero);
            }
        }
        private void button_accelera_Click(object sender, EventArgs e)
        {
            GestisciAccelerazione();
        }

        private void button_auto_Click(object sender, EventArgs e)
        {

            if (auto.Accesa)
            {
                auto.Spegni();
                button_auto.Text = "Motore Spento";
                button_auto.BackColor = System.Drawing.Color.Red;
                button_accelera.Enabled = false; 
                label_infrazioni.Text = $"Infrazioni: {auto.Infrazioni}";
                label_velocita.Text = $"Velocità: {auto.Velocita} km/h"; 
                label_infrazioni.Text = "Infrazioni: 0";
                label_velocita.Text = "Velocità: 0 km/h";
            }
            else
            {
                auto.Accendi();
                button_auto.Text = "Motore Acceso";
                button_auto.BackColor = System.Drawing.Color.Green;
                button_accelera.Enabled = true; 
            }

        }

        private void GestisciAccelerazione()
        {
            int incremento = 10; 

            if (auto.Accesa)
            {
                
                auto.Accelera(incremento);

                label_velocita.Text = $"Velocità: {auto.Velocita} km/h";
                label_infrazioni.Text = $"Infrazioni: {auto.Infrazioni}";

                if (auto.Velocita > auto.Limiti && auto.Limiti > 0)
                {
                    MessageBox.Show("Hai superato il limite di velocità!");
                }
            }
            else
            {
                MessageBox.Show("Accendi prima il motore!");
            }

        }

        private void button_impostaLimite_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textbox_limitevelocita.Text, out int limite) && limite > 0)
            {
                auto.ImpostaLimiti(limite);
                MessageBox.Show($"Limite impostato a {limite} km/h.");
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido.");
            }
        }

        private void textbox_limitevelocita_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_scesaAutista_Click(object sender, EventArgs e)
        {
            if (conducente.allaGuida)
            {
                conducente.ScendereDallaGuida();
                auto.Spegni(); 
                button_auto.Text = "Motore Spento";
                button_auto.BackColor = System.Drawing.Color.Red;
                button_accelera.Enabled = false;
                MessageBox.Show($"{conducente.Nome} è sceso dalla guida.");
            }
            else
            {
                MessageBox.Show($"{conducente.Nome} non è alla guida!");
            }
        }

        private void button_salitaAutista_Click(object sender, EventArgs e)
        {
            if (!conducente.allaGuida)
            {
                conducente.SalireAllaGuida();
                MessageBox.Show($"{conducente.Nome} è salito alla guida.");
            }
            else
            {
                MessageBox.Show($"{conducente.Nome} è già alla guida!");
            }
        }

        private void button_aggiungipasseggero_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomePasseggero.Text;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                string risultato = passeggeri.AggiungiPasseggero(nome);
                AggiornaListaPasseggeri(); 
                MessageBox.Show(risultato);
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido per il passeggero.");
            }
        }

        private void textBox_nomePasseggero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_rimuovipasseggero_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomePasseggero.Text;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                string risultato = passeggeri.RimuoviPasseggero(nome);
                AggiornaListaPasseggeri();
                MessageBox.Show(risultato);
            }
            else
            {
                MessageBox.Show("Inserisci un nome valido per il passeggero.");
            }
        }

        private void listBox_passeggeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*  private void button_accendi_Click(object sender, EventArgs e)
          {
              // Accende il motore
              auto.Accendi();

              // Cambia il testo e il colore del bottone
              button_auto.Text = "Motore Acceso";
              button_auto.BackColor = System.Drawing.Color.Green;

              // Abilita il tasto accelerazione
              button_accelera.Enabled = true;
          }*/

        /*    private void button_spegni_Click(object sender, EventArgs e)
             {
                 // Spegne il motore
                 auto.Spegni();

                 // Cambia il testo e il colore del bottone
                 button_auto.Text = "Motore Spento";
                 button_auto.BackColor = System.Drawing.Color.Red;

                 // Disabilita il tasto accelerazione
                 button_accelera.Enabled = false;
             }*/
    }
}

