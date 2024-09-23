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
            StreamReader streamReader = new StreamReader($"{FileName}.xml");
            Content = streamReader.ReadToEnd();
        }  
        public void Load(string name)
        {
            FileName = name;
            Load();
        }



        
    }
}
