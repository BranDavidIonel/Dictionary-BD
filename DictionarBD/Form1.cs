using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarBD
{
    public partial class Form1 : Form
    {
        List<Word> listaRO;//lista cuvinte romana
        List<Word> listaEN;//lista cuvinte engleza
        List<Word> listaRO_EN;//lista cuvinte traduse din romana
        List<Word> listaEN_RO;//lsita cuvinte traduse din engleza in romana
        List<Word> rezultat_cautare;
        List<Word> rezultat_traducere;

        bool insertRO_EN = true;

      
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            citeste_cuvinte();
            rezultat_cautare = new List<Word>();
            
        }
        void citeste_cuvinte()
        {
            listaRO = Word.citeste_cuvinte(@"resurse\RO.txt");
            listaEN = Word.citeste_cuvinte(@"resurse\EN.txt");
            listaRO_EN = Word.citeste_cuvinte(@"resurse\RO_EN.txt");
            listaEN_RO = Word.citeste_cuvinte(@"resurse\EN_RO.txt");
            


        }
        void cauta(String text)
        {
            rezultat_cautare = new List<Word>();
            if (ROtoEN.Checked)
            {
                foreach (Word cuv in listaRO)
                {
                    if (cuv.Text.StartsWith(text))
                        rezultat_cautare.Add(cuv);
                }

            }
            else
            {
                foreach (Word cuv in listaEN)
                {
                    if (cuv.Text.StartsWith(text))
                        rezultat_cautare.Add(cuv);
                }

            }
            scrie_rezultat_cautate();
        }
        void scrie_rezultat_cautate()
        {
            l1.Items.Clear();
            l2.Items.Clear();
            foreach (Word cuv in rezultat_cautare)
            {
                l1.Items.Add(cuv.Text);
            }
            if (l1.Items.Count > 0)
                l1.SelectedIndex = 0;
            l1.Refresh();
            l2.Refresh();


        }
        void cauta_traducere(Word cuv)
        {
            rezultat_traducere = new List<Word>();
            if (ROtoEN.Checked)
            {
                foreach (Word cuvant in listaRO_EN)
                {
                    if (cuvant.ID == cuv.ID)
                        rezultat_traducere.Add(cuvant);
                }

            }
            else
            {
                foreach (Word cuvant in listaEN_RO)
                {
                    if (cuvant.ID == cuv.ID)
                        rezultat_traducere.Add(cuvant);
                }
            }
            afiseaza_traducere();
        }
        void afiseaza_traducere()
        {
            l2.Items.Clear();
            foreach (Word cuv in rezultat_traducere)
            {
                l2.Items.Add(cuv.Text);
            }
            l2.Refresh();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cuvant.Text.Trim().Length > 0) cauta(cuvant.Text);
        }

        private void l1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (l1.SelectedIndex > -1)
            {
                cauta_traducere(rezultat_cautare[l1.SelectedIndex]);
            }
        }

        private void ROtoEN_Click(object sender, EventArgs e)
        {
            ENtoRO.BackColor = Color.White;
            ROtoEN.BackColor = Color.Gray;

            ENtoRO.Checked = false;
            ROtoEN.Checked = true;
        }

        private void ENtoRO_Click(object sender, EventArgs e)
        {
            ENtoRO.BackColor = Color.Gray;
            ROtoEN.BackColor = Color.White;

            ENtoRO.Checked = true;
            ROtoEN.Checked = false;
        }

        private void cuvant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                button1.PerformClick();//simuleaza apasarea butonului de cautare

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("La adaugare daca cuvantul are mai multe traduceri se adauga virgula \",\"!");
            sb.AppendLine();
            sb.Append("Aplicatie este facuta de Bran David scopul ei este sa ai deja un dictionar care este offline!Si sa poti adauga tu cuvinte noi !");

            MessageBox.Show(sb.ToString());
        }

        private void raportCuvinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("EN are:" + listaEN.Count + "cuvinte! " + "\n");
            sb.AppendLine();
            sb.Append("EN-RO are:" + listaEN_RO.Count + "cuvinte! " + "\n");
            sb.AppendLine();
            sb.Append("RO-EN are:" + listaRO_EN.Count + "cuvinte! " + "\n");
            sb.AppendLine();
            sb.Append("RO are:" + listaRO.Count + "cuvinte! " + "\n");
            MessageBox.Show(sb.ToString());
        }

        //begin add words


        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            AdaugareCuvinte addCuvant= new AdaugareCuvinte(listaRO, listaEN, listaRO_EN,listaEN_RO, @"resurse\");
            if (txInserareR.ToString() != "") {
                //Cuvant addR = new Cuvant(txInserareR.Text,idRo);
                //Cuvant addE = new Cuvant(txInserareE.Text, idRo);               
                //listaRO.Add(addR);
                if (insertRO_EN)
                {
                    if (txInserareE.Text.Contains(",")&& addCuvant.insertWordsRO_EN(txInserareR.Text, txInserareE.Text)) {
                        MessageBox.Show("Este inserat!");
                        citeste_cuvinte();
                    }
                    else
                    {

                        MessageBox.Show("Ceva nu a mers la inserare! Cuvantul poate exista deja ");
                    }
                    if (addCuvant.inserareCuvanteRO_EN(txInserareR.Text, txInserareE.Text))
                    {

                        MessageBox.Show("Este inserat!");
                        citeste_cuvinte();
                    }
                    else
                    {

                        MessageBox.Show("Ceva nu a mers la inserare! Cuvantul poate exista deja ");
                    }
                }
                else {
                    //insert english to romanian word

                    if (addCuvant.inserareCuvinteEN_RO(txInserareR.Text, txInserareE.Text))
                    {

                        MessageBox.Show("Este inserat!");
                        citeste_cuvinte();
                    }
                    else
                    {

                        MessageBox.Show("Ceva nu a mers la inserare! Cuvantul poate exista deja ");
                    }

                }


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            citeste_cuvinte();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (insertRO_EN)
            {
                labelTxIn.Text = "The word in english:";
                labelTxTran.Text = "The word in romanian:";
                insertRO_EN = false;
            }
            else {
                labelTxIn.Text = "The word in romanian:";
                labelTxTran.Text = "The word in english:";
                insertRO_EN = true;

            }
         

        }
    }
}
