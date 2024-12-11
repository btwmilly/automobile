namespace pawan_automobile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_impostaLimite = new Button();
            statoMotore = new Label();
            button_accelera = new Button();
            textbox_limitevelocita = new TextBox();
            label_velocita = new Label();
            label_infrazioni = new Label();
            button_auto = new Button();
            button_salitaAutista = new Button();
            button_scesaAutista = new Button();
            button_aggiungipasseggero = new Button();
            button_rimuovipasseggero = new Button();
            textBox_nomePasseggero = new TextBox();
            listBox_passeggeri = new ListBox();
            SuspendLayout();
            // 
            // button_impostaLimite
            // 
            button_impostaLimite.Location = new Point(30, 86);
            button_impostaLimite.Name = "button_impostaLimite";
            button_impostaLimite.Size = new Size(132, 35);
            button_impostaLimite.TabIndex = 2;
            button_impostaLimite.Text = "imposta limite";
            button_impostaLimite.UseVisualStyleBackColor = true;
            button_impostaLimite.Click += button_impostaLimite_Click;
            // 
            // statoMotore
            // 
            statoMotore.AutoSize = true;
            statoMotore.Location = new Point(317, 24);
            statoMotore.Name = "statoMotore";
            statoMotore.Size = new Size(95, 20);
            statoMotore.TabIndex = 3;
            statoMotore.Text = "stato motore";
            // 
            // button_accelera
            // 
            button_accelera.Location = new Point(682, 86);
            button_accelera.Name = "button_accelera";
            button_accelera.Size = new Size(94, 29);
            button_accelera.TabIndex = 4;
            button_accelera.Text = "accelera";
            button_accelera.UseVisualStyleBackColor = true;
            button_accelera.Click += button_accelera_Click;
            // 
            // textbox_limitevelocita
            // 
            textbox_limitevelocita.Location = new Point(30, 41);
            textbox_limitevelocita.Name = "textbox_limitevelocita";
            textbox_limitevelocita.Size = new Size(125, 27);
            textbox_limitevelocita.TabIndex = 5;
            textbox_limitevelocita.TextChanged += textbox_limitevelocita_TextChanged;
            // 
            // label_velocita
            // 
            label_velocita.AutoSize = true;
            label_velocita.Location = new Point(650, 126);
            label_velocita.Name = "label_velocita";
            label_velocita.Size = new Size(61, 20);
            label_velocita.TabIndex = 6;
            label_velocita.Text = "velocità";
            // 
            // label_infrazioni
            // 
            label_infrazioni.AutoSize = true;
            label_infrazioni.Location = new Point(650, 157);
            label_infrazioni.Name = "label_infrazioni";
            label_infrazioni.Size = new Size(71, 20);
            label_infrazioni.TabIndex = 7;
            label_infrazioni.Text = "infrazioni";
            // 
            // button_auto
            // 
            button_auto.BackColor = Color.Red;
            button_auto.Location = new Point(299, 47);
            button_auto.Name = "button_auto";
            button_auto.Size = new Size(142, 203);
            button_auto.TabIndex = 8;
            button_auto.Text = "AUTO";
            button_auto.UseVisualStyleBackColor = false;
            button_auto.Click += button_auto_Click;
            // 
            // button_salitaAutista
            // 
            button_salitaAutista.Location = new Point(473, 73);
            button_salitaAutista.Name = "button_salitaAutista";
            button_salitaAutista.Size = new Size(130, 29);
            button_salitaAutista.TabIndex = 9;
            button_salitaAutista.Text = "salita autista";
            button_salitaAutista.UseVisualStyleBackColor = true;
            button_salitaAutista.Click += button_salitaAutista_Click;
            // 
            // button_scesaAutista
            // 
            button_scesaAutista.Location = new Point(473, 126);
            button_scesaAutista.Name = "button_scesaAutista";
            button_scesaAutista.Size = new Size(130, 29);
            button_scesaAutista.TabIndex = 10;
            button_scesaAutista.Text = "scesa autista";
            button_scesaAutista.UseVisualStyleBackColor = true;
            button_scesaAutista.Click += button_scesaAutista_Click;
            // 
            // button_aggiungipasseggero
            // 
            button_aggiungipasseggero.Location = new Point(12, 272);
            button_aggiungipasseggero.Name = "button_aggiungipasseggero";
            button_aggiungipasseggero.Size = new Size(164, 44);
            button_aggiungipasseggero.TabIndex = 11;
            button_aggiungipasseggero.Text = "aggiungi passeggero ";
            button_aggiungipasseggero.UseVisualStyleBackColor = true;
            button_aggiungipasseggero.Click += button_aggiungipasseggero_Click;
            // 
            // button_rimuovipasseggero
            // 
            button_rimuovipasseggero.Location = new Point(12, 331);
            button_rimuovipasseggero.Name = "button_rimuovipasseggero";
            button_rimuovipasseggero.Size = new Size(164, 44);
            button_rimuovipasseggero.TabIndex = 12;
            button_rimuovipasseggero.Text = "rimuovi passeggero ";
            button_rimuovipasseggero.UseVisualStyleBackColor = true;
            button_rimuovipasseggero.Click += button_rimuovipasseggero_Click;
            // 
            // textBox_nomePasseggero
            // 
            textBox_nomePasseggero.Location = new Point(186, 289);
            textBox_nomePasseggero.Name = "textBox_nomePasseggero";
            textBox_nomePasseggero.Size = new Size(125, 27);
            textBox_nomePasseggero.TabIndex = 13;
            textBox_nomePasseggero.TextChanged += textBox_nomePasseggero_TextChanged;
            // 
            // listBox_passeggeri
            // 
            listBox_passeggeri.FormattingEnabled = true;
            listBox_passeggeri.Location = new Point(422, 271);
            listBox_passeggeri.Name = "listBox_passeggeri";
            listBox_passeggeri.Size = new Size(150, 104);
            listBox_passeggeri.TabIndex = 14;
            listBox_passeggeri.SelectedIndexChanged += listBox_passeggeri_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_passeggeri);
            Controls.Add(textBox_nomePasseggero);
            Controls.Add(button_rimuovipasseggero);
            Controls.Add(button_aggiungipasseggero);
            Controls.Add(button_scesaAutista);
            Controls.Add(button_salitaAutista);
            Controls.Add(button_auto);
            Controls.Add(label_infrazioni);
            Controls.Add(label_velocita);
            Controls.Add(textbox_limitevelocita);
            Controls.Add(button_accelera);
            Controls.Add(statoMotore);
            Controls.Add(button_impostaLimite);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_impostaLimite;
        private Label statoMotore;
        private Button button_accelera;
        private TextBox textbox_limitevelocita;
        private Label label_velocita;
        private Label label_infrazioni;
        private Button button_auto;
        private Button button_salitaAutista;
        private Button button_scesaAutista;
        private Button button_aggiungipasseggero;
        private Button button_rimuovipasseggero;
        private TextBox textBox_nomePasseggero;
        private ListBox listBox_passeggeri;
    }
}
