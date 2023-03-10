using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Course
    {
        private string code;
        private string name;
        private int weight;

        public string Code
        {
            get { return code; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Le code du cours ne peut pas être vide.");
                }
                code = value;
            }
        }
        public string Name
        {
            get { return name; }
            set{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Le nom de la matière ne peut pas être vide.");
                }
                name = value;
            }
        }
        public int Weight
        {
            get { return weight; }
            set{
                if (value < 1 || value > 100)
                {
                    throw new ArgumentNullException("Le coefficient du cours doit être compris entre 1 et 100.");
                }
                
                weight = value;
            }
        }
        public override string ToString()
        {
            return this.code+ " " + this.name+ " " + this.weight;
        }
    }
}
