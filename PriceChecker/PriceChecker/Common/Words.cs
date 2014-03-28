using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PriceChecker.Common
{
    [Serializable]
    public class Words
    {
        [XmlAttribute("SomeAttribute")]
        private string _words { get; set; }

        [XmlElement]
        private List<string> _synonim { get; set; }

        public Words()
        {
            _synonim = new List<string>();
        }

        public void Add(string s)
        {
            _synonim.Add(s);
        }

        public List<string> GetSynonim()
        {
            return _synonim;
        }

        public string GetName()
        {
            return _words;
        }

        public void SetName(string getWords)
        {
            _words = getWords;
        }

        public string GetSynonimById(int i)
        {
            return _synonim[i];
        }
    }

    [Serializable]
    [XmlRoot("Root")]
    public class ListWords
    {
        [XmlArray(ElementName = "Staff")]
        [XmlArrayItem(ElementName = "StaffMember", Type = typeof(List<Words>))]
        [XmlArrayItem(Type = typeof(List<Words>))]
        private List<Words> _words { get; set; }

        public ListWords()
        {
            _words = new List<Words>();
        }

        public void Save()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Words>));
            var file = new  FileStream("words.xml", FileMode.Create);

            reader.Serialize(file, _words);

        }

        public void Load()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(ListWords));
            var file = new System.IO.StreamReader("words.xml");

            var overview = new ListWords();
            overview = (ListWords)reader.Deserialize(file);


        }

        public bool IsExist(string getWords)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (getWords.Contains(_words[i].GetName()))
                    return true;
            }
            return false;
        }

        public void RemoveSynonim(string word, string syn)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (word.Contains(_words[i].GetName()))
                {
                    _words[i].GetSynonim().Remove(syn);
                }
            }
        }

        public void Remove(string removedWords)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (removedWords.Contains(_words[i].GetName()))
                    _words.RemoveAt(i);
            }
        }

        public void AddSynonym(string s, string getSynonim)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (s.Contains(_words[i].GetName()))
                {
                    _words[i].GetSynonim().Add(getSynonim);
                }
            }
        }

        public void AddWord(string getWords)
        {
            var w = new Words();
            w.SetName(getWords);

            _words.Add(w);
        }

        public Words GetListSynonim(string dest)
        {
            var w = new Words();

            for (int i = 0; i < _words.Count; i++)
            {
                if (dest.Contains(_words[i].GetName()))
                {
                    w = _words[i];
                }

            }

            return w;
        }
    }
}


