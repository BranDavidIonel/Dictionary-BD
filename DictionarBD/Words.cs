using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarBD
{
    class Words
    {

        //for multiple words
        List <Word> listWordTranslation;
        Word wordInsert;
        public Words(string str_words) {
            Word w1 = new Word();
            foreach (string str in str_words.Split(',')){
                w1 = new Word();
                w1.Text = str;
                listWordTranslation.Add(w1);

            }
        }
        public void setWordInsert(string str,int id)
        {
            wordInsert.Text = str;
            wordInsert.ID = id;

        }

        //find a word from list and set with id
        public void setWords(string str_word, int id) {
            for (int i = 0; i < listWordTranslation.Count; i++) {
                if (listWordTranslation[i].Text == str_word) {
                    listWordTranslation[i].ID = id;

                }

            }

        }
        public Word getWordInsert() {
            return wordInsert;
        }

        public Word this[int i]{
           get { return listWordTranslation[i]; }
            set { this.listWordTranslation[i]= value; }

        }
        public int Count
        {
            get { return listWordTranslation.Count; }

        }
    }
}
