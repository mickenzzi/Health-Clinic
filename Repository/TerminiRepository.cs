using Bolnica.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows;

namespace Bolnica.Repository
{
    class TerminiRepository
    {

        private static TerminiRepository instance = null;

        private TerminiRepository()
        {
        }

        public static TerminiRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TerminiRepository();
                }
                return instance;
            }
        }

        public List<Termin> GetSveTermine()
        {
            List<Termin> termini = new List<Termin>();

            if (File.Exists("termini.xml"))
            {
                FileStream fileReader = new FileStream("termini.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(Termin[]));
                Termin[] sviTermini = (Termin[])serializer.Deserialize(fileReader);
                for (int i = 0; i < sviTermini.Length; i++)
                    termini.Add(sviTermini[i]);

                fileReader.Close();
            }
            return termini;
        }


        public void SetSveTermine(List<Termin> termini)
        {
            Termin[] sviTermini = termini.ToArray();
            FileStream fileWriter = new FileStream("termini.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Termin[]));

            serializer.Serialize(fileWriter, sviTermini);
            fileWriter.Close();

        }
    }
}
