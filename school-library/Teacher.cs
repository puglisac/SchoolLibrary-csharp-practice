using System;
namespace school_library
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        public Teacher()
        {

        }
    }
}
