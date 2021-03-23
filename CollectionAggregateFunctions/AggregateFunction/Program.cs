﻿using System;
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
                    examGrade[grade] = examGrade[grade] + 1;
                }
                Console.WriteLine("Please enter in your next exam grade! Type \'q\' to quit.");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "q");
            

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

            //Sortting the exam grade
            grades.Sort();

            //Outputting the results to the user
            Console.WriteLine($"The minimum grade is {grades[0]}.");
            Console.WriteLine($"The maximum grade is {grades[grades.Count-1]}.");
            Console.WriteLine($"The average grade is {(sum / grades.Count).ToString("N2")}.");
            Console.WriteLine($"The grade that appears the most time is {grade} with {maxOccurrences} occurrence.");
        }
    }
}
