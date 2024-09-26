using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aziende.Models
{
    internal class FileInteraction
    {
        public string FileName { get; private set; }
        public string Content { get; private set; }
        
        //XmlDocument XmlDocument { get; set; }
        public FileInteraction(string name)
        {
            FileName = name;
            //XmlDocument = new XmlDocument();
        }

        public void Load()
        {
            //metodo che carica in content tutto il contenuto del file
            StreamReader streamReader = new StreamReader($"{FileName}.xml");
            Content = streamReader.ReadToEnd();
        }  
        public void Load(string name)
        {
            //stessa cosa, ma ti permette di caricare un file diverso
            FileName = name;
            Load();
        }

        public XmlDocument LoadData()
        {
            XmlDocument document = new XmlDocument();
            document.LoadXml($"{FileName}.xml" );
            return document;
        }



        
    }
}
