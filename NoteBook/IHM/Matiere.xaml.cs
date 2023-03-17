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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour Matiere.xaml
    /// </summary>
    
    public partial class Matiere : Window
    {
        private Notebook notebook;
        public Matiere(Notebook notebook)
        {
            InitializeComponent();
            DrawCourses();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Supprimer_Button(object sender, RoutedEventArgs e)
        {
            notebook.Delete((Course)list.SelectedItem);
            list.Items.Remove(list.SelectedItem);
        }

        private void Update_Button(object sender, RoutedEventArgs e)
        {
            Course? course = list.SelectedItem as Course;
            if (course != null) 
            {
                Update update = new Update(course, notebook, true);
                
                update.ShowDialog();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Course course = new Course();
            Update update = new Update(course, notebook, false);
            update.ShowDialog();
            DrawCourses();


        }
        private void DrawCourses()
        {
            list.Items.Clear();
            foreach (Course c in notebook.ListAll())
            {
                list.Items.Add(c);
            }
        }
    }
}
