﻿using System;
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
        List<Cuvant> listaRO;//lista cuvinte romana
        List<Cuvant> listaEN;//lista cuvinte engleza
        List<Cuvant> listaRO_EN;//lista cuvinte traduse din romana
        List<Cuvant> listaEN_RO;//lsita cuvinte traduse din engleza in romana
        List<Cuvant> rezultat_cautare;
        List<Cuvant> rezultat_traducere;

        bool insetRO_EN = true;

      
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            citeste_cuvinte();
            rezultat_cautare = new List<Cuvant>();
            
        }
        void citeste_cuvinte()
        {
            listaRO = Cuvant.citeste_cuvinte(@"resurse\RO.txt");
            listaEN = Cuvant.citeste_cuvinte(@"resurse\EN.txt");
            listaRO_EN = Cuvant.citeste_cuvinte(@"resurse\RO_EN.txt");
            listaEN_RO = Cuvant.citeste_cuvinte(@"resurse\EN_RO.txt");
            


        }
        void cauta(String text)
        {
            rezultat_cautare = new List<Cuvant>();
            if (ROtoEN.Checked)
            {
                foreach (Cuvant cuv in listaRO)
                {
                    if (cuv.Text.StartsWith(text))
                        rezultat_cautare.Add(cuv);
                }

            }
            else
            {
                foreach (Cuvant cuv in listaEN)
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
            foreach (Cuvant cuv in rezultat_cautare)
            {
                l1.Items.Add(cuv.Text);
            }
            if (l1.Items.Count > 0)
                l1.SelectedIndex = 0;
            l1.Refresh();
            l2.Refresh();


        }
        void cauta_traducere(Cuvant cuv)
        {
            rezultat_traducere = new List<Cuvant>();
            if (ROtoEN.Checked)
            {
                foreach (Cuvant cuvant in listaRO_EN)
                {
                    if (cuvant.ID == cuv.ID)
                        rezultat_traducere.Add(cuvant);
                }

            }
            else
            {
                foreach (Cuvant cuvant in listaEN_RO)
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
            foreach (Cuvant cuv in rezultat_traducere)
            {
                l2.Items.Add(cuv.Text);
            }
            l2.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
           
            AdaugareCuvinte addCuvant= new AdaugareCuvinte(listaRO, listaEN, listaRO_EN,listaEN_RO, @"resurse\");
            if (txInserareR.ToString() != "") {
                //Cuvant addR = new Cuvant(txInserareR.Text,idRo);
                //Cuvant addE = new Cuvant(txInserareE.Text, idRo);               
                //listaRO.Add(addR);
                if (addCuvant.inserareCuvanteRO_EN(txInserareR.Text,txInserareE.Text))
                {

                    MessageBox.Show("Este inserat!");
                    citeste_cuvinte();
                }
                else {

                    MessageBox.Show("Ceva nu a mers la inserare! Cuvantul poate exista deja ");
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            citeste_cuvinte();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (insetRO_EN)
            {
                labelTxIn.Text = "Cuvantul in romana:";
                labelTxTran.Text = "Traducerile in engleza:";
                insetRO_EN = false;
            }
            else {
                labelTxIn.Text = "Cuvantul in engleza:";
                labelTxTran.Text = "Traducerile in romana:";
                insetRO_EN = true;

            }
         

        }
    }
}
