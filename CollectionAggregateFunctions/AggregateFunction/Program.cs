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
            string answer;
            double grade,sum = 0, index = 0, modeValue = 0, count;

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
                Console.WriteLine("Please enter in your next exam grade! Type \'q\' to quit.");
                answer = Console.ReadLine();
            } while (answer != "q");
            
            //Sortting the exam grade
            grades.Sort();

            //Finding the total for the exam grades
            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }

            //Calculating the mode
            for (int i = 0; i < grades.Count; i++)
            {
                count = 0;
                for (int j = 0; j < grades.Count; j++)
                {
                    if (grades[j] == grades[i])
                    {
                        ++count;
                    }
                }
                if (count > index)
                {
                    index = count;
                    modeValue = grades[i];
                }
            } 
           
            //Outputting the results to the user
            Console.WriteLine($"The min grade is {grades[0]}");
            Console.WriteLine($"The max grade is {grades[grades.Count-1]}");
            Console.WriteLine($"The avg grade is {(sum / grades.Count).ToString("N2")}");
            Console.WriteLine($"The mode grade is {modeValue}");
        }
    }
}
