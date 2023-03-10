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

    }
}
