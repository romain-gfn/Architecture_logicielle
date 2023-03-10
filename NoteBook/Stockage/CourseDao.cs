using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metier;

namespace Stockage
{
    public class CourseDao : ICourseDao
    {
        private readonly SQLiteConnection connection;
        public CourseDao(string fileName)
        {
            connection = new SQLiteConnection(@"DataSource=" + fileName);
        }
        private Course Reader2Course(SQLiteDataReader reader)
        {
            Course prof = new Course();
            prof.Code = reader["Code"].ToString();
            prof.Name = reader["Name"].ToString();
            prof.Weight = Convert.ToInt32(reader["Weight"]);
            return prof;
        }
        public IEnumerable<Course> GetAll()
        {
            connection.Open();
            List<Course> courses = new List<Course>();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Course";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    courses.Add(Reader2Course(reader));
                }
            }
            connection.Close();
            return courses;
        }

        public Course[] ListAll()
        {
            return GetAll().ToArray(); 
        }


        public void Create(Course course)
        {
            throw new NotImplementedException();
        }

        public void Read(string course)
        {
            throw new NotImplementedException();
        }

        public void Update(Course t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course t)
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Course WHERE Code='" + t.Code + "';";
            command.ExecuteNonQuery();
            connection.Close();
        }

  
    }
}
