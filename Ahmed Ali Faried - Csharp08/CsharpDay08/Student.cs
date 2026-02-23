using System;

namespace CsharpDay08
{
    #region Problem04
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
        public Student(Student other)
        {
            if (other != null)
            {
                Id = other.Id;
                Name = other.Name;
                Grade = other.Grade;
            }
        }

        public override string ToString()
        {
            return $"Student ID: {Id}, Name: {Name}, Grade: {Grade}";
        }
    } 
    #endregion

}