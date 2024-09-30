using Aziende.Models;
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
            try
            {
                FileInteraction fl = new FileInteraction(tbxName.Text);
                fl.Load();
                tbkAziende.Text = fl.Content;
                trvAziende.Items.Clear();
                TreeViewItem root = new TreeViewItem() { Header = tbxName.Text };
                trvAziende.Items.Add(root);


                fl.addTreeNode(fl.LoadData(), root);
            }
            catch 
            {
                MessageBox.Show("Errore nella ricerca del file", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            
        }

    }
}
