using Metier;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockage
{
    public class ExamDao : IExamDao
    {
        private readonly SQLiteConnection connection;
        private CourseDao courseDao;
        public ExamDao(string fileName)
        {
            connection = new SQLiteConnection(@"DataSource=" + fileName);
        }
        private Exam Reader2Exam(SQLiteDataReader reader)
        {
            Exam prof = new Exam(courseDao.Read(reader["CourseCode"].ToString()));
            prof.Teacher = reader["Teacher"].ToString();
            prof.DateExam = DateTime.ParseExact(reader.GetString(reader.GetOrdinal("DateExam")), "yyyy-dd-MM", CultureInfo.InvariantCulture);
            prof.Score = (float)(reader.IsDBNull(reader.GetOrdinal("Score")) ? null : (float?)reader.GetDouble(reader.GetOrdinal("Score")));
            prof.Coef = Convert.ToInt32(reader["Coef"]);
            return prof;

        }
        public void Create(Exam exam)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exam> GetAll()
        {
            connection.Open();
            List<Exam> exam = new List<Exam>();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Exam";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    exam.Add(Reader2Exam(reader));
                }
            }
            connection.Close();
            return exam;
        }

        public Exam[] ListAll()
        {
            return GetAll().ToArray();
        }
    }
}
