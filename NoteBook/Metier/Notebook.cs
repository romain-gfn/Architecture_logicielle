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

        Course CreateCourse()
        {
            return new Course();
        }
        void ModifyCourse(Course t)
        {
            courseDao.Update(t);
        }

        void RemoveCourse(Course t) {
            courseDao.Delete(t);
        }

        public Course[] ListAll()
        {
            return courseDao.ListAll();
        }

        public void Create(Course course)
        {
            courseDao.Create(course);
        }

        public void Read(string course)
        {
            courseDao.Read(course);
        }

        public void Update(Course t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course t)
        {
            throw new NotImplementedException();
        }
    }
}
