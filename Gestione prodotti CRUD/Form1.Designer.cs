namespace Gestione_prodotti_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.inserisci_nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inserisci_prezzo = new System.Windows.Forms.TextBox();
            this.inserisci = new System.Windows.Forms.Button();
            this.elenco = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nuovo_prodotto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inserisci_nome
            // 
            this.inserisci_nome.Location = new System.Drawing.Point(44, 72);
            this.inserisci_nome.Name = "inserisci_nome";
            this.inserisci_nome.Size = new System.Drawing.Size(100, 20);
            this.inserisci_nome.TabIndex = 0;
            this.inserisci_nome.TextChanged += new System.EventHandler(this.INSERISCI__TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "NOME PRODOTTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "PREZZO";
            // 
            // inserisci_prezzo
            // 
            this.inserisci_prezzo.Location = new System.Drawing.Point(159, 72);
            this.inserisci_prezzo.Name = "inserisci_prezzo";
            this.inserisci_prezzo.Size = new System.Drawing.Size(100, 20);
            this.inserisci_prezzo.TabIndex = 3;
            this.inserisci_prezzo.TextChanged += new System.EventHandler(this.INSERISCI_PREZZO_TextChanged);
            // 
            // inserisci
            // 
            this.inserisci.Location = new System.Drawing.Point(100, 98);
            this.inserisci.Name = "inserisci";
            this.inserisci.Size = new System.Drawing.Size(103, 74);
            this.inserisci.TabIndex = 4;
            this.inserisci.Text = "INSERISCI NELL\'ELENCO";
            this.inserisci.UseVisualStyleBackColor = true;
            this.inserisci.Click += new System.EventHandler(this.INSERISCI_Click);
            // 
            // elenco
            // 
            this.elenco.HideSelection = false;
            this.elenco.Location = new System.Drawing.Point(984, 33);
            this.elenco.Name = "elenco";
            this.elenco.Size = new System.Drawing.Size(415, 456);
            this.elenco.TabIndex = 5;
            this.elenco.UseCompatibleStateImageBehavior = false;
            this.elenco.View = System.Windows.Forms.View.List;
            this.elenco.SelectedIndexChanged += new System.EventHandler(this.ELENCO_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "NUOVO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nuovo_prodotto
            // 
            this.nuovo_prodotto.Location = new System.Drawing.Point(375, 265);
            this.nuovo_prodotto.Name = "nuovo_prodotto";
            this.nuovo_prodotto.Size = new System.Drawing.Size(103, 20);
            this.nuovo_prodotto.TabIndex = 10;
            this.nuovo_prodotto.TextChanged += new System.EventHandler(this.modificadelprodotto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "VECCHIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 74);
            this.button1.TabIndex = 12;
            this.button1.Text = "MODIFICA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "INSERISCI IL NOME DEL PRODOTTO DA CANCELLARE\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 74);
            this.button2.TabIndex = 15;
            this.button2.Text = "CANCELLA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 445);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "PRODOTTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "PRODOTTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "PREZZO";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 291);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(984, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 74);
            this.button3.TabIndex = 24;
            this.button3.Text = "ORDINA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1093, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 74);
            this.button4.TabIndex = 25;
            this.button4.Text = "SOMMA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(489, 471);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 74);
            this.button5.TabIndex = 26;
            this.button5.Text = "SOMMA %";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "INSERISCI LA PERCENTUALE DA APPLICARE";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(555, 445);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(609, 471);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 74);
            this.button6.TabIndex = 29;
            this.button6.Text = "SOTTRAI %";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1202, 495);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 74);
            this.button7.TabIndex = 30;
            this.button7.Text = "LEGGI DA FILE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1309, 495);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 74);
            this.button8.TabIndex = 31;
            this.button8.Text = "SALVA SU FILE";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(875, 411);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 74);
            this.button9.TabIndex = 32;
            this.button9.Text = "PREZZO MINIMO";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(875, 331);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(103, 74);
            this.button10.TabIndex = 33;
            this.button10.Text = "PREZZO MASSIMO";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 614);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuovo_prodotto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.elenco);
            this.Controls.Add(this.inserisci);
            this.Controls.Add(this.inserisci_prezzo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inserisci_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inserisci_nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inserisci_prezzo;
        private System.Windows.Forms.Button inserisci;
        private System.Windows.Forms.ListView elenco;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nuovo_prodotto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

