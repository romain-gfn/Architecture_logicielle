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
using Metier;
using Stockage;

namespace IHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Notebook notebook;
        private ICourseDao courseDao;
        public MainWindow()
        {
            InitializeComponent();
            string chemin = "\"C:\\Users\\romac\\OneDrive\\Documents\\GitHub\\Architecture_logicielle\\BDD.db\"";
            courseDao = new CourseDao(chemin);
            notebook = new Notebook(courseDao, chemin);
        }
    }
}
