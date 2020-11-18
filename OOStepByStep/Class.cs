using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Class
    {
        private List<Student> students;
        private Teacher? teacher;
        private int classNumber;

        public Class(int classNumber)
        {
            this.classNumber = classNumber;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        public int GetClassNumber()
        {
            return classNumber;
        }
    }
}
