using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Exam
    {
        private float score;
        private string teacher;
        private DateTime dateExam;
        private int coef;
        private Course course;

        public Exam(Course course) {
            this.course = course;
        }

        public float Score
        {
            get { return score; }
            set {
                if (score > 20 & score < 0)
                {
                    throw new ArgumentNullException("Le score doit etre entre 0 et 20.");
                }

                score = value;
            }
        }

        public string Teacher
        {
            get { return teacher; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Il ne peut pas ne pas y avoir de prof");
                }
                teacher = value;
            }
        }
        public DateTime DateExam
        {
            get { return dateExam; }
            set {
                if (dateExam > DateTime.Now)
                {
                    throw new ArgumentNullException("l'examin ne peut pas etre dans le passé ");
                }
                this.dateExam = value;
            }
        }
        public int Coef
        {
            get { return coef; }
            set {
                if (coef > 20 & coef < 0)
                {
                    throw new ArgumentNullException("Le coef doit etre entre 0 et 20.");
                }

                coef = value;
            }
        }
        public override string ToString()
        {
            return this.score + " " + this.teacher + " " + this.dateExam  + " " + this.coef;
        }

    }
}
