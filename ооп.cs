using System;

namespace ClassLibrary2
{
    public class UniversityPeople
    {
        protected string name;
        protected double yearsInUni;
        public function constructor() { }

    }
    class Student :UniversityPeople
    {
        protected int numberGroup;
        sealed public override void money()
        {
            Console.WriteLine("стипендия");
        }
    }
    class Teacher : UniversityPeople
    {
        public int numberOfStudents;
        sealed public override void money()
        {
            Console.WriteLine("зарплата");
        }
    }
}
