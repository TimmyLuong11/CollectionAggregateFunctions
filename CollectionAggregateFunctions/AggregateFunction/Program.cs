using System;
using System.Collections.Generic;

namespace AggregateFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            List<double> grades = new List<double>();
            Dictionary<double, int> examGrade = new Dictionary<double, int>();
            string answer;
            double grade,sum = 0;
            int maxOccurrences = 0;

            //Asking the user for exam grades 
            Console.WriteLine("Please enter in your exam grade:");
            answer = Console.ReadLine();
            do
            {
                while (double.TryParse(answer,out grade)==false)
                {
                    Console.WriteLine("You did not enter in a grade. Please try again!");
                    answer = Console.ReadLine();
                }
                grades.Add(grade);
                if (examGrade.ContainsKey(grade) == false)
                {
                    examGrade.Add(grade, 1);
                }
                else
                {
                    examGrade[grade] += 1;
                }
                Console.WriteLine("Please enter in your next exam grade! Type \'q\' to quit.");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "q");

            //Calculating the min and max
            double min = grades[0], max = grades[0];
            foreach (double index in grades)
            {
                if (index < min)
                {
                    min = index;
                }
                else
                {
                    max = index;
                }
            }

            //Finding the total for the exam grades
            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }

            //Calculating the mode
            foreach (double key in examGrade.Keys)
            {
                double exam = key;
                if (examGrade[grade] > maxOccurrences)
                {
                    maxOccurrences = examGrade[grade];
                }
            }

            //Outputting the results to the user
            Console.WriteLine($"The minimum grade is {min.ToString("N2")}.");
            Console.WriteLine($"The maximum grade is {max.ToString("N2")}.");
            Console.WriteLine($"The average grade is {(sum / grades.Count).ToString("N2")}.");
            Console.WriteLine($"The grade that appears the most time is {grade.ToString("N2")} with {maxOccurrences} occurrence.");
           
        }
    }
}
