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
        Word cuvantRO;
        Word cuvantEN;
        string path;
        List<Word> listRO;
        List<Word> listRO_EN;
        List<Word> listEN_RO;
        List<Word> listEN;
        //daca cuvantul este nou introdus sau nu
        bool checkExistEN;
        bool checkExistRO;
        public AdaugareCuvinte() {
            cuvantRO = new Word();
            cuvantEN = new Word();

            path = "";
            checkExistEN = true;
        }
        public AdaugareCuvinte(List<Word> lRO,List<Word> lEN,List<Word> lRO_EN,List<Word> lEN_RO,string path) {
            cuvantRO = new Word();
            cuvantEN = new Word();
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
        public bool verificareCuvantExista(string cuvant, List<Word> lista)
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
                cuvantEN.ID = Word.searchMaxId(listEN) + 1;
            }
            
        }
        public int getIdEN2(string en_txt)
        {
            checkExistEN = false;
            int id = -1;
            for (int i = 0; i < listEN.Count; i++)
            {
                if (String.Equals(listEN[i].Text.Trim(), en_txt))
                {
                    id = listEN[i].ID;
                    checkExistEN = true;
                    return id;
                }

            }
            if (!checkExistEN)
            {
                //daca nu exista atunci maximul +1
                id = Word.searchMaxId(listEN) + 1;
                return id;
            }
            return id;
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
                cuvantRO.ID = Word.searchMaxId(listRO) + 1;
            }
        }

        public int getIdRO2(string ro_txt) {
            checkExistRO = false;
            int id = -1;
            for (int i = 0; i < listRO.Count; i++)
            {
                if (String.Equals(listRO[i].Text.Trim(), ro_txt))
                {
                   id= listRO[i].ID;
                    checkExistRO = true;
                    return id;
                }

            }
            if (!checkExistRO)
            {
                //daca nu exista atunci maximul +1
                id = Word.searchMaxId(listRO) + 1;
                return id;
            }
            return id;
        }
        //I make multiple inserts
        //I have one words in Ro and multiple words in english separate with ','
        #region insertMultiple
        public bool insertWordsRO_EN(string txRo, string txEN) {
            Words words = new Words(txEN);
            Word wordRO_EN = new Word();
            Word wordEN_RO = new Word();
            if (verificareCuvantExista(txRo, listRO))
            {
                //nu am in ce insera deoarece cuvantul in romana exista deja
                return false;
            }
            //seting for ro word
            int idRO = getIdRO2(txRo);
            words.setWordInsert(txRo, idRO);
            //seting for EN words
            for (int i = 0; i < words.Count; i++) {
                int idEn = getIdEN2(words[i].Text);
                words.setWordInsert(words[i].Text, idEn);

            }
            //list for insert final
            //add new data
            //RO
            listRO.Add(words.getWordInsert());
            //RO_EN
            for (int i = 0; i < words.Count; i++)
            {
                wordRO_EN.ID = words.getWordInsert().ID;
                wordRO_EN.Text = words[i].Text;
                listRO_EN.Add(wordEN_RO);
            }
            //EN_RO
            for (int i = 0; i < words.Count; i++)
            {
                wordEN_RO.ID = words[i].ID;
                wordEN_RO.Text = words.getWordInsert().Text;
                listEN_RO.Add(wordEN_RO);
            }
            //EN check if exist and after that I insert
            for (int i = 0; i < words.Count; i++)
            {
                if (!checkExistEN) {
                    listEN.Add(words[i]);

                }
            }
            Word.scrieInFisier(PATH + "RO.txt", listRO);
            Word.scrieInFisier(PATH + "EN.txt", listEN);
            Word.scrieInFisier(PATH + "RO_EN.txt", listRO_EN);
            Word.scrieInFisier(PATH + "EN_RO.txt", listEN_RO);

            return true;
        }
        #endregion

        //one word
        #region insertSimple
        public bool inserareCuvanteRO_EN(string txRo, string txEN) {
            Word cuvantRO_EN = new Word();
            Word cuvantEN_RO = new Word();
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
            Word.scrieInFisier(PATH+"RO.txt", listRO);
            //daca nu exista atunci il adaug in fisier
            if (!checkExistEN)
            {
                Word.scrieInFisier(PATH + "EN.txt", listEN);
            }
            Word.scrieInFisier(PATH+"RO_EN.txt", listRO_EN);
            Word.scrieInFisier(PATH + "EN_RO.txt", listEN_RO);
            


            return true;


        }
        //make in similar way with AddRO_EN
        public bool inserareCuvinteEN_RO(string txEN, string txRO) {
            Word cuvantRO_EN = new Word();
            Word cuvantEN_RO = new Word();
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
           
            cuvantRO_EN.ID = cuvantRO.ID;
            cuvantRO_EN.Text = cuvantEN.Text;
            cuvantEN_RO.ID = cuvantEN.ID;
            cuvantEN_RO.Text = cuvantRO.Text;
            listRO.Add(cuvantRO);
            listEN.Add(cuvantEN);
            listRO_EN.Add(cuvantRO_EN);
            listEN_RO.Add(cuvantEN_RO);
            Word.scrieInFisier(PATH + "EN.txt", listEN);
            //daca nu exista atunci il adaug in fisier
            if (!checkExistRO)
            {
                Word.scrieInFisier(PATH + "RO.txt", listRO);
            }
            Word.scrieInFisier(PATH + "RO_EN.txt", listRO_EN);
            Word.scrieInFisier(PATH + "EN_RO.txt", listEN_RO);





            return true;

        }
        #endregion



    }

    
}
