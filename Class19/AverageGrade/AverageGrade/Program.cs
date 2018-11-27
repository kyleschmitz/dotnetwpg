using System;

namespace AverageGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades1 = {100, 50, 20};
            int[] grades2 = new int[0];
            int[] grades3 = null;

            SampleTryCatch(grades1);
            SampleTryCatch(grades2);
            SampleTryCatch(grades3);

            Console.ReadKey();
        }

        static void SampleTryCatch(int[] grades)
        {
            try
            {
                int average = CalculateAverageGrade(grades);
                Console.WriteLine("Average grade is: " + average);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The array that has been passed is empty - " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("The array that has been passed is null - " + ex.Message);
            }

        }

        static int CalculateAverageGrade(int[] grades)
        {
            int total = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }

            return total / grades.Length;
        }
    }
}