using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestione_prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Prodotti// array di strutture di tipo struct che contiene Nome e Prezzo 
        {
            public string nome;
            public float prezzo;
        }

        public Prodotti[] p;//dichiarazione variabili 
        public int dim; 
        public int n=0;


        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Prodotti[100];//dichiarazione dimensioni
            dim = 0;
        }

        private void INSERISCI__TextChanged(object sender, EventArgs e)
        {

        }

        private void INSERISCI_PREZZO_TextChanged(object sender, EventArgs e)
        {

        }


        private void Aggiunta()   //funzioni aggiunta
        {
            float c;

            if (inserisci_nome.Text == "" || inserisci_prezzo.Text == "")//controllo se sono stati compilati tutti i campi
            {
                MessageBox.Show("ERRORE");
            }

            else
            {
                bool result = float.TryParse(inserisci_prezzo.Text, out c);//controllo se nel prezzo è stato inserito un numero
                if (result)
                {
                    if (float.Parse(inserisci_prezzo.Text) >= 0)//controllo se il prezzo è un numero positivo
                    {
                        if (n != 0)//inserisce il prodotto sostituendo un prodotto cancellato
                        {
                            p[dim - n].nome = inserisci_nome.Text;
                            p[dim - n].prezzo = float.Parse(inserisci_prezzo.Text);
                            n--;
                        }
                        else//inserisce il prodotto usando un nuovo spazio dell'array
                        {
                            p[dim].nome = inserisci_nome.Text;
                            p[dim].prezzo = float.Parse(inserisci_prezzo.Text);
                            dim++;
                        }
                    }

                    else
                    {
                        MessageBox.Show("ERRORE");
                    }
                }

                else
                {
                    MessageBox.Show("ERRORE");
                }
            }
        }

        public void Modifica() //funzione modifica
        {
            string a = textBox1.Text;//dichiarazione variabili
            bool b = false;
            float c;

            if (nuovo_prodotto.Text == "" || textBox4.Text == "")//controllo se sono stati compilati tutti i campi
            {
                MessageBox.Show("ERRORE");
            }

            else
            {
                bool result = float.TryParse(textBox4.Text, out c);//controlla se il nuovo prezzo è un numero
                if (result)
                {
                    if (float.Parse(textBox4.Text) >= 0)//controlla se il nuovo prezzo è un numero positivo
                    {
                        for (int i = 0; i < dim-n; i++)//ricerca del prodotto da modificare
                        {
                            if (p[i].nome == a)//modifica del prodotto se trovato
                            {
                                p[i].nome = nuovo_prodotto.Text;
                                p[i].prezzo = float.Parse(textBox4.Text);
                                b = true;

                            }
                        }

                        if (b == false)
                        {
                            MessageBox.Show("il prodotto non è stato trovato");
                        }
                    }

                    else
                    {
                        MessageBox.Show("ERRORE");
                    }
                }

                else
                {
                    MessageBox.Show("ERRORE");
                }
            }


        }

        public void Cancella() //funzione cancella
        {
            string a = textBox2.Text;//dichiarazione variabili
            bool b = false;

            
            for (int i = 0; i < dim-n; i++)//ricerca del prodotto da cancellare
            {
                if (p[i].nome == a)
                {
                    elenco.Items.RemoveAt(i);//cancella il prodotta dalla lista
                    b = true;
                    for (int y = i + 1; y < dim; y++)//canclla il prodotto dalla struct
                    {
                        p[i].nome = p[y].nome;
                        p[i].prezzo = p[y].prezzo;
                        i++;
                    }
                    n++;
                }
            }

            if (b == false)
            {
                MessageBox.Show("il prodotto non è stato trovato");
            }

        }

        public void ordina() //funzione ordinamento in ordine alfabetico
        {
            int c = 0, c1=0;//dichiarazione variabili
            float f1;
            string f;

            do
            {
                for (int i = 0; i < dim - 1-n; i++)
                {
                    c1 = c;
                    if (p[i].nome.CompareTo(p[i + 1].nome) > 0)//compara gli elementi dell'array uno ad uno e gli ordina
                    {
                        f = p[i].nome;
                        f1 = p[i].prezzo;
                        p[i].prezzo = p[i+1].prezzo;
                        p[i+1].prezzo = f1;
                        p[i].nome = p[i + 1].nome;
                        p[i + 1].nome = f;
                        c++;
                    }
                }
            } while (c1 != c);
        }

        public void somma()//funzione somma dei prezzi dei prodotii
        {
            float s = 0;//dichiarazione variabili

            for(int i = 0; i < dim-n; i++) //somma i prezzi di tutti i prodotti
            {
                s += p[i].prezzo;
            }
            MessageBox.Show("Il prezzo totale è " + s + "$");
        }

        public void percentualesomm()
        {
            float[] arr = new float[dim];//dichiarazione variabili
            float c;

            if (textBox3.Text != "")//controlla che i campi da compilare non siano vuoti
            {
                float a = float.Parse(textBox3.Text);

                bool result = float.TryParse(textBox3.Text, out c);//controlla che la percentuale inserita è un numero
                if (result)
                {
                    if (a >= 0)//controlla se la percentuale inserita è un numero positivo
                    {
                        for (int i = 0; i < dim-n; i++)//somma la percentuale a tutti i prezzi
                        {
                            arr[i] = p[i].prezzo + (p[i].prezzo * a / 100);
                            elenco.Items.Insert(i, $"il nome è: {p[i].nome} e il prezzo aumentato del {a}% è: {arr[i]}");
                        }
                    }

                    else
                    {
                        MessageBox.Show("ERRORE");
                    }
                }

                else
                {
                    MessageBox.Show("ERRORE");
                }
            }

            else
            {
                MessageBox.Show("ERRORE");
            }

        }

        public void percentualesott()//funzione sottrazione di una perccentuale
        {
            float[] arr = new float[dim];//dichiarazione variabili
            float c;

            if (textBox3.Text != "")//controlla che i campi da compilare non siano vuoti
            {
                float a = float.Parse(textBox3.Text);
                bool result = float.TryParse(textBox3.Text, out c);//controlla che la percentuale inserita sia un numero
                if (result)
                {
                    if (a >= 0)//controlla che la percentuale inserita sia un numero positivo
                    {
                        for (int i = 0; i < dim-n; i++)//sottrae la percentuale a tutti i prezzi
                        {
                            arr[i] = p[i].prezzo - (p[i].prezzo * a / 100);
                            elenco.Items.Insert(i, $"il nome è: {p[i].nome} e il prezzo diminuito del {a}% è: {arr[i]}");
                        }
                    }

                    else
                    {
                        MessageBox.Show("ERRORE");
                    }
                }

                else
                {
                    MessageBox.Show("ERRORE");
                }
            }
            else
            {
                MessageBox.Show("ERRORE");
            }

        }

        static string[] Split(string array1)//funzione che divide una stringa in 2
        {

            string[] array2 = new string[2];//dichiarazione variabili
            string stringa = "";
            int p = 0;

            for (int i = 0; i < array1.Length; i++)//divisione della stringa
            {
                if (array1[i] == ';')
                {
                    array2[p] = stringa;
                    p++;
                    stringa = "";
                }
                else
                {
                    stringa += array1[i];
                }

                if (i == array1.Length - 1)
                {
                    array2[p] = stringa;
                }
            }
            return array2;
        }

        public void LeggiDaFile()//funzione che scrive il contenuto del file in un elenco
        {

            elenco.Items.Clear();
            StreamReader lf = new StreamReader(@"LISTA.txt");//dichiarazione variabili
            string riga = lf.ReadLine();

            while (riga != null)//scrive il contenuto del file
            {

                string[] rigaSplit = Split(riga);
                p[dim].nome = rigaSplit[0];
                p[dim].prezzo = float.Parse(rigaSplit[1]);
                dim++;
                riga = lf.ReadLine();
            }
            lf.Close();
            elenco.Visible = true;
            Visualizza();

        }




        public void SalvaSuFile()//funzione che salva il contenuto dell'elenco in un file
        {
            StreamWriter sf = new StreamWriter("LISTA.txt");//dichiarazione variabili

            for (int i = 0; i < dim-n; i++)//scrive il contenuto dell'elenco
            {
                sf.WriteLine($"{p[i].nome};{p[i].prezzo}");
            }
            sf.Close();
        }

        public void prezzomin()//funzione che trova il prodotto con il  prezzo minimo
        {
            string min = "";//dichiarazione variabili
            float n1 = p[0].prezzo;
            bool c = false;

            for (int i = 0; i < dim-n; i++)//ricerca del prodotto con il prezzo minimo
            {
                if (p[i].prezzo < n1)
                {
                    n1 = p[i].prezzo;
                    min = p[i].nome;
                    c = true;
                }
            }

            if (c == false)
            {
                min = p[0].nome;
            }

                MessageBox.Show("Il prodotto con il prezzo minimo è " + min);

        }

        public void prezzomax()
        {
            string max = "";//dichiarazione variabili
            float n1 = p[0].prezzo;
            bool c = false;

            for (int i = 0; i < dim-n; i++)//ricerca del prodotto con il prezzo minimo
            {
                if (p[i].prezzo > n1)
                {
                    n1 = p[i].prezzo;
                    max = p[i].nome;
                    c = true;
                }
            }

            if (c == false)
            {
                max = p[0].nome;
            }

                MessageBox.Show("Il prodotto con il prezzo minimo è " + max);

        }

        private void INSERISCI_Click(object sender, EventArgs e)//inserisce un nuovo prodotto
        {
            Aggiunta();
            inserisci_nome.Clear();
            inserisci_prezzo.Clear();
            elenco.Clear();
            Visualizza();
        }


        public void Visualizza()//visualizzi il prodotto nella lista
        {
            for (int i = 0; i < dim-n; i++)
            {
                elenco.Items.Insert(i,$"il nome è: {p[i].nome} e il prezzo è: {p[i].prezzo}");
            }
        }

        private void ELENCO_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void VISUALIZZA_LISTA_Click(object sender, EventArgs e)
        {

        }

        private void MODIFICA_PRODOTTO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void modificadelprodotto_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)//modifica un prodotto
        {
            Modifica();
            textBox1.Clear();
            nuovo_prodotto.Clear();
            textBox4.Clear();
            elenco.Clear();
            Visualizza();
        }


        private void button2_Click(object sender, EventArgs e)//cancella un prodotto
        {
            Cancella();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//ordina alfabeticamente i prodotti
        {
            ordina();
            elenco.Clear();
            Visualizza();
        }

        private void button4_Click(object sender, EventArgs e)//somma i prezzi dei prodotti
        {
            somma();
        }

        private void button5_Click(object sender, EventArgs e)//somma una percentuale a tutti i prezzi dei prodotti
        {
            percentualesomm();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)//sottrare una percenruale a tutti i prezzi dei prodotti
        {
            percentualesott();
            textBox3.Clear();
        }

        private void button9_Click(object sender, EventArgs e)//trova il prodotto con il prezzo minimo
        {
            prezzomin();
        }

        private void button10_Click(object sender, EventArgs e)//trova il prodotto con il prezzo massimo
        {
            prezzomax();
        }

        private void button7_Click(object sender, EventArgs e)//legge i prodotti che ci sono su un file sulla lista
        {
            LeggiDaFile();
        }

        private void button8_Click(object sender, EventArgs e)//salva i prodotti della lista su un file
        {
            SalvaSuFile();
        }
    }
}
