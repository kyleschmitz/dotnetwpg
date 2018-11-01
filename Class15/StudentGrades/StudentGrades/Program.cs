using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = GetOrderedStudents();
            PrintAllStudents(students);

            Console.ReadKey();
        }

        static Student[] GetOrderedStudents()
        {
            Student[] students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                Student newStudent = GetStudentFromKeyboard(i + 1);
                int positionToInsert = GetPositionToInsertStudent(students, i, newStudent);
                InsertStudentIntoArray(students, i, newStudent, positionToInsert);
            }

            return students;
        }

        static Student GetStudentFromKeyboard(int studentNumber)
        {
            Console.WriteLine();
            Console.Write($"Enter name for student {studentNumber}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter the grade for student {studentNumber}: ");
            int grade = 0;
            while (!Int32.TryParse(Console.ReadLine(), out grade))
            {
                Console.Write($"Enter the grade for student {studentNumber}: ");
            }

            return new Student(name, grade);
        }

        static int GetPositionToInsertStudent(Student[] students, int totalStudents, Student newStudent)
        {
            int index = totalStudents;

            for (int i = 0; i < totalStudents; i++)
            {
                if (students[i].Grade < newStudent.Grade)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static void InsertStudentIntoArray(Student[] students, int totalStudents, Student newStudent, int positionToInsert)
        {
            for (int i = totalStudents; i > positionToInsert; i--)
            {
                students[i] = students[i - 1];
            }
            students[positionToInsert] = newStudent;
        }

        static void PrintAllStudents(Student[] students)
        {
            Console.WriteLine();
            Console.WriteLine("The students in order of grades are:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
