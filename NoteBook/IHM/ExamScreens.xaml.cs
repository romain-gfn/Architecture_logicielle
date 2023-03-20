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
    /// Logique d'interaction pour ExamScreens.xaml
    /// </summary>
    public partial class ExamScreens : Window
    {
        private Notebook notebook;
        public ExamScreens(Notebook notebook)
        {
            InitializeComponent();
            this.notebook = notebook;
        }

        private void CreateExams(object sender, RoutedEventArgs e)
        {

        }

        private void closeButton(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
