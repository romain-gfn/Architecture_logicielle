using Metier;
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
using System.Windows.Shapes;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour Matiere.xaml
    /// </summary>
    public partial class Matiere : Window
    {
        public Matiere(Notebook notebook)
        {
            InitializeComponent();
            foreach(Course c in notebook.ListAll())
            {
                list.Items.Add(c);
            }
        }

       

    }
}
