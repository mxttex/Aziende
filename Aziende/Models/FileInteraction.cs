using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            StreamReader streamReader = new StreamReader(FileName);
            Content = streamReader.ReadToEnd();
        }  
        public void Load(string name)
        {
            //stessa cosa, ma ti permette di caricare un file diverso
            FileName = name;
            Load();
        }

        public XmlElement LoadData()
        {
            XmlDocument document = new XmlDocument();
            
            document.Load(FileName);
            return document.DocumentElement;
        }

        public void addTreeNode(XmlNode xmlNode, TreeViewItem treeNode)
        {
            XmlNode xNode;
            TreeViewItem tNode;
            XmlNodeList xNodeList;

            if (xmlNode.HasChildNodes)
            {
                xNodeList = xmlNode.ChildNodes;
                for (int x = 0; x <= xNodeList.Count - 1; x++)
                {
                    xNode = xmlNode.ChildNodes[x];
                    int i = treeNode.Items.Add(new TreeViewItem() { Header = xNode.Name });

                    tNode = treeNode.Items[x] as TreeViewItem;
                    addTreeNode(xNode, tNode);
                }
            }
            else treeNode.Header = xmlNode.OuterXml.Trim();
        }




    }
}
