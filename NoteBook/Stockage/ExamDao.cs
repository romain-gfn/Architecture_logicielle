using Metier;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockage
{
    public class ExamDao : IExamDao
    {
        private readonly SQLiteConnection connection;
        public ExamDao(string fileName)
        {
            connection = new SQLiteConnection(@"DataSource=" + fileName);
        }
        private Exam Reader2Course(SQLiteDataReader reader)
        {
            Exam exam = new Exam();
            exam.Teacher = reader["Teacher"].ToString();
            exam.Coef = Convert.ToInt32(reader["Weight"]);
            return exam;
        }
        public void Create(Exam exam)
        {
            throw new NotImplementedException();
        }

        public Exam[] ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
