using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarBD
{

    //--vreau sa adaug cuvinte noi in fisierele text 
    //--cand adaug de exemplu un cuvant cu o traducere in engleza 
    //mai intai vreau sa verific daca cuvantul respectiv exista 
    //--dupa mai vreau sa extind ca sa fie o bifare pentru daca esita necunoscut 
    //sa fie cu o bifa sau un semn specific
    class AdaugareCuvinte
    {
        Cuvant cuvantRO;
        Cuvant cuvantEN;
        string path;
        List<Cuvant> listRO;
        List<Cuvant> listRO_EN;
        List<Cuvant> listEN_RO;
        List<Cuvant> listEN;
        //daca cuvantul este nou introdus sau nu
        bool checkExistEN;
        bool checkExistRO;
        public AdaugareCuvinte() {
            cuvantRO = new Cuvant();
            cuvantEN = new Cuvant();

            path = "";
            checkExistEN = true;
        }
        public AdaugareCuvinte(List<Cuvant> lRO,List<Cuvant> lEN,List<Cuvant> lRO_EN,List<Cuvant> lEN_RO,string path) {
            cuvantRO = new Cuvant();
            cuvantEN = new Cuvant();
            this.listRO = lRO;
            this.listEN = lEN;
            this.listRO_EN = lRO_EN;
            this.listEN_RO = lEN_RO;
            this.path = path;
            this.checkExistEN = true;


        }
        public string PATH {
            get {
                return this.path;
            }
            set {

                this.path = value;
            }

        }
        //fac functia de cautate in lista de cuvinte
        public bool verificareCuvantExista(string cuvant, List<Cuvant> lista)
        {

            for (int i = 0; i < lista.Count; i++)
            {
                if (String.Equals(lista[i].Text.Trim(), cuvant)) {
                    return true;
                }

            }
            return false;
        }
        //daca am deja cuvantul in lista cu cuvinte in engleza 
        //atunci obtin id respectiv
        //daca nu il am atunci il caut pe cel mai mare si mai adaug unul sa ma asigur ca este unic
        public void getIdEN() {

            checkExistEN = false;
            for (int i = 0; i < listEN.Count; i++)
            {
                if (String.Equals(listEN[i].Text.Trim(), cuvantEN.Text))
                {
                    cuvantEN.ID=listEN[i].ID;
                    checkExistEN = true;
                }

            }

            if (!checkExistEN)
            {
                //daca nu exista atunci maximul +1
                cuvantEN.ID = Cuvant.searchMaxId(listEN) + 1;
            }
            
        }
        public void getIdRO() {
            checkExistRO = false;
            for (int i = 0; i < listRO.Count; i++)
            {
                if (String.Equals(listRO[i].Text.Trim(), cuvantRO.Text))
                {
                    cuvantRO.ID=listRO[i].ID;
                    checkExistRO = true;
                }

            }
            if (!checkExistRO) {
                //daca nu exista atunci maximul +1
                cuvantRO.ID = Cuvant.searchMaxId(listRO) + 1;
            }
        }

      public  bool inserareCuvanteRO_EN(string txRo, string txEN) {
            Cuvant cuvantRO_EN = new Cuvant();
            Cuvant cuvantEN_RO = new Cuvant();
            //trebuie sa fac inserarea in cele 4 fisiere 
            //dar mai intai trebuie sa verific daca mai exista cuvantul respectiv 
            if (verificareCuvantExista(txRo, listRO)) {
                //nu am in ce insera deoarece cuvantul in romana exista deja
                return false;
            }
            cuvantRO.Text = txRo;
            cuvantEN.Text = txEN;
            getIdRO();
            getIdEN();
            //id in engleza 
            //cuvantul in romana
            cuvantRO_EN.ID = cuvantRO.ID;
            cuvantRO_EN.Text = cuvantEN.Text;
            cuvantEN_RO.ID = cuvantEN.ID;
            cuvantEN_RO.Text = cuvantRO.Text;
            listRO.Add(cuvantRO);
            listEN.Add(cuvantEN);
            listRO_EN.Add(cuvantRO_EN);
            listEN_RO.Add(cuvantEN_RO);
            Cuvant.scrieInFisier(PATH+"RO.txt", listRO);
            //daca nu exista atunci il adaug in fisier
            if (!checkExistEN)
            {
                Cuvant.scrieInFisier(PATH + "EN.txt", listEN);
            }
            Cuvant.scrieInFisier(PATH+"RO_EN.txt", listRO_EN);
            Cuvant.scrieInFisier(PATH + "EN_RO.txt", listEN_RO);
            


            return true;


        }
        //make in similar way with AddRO_EN
        public bool inserareCuvinteEN_RO(string txEN, string txRO) {
            Cuvant cuvantRO_EN = new Cuvant();
            Cuvant cuvantEN_RO = new Cuvant();
            //trebuie sa fac inserarea in cele 4 fisiere 
            //dar mai intai trebuie sa verific daca mai exista cuvantul respectiv 
            if (verificareCuvantExista(txEN, listRO))
            {
                //nu am in ce insera deoarece cuvantul in engleza exista deja
                return false;
            }
            cuvantRO.Text = txRO;
            cuvantEN.Text = txEN;
            getIdRO();
            getIdEN();
            //id in engleza 
            //cuvantul in romana
            cuvantRO_EN.ID = cuvantRO.ID;
            cuvantRO_EN.Text = cuvantEN.Text;
            cuvantEN_RO.ID = cuvantEN.ID;
            cuvantEN_RO.Text = cuvantRO.Text;
            listRO.Add(cuvantRO);
            listEN.Add(cuvantEN);
            listRO_EN.Add(cuvantRO_EN);
            listEN_RO.Add(cuvantEN_RO);
            Cuvant.scrieInFisier(PATH + "EN.txt", listEN);
            //daca nu exista atunci il adaug in fisier
            if (!checkExistRO)
            {
                Cuvant.scrieInFisier(PATH + "RO.txt", listRO);
            }
            Cuvant.scrieInFisier(PATH + "RO_EN.txt", listRO_EN);
            Cuvant.scrieInFisier(PATH + "EN_RO.txt", listEN_RO);





            return true;

        }



    }

    
}
