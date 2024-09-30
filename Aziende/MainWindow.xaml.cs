using Aziende.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Aziende
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = string.Empty;
            FileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documenti Xml (*, xml) | *.xml";
            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                FileInteraction fl = new FileInteraction(filePath);
                fl.Load();
                tbkAziende.Text = fl.Content;
                trvAziende.Items.Clear();
                TreeViewItem root = new TreeViewItem() { Header = filePath};
                trvAziende.Items.Add(root);


                fl.addTreeNode(fl.LoadData(), root);
            }
            

        }


    }
}


