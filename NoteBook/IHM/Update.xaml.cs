using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Logique d'interaction pour Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private Course course;
        private Notebook notebook;
        private bool isEdit;
        public Update(Course course, Notebook notebook, bool isEdit)
        {
            InitializeComponent();
            this.course = course;
            this.notebook = notebook;
            this.isEdit= isEdit;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (isEdit) { notebook.Update(course); }
            else { notebook.Create(course);}
            
            Close();
        }
    }
}
