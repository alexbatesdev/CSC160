using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Classes
    {
        public static void Execute()
        {
            myMath.CalcArea(4);
        }
    }

    class ExampleProps
    {
        public string prop1;
        private string prop2;

        public string prop3
        {
            get {
                return prop3;
            }
            set
            {
                prop3 = value;
            }
        }

    }

    class Student
    {
        protected string name;
        protected int cohort = 37;
        protected float gpa;
        static int numberOfStudents = 0;

        public int age { get; set; } = 21;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set {
                if (value >= 0 && value <= 4.0) gpa = value;

            }
        }

        public Student()
        {
            age = 26;
            numberOfStudents++;
        }

        public Student(string name, int cohort, float gpa = 2.5f)
        {
            this.name = name;
            this.cohort = cohort;
            this.gpa = gpa;
            numberOfStudents++;
        }

        public void HowManyStudents()
        {
            Console.WriteLine($"Num of Students: {numberOfStudents}");
        }
    }

    static class myMath
    {
        public const float PI = 3.1415926f;

        public static float CalcArea(float radius)
        {
            return (float) Math.Pow((2 * PI * radius), 2);
        }
    }


}
