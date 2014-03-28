using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PriceChecker.Common
{
    public class Words
    {
        public string _words { get; set; }

        public List<string> _synonim { get; set; }

        public Words()
        {
            _synonim = new List<string>();
        }
    }


    public class ListWords
    {
        public List<Words> _words { get; set; }

        public ListWords()
        {
            _words = new List<Words>();
        }

        public bool IsExist(string getWords)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (getWords.Contains(_words[i]._words))
                    return true;
            }
            return false;
        }

        public void RemoveSynonim(string word, string syn)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (word.Contains(_words[i]._words))
                {
                    _words[i]._synonim.Remove(syn);
                }
            }
        }

        public void Remove(string removedWords)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (removedWords.Contains(_words[i]._words))
                    _words.RemoveAt(i);
            }
        }

        public void AddSynonym(string s, string getSynonim)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (s.Contains(_words[i]._words))
                {
                    _words[i]._synonim.Add(getSynonim);
                }
            }
        }

        public void AddWord(string getWords)
        {
            var w = new Words();
            w._words = getWords;

            _words.Add(w);
        }

        public Words GetListSynonim(string dest)
        {
            var w = new Words();

            for (int i = 0; i < _words.Count; i++)
            {
                if (dest.Contains(_words[i]._words))
                {
                    w = _words[i];
                }

            }

            return w;
        }
    }
}


