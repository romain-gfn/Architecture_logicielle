using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public interface ICourseDao
    {
        void Create(Course course);
        void Read(string course);
        void Update(Course t);
        void Delete(Course t);

        Course[] ListAll();
    }
}
