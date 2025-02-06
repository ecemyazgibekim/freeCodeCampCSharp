using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    public class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            //gpa=90.4 gibi de yapabilirim
            if (gpa >= 3.5)  // gpayı kolayca değiştirebilirim sınırları kolayca değiştirebiliyorum kolaylık sağlayacak
            {
                return true;
            }
            return false;
        }
    }

}
