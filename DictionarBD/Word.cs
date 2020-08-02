using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarBD
{
    class Word
    {
        string text;
        int id;
       

        public Word() {

            this.text = "";
            this.id = 0;
        }
        public Word(string text, int id)
        {
            this.text = text;
            this.id = id;

        }
        public String Text
        {
            get { return text; }
            set { this.text = value; }
        }
        public int ID
        {
            get { return id; }
            set { this.id = value; }

        }
        public static List<Word> citeste_cuvinte(String nume_fisier)
        {
            List<Word> lista = new List<Word>();
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(nume_fisier, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                for (;;)
                {
                    //fac citire linie cu linie
                    String line = sr.ReadLine();
                    //cand este citit tot ies din for 
                    if (line == null)
                    {
                        break;
                    }
                    int index = line.IndexOf(";");
                    if (index >= 0)
                    {
                        //cuvintele sunt puse in "" de asta este -2 si incepe cu 1
                        String temp_tex = line.Substring(1, index - 2);
                        line = line.Substring(index + 1);
                        try
                        {
                            lista.Add(new Word(temp_tex, Convert.ToInt32(line)));
                        }
                        catch (Exception ex) { }
                    }

                }

            }
          

            catch (Exception ex)
            {


            }
            finally
            {
                //inchid indiferent ce se intampla fileStream si streamReader
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();

            }
            return lista;

        }

        //fac metode care adaug cuvinte noi in fisiere

        //vreau sa fac o metoda care scrie in fisierele text din lista
        //in caz ca vreau sa il rescriu cu noua forma la lista de cuvinte
        public static bool scrieInFisier(string path, List<Word> lista) {
            StringBuilder sb = new StringBuilder();
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(path, FileMode.Truncate, FileAccess.Write);
                sw = new StreamWriter(fs);


                for (int i = 0; i < lista.Count; i++)
                {
                    sb.Append("\"" + lista[i].Text + "\"" + ";" + lista[i].ID);
                    sb.AppendLine();

                }

                sw.Write(sb.ToString());



            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!\n" + ex.ToString());
                return false;
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();

            }
                //daca s-a scris cu bine totul returneaza true
                return true;

        }


        //caut cel mai mare id , ca sa stiu dupa care sa inserez
        public static int searchMaxId(List<Word> list) {
            int idMax = 0;
            if (list==null){
                return -1;
            }

            for (int i = 0; i < list.Count-1; i++) {
                 idMax= list[i].ID;

                if (idMax < list[i + 1].ID) {
                    idMax = list[i + 1].ID;

                }

            }

            return idMax;

        }


    }
}
