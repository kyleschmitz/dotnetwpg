using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentIndex = GetIndex();
            int[,] grades = GetRecords();

            Console.WriteLine($"The average grade of student {studentIndex} is: {CalculateStudentAverage(grades, studentIndex)}");
            
            Console.WriteLine($"The class average is: {CalculateClassAverage(grades)}");

            Console.ReadKey();
        }

        static int GetIndex()
        {
            Console.Write("Please enter the index of the student: ");

            int index;
            while(!Int32.TryParse(Console.ReadLine(), out index))
                Console.Write("Invalid number, please enter the index of the student: ");

            return index;
        }

        static int[,] GetRecords()
        {
            int[,] grades = new int[5, 3];

            grades[0, 0] = 80;
            grades[0, 1] = 81;
            grades[0, 2] = 82;

            grades[1, 0] = 83;
            grades[1, 1] = 84;
            grades[1, 2] = 85;

            grades[2, 0] = 86;
            grades[2, 1] = 87;
            grades[2, 2] = 88;

            grades[3, 0] = 89;
            grades[3, 1] = 90;
            grades[3, 2] = 91;

            grades[4, 0] = 92;
            grades[4, 1] = 93;
            grades[4, 2] = 94;

            return grades;
        }

        static float CalculateStudentAverage(int[,] grades, int studentIndex)
        {
            int sum = 0;

            for (int i = 0; i < grades.GetLength(1); i++)
            {
                sum += grades[studentIndex, i];
            }

            return sum / (float)grades.GetLength(1);
        }


        static float CalculateClassAverage(int[,] grades)
        {
            int sum = 0;

            for(int i=0; i<grades.GetLength(0); i++)
            {
                for(int j=0; j<grades.GetLength(1); j++)
                {
                    sum += grades[i, j];
                }
            }

            return sum / (float)(grades.GetLength(0) * grades.GetLength(1));
        }
    }
}