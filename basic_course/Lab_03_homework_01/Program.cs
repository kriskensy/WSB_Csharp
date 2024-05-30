using System;
using System.Collections.Generic;

namespace Lab_03_homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("KK007", "Brzeczyszczykiewicz");

            student.newGradeAdd(4);
            student.newGradeAdd(3);
            student.newGradeAdd(5);
            student.newGradeAdd(4);
            student.newGradeAdd(5);

            student.displayStudentsGrades();

            Console.WriteLine($"Grade form indeks 1: {student[1]}");
            Console.WriteLine($"Grade from indeks 6: {student[6]}");
        }
    }

    public class Student
    {
        private string studentID;
        private string name;
        private List<int> studentGradeList;

        public Student(string studentId, string name)
        {
            studentID = studentId;
            this.name = name;
            studentGradeList = new List<int>();
        }

        public void newGradeAdd(int grade)
        {
            studentGradeList.Add(grade);
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < studentGradeList.Count)
                {
                    return studentGradeList[index];
                }
                else
                {
                    Console.WriteLine("Wrong index, returning default value.");
                    return -1;
                }
            }
        }

        public void displayStudentsGrades()
        {
            Console.WriteLine($"List of grades for student {name} with ID: {studentID}");
            foreach (var grade in studentGradeList)
            {
                Console.Write(grade + " ");
            }

            Console.WriteLine();
        }
    }
}