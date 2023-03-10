using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Notebook : ICourseDao
    {
        private ICourseDao courseDao;

        public Notebook(ICourseDao courseDao, string fileName)
        {
            this.courseDao = courseDao;
        }
    }
}
