
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Report_Card_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            // Develop a Student Report Card Application
            //initializing the totality of students
            var studentTotal = 0;

            Console.Write("Enter Total Students : ");
            studentTotal = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] studentNames = new string[studentTotal];

            int[] englishScore = new int[studentTotal];
            int[] mathScore = new int[studentTotal];
            int[] computerScore = new int[studentTotal];

            int[] totalScore= new int[studentTotal];


            //loops to iterate over each student’s score

            for (int i = 0; i < studentTotal; i++)
            {
                Console.Write("Enter Student Name : ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter English Marks (Out Of 100) : ");
                englishScore[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Enter Math Marks : ");
                mathScore[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Enter Computer Marks : ");
                computerScore[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("\n*********************************************");

                totalScore[i] = englishScore[i] + mathScore[i] + computerScore[i];
            }

            // show position and report card in descending order

            sortDescending(studentNames, totalScore);

            Console.WriteLine("****************Report Card********************");

            // Loop to Display Student Report Card

            for (int i = 0; i < studentTotal; i++)
            {
                Console.Write($"Student Name: { studentNames[i]}, Position: {i + 1}, Total: {totalScore[i]}/300");
                Console.WriteLine();
                Console.WriteLine("****************************************");
            }

        }

        
        static void sortDescending(string[] studentNames, int[] totalScore)
        {
            int num = totalScore.Length;

            int totalScoreSort;
            string studentNamesSort;

            for (int a = 0; a < num; a++)
            {
                for (int b = a + 1; b < num; b++)
                {
                    if (totalScore[a] < totalScore[b])
                    {
                        totalScoreSort = totalScore[a];
                        totalScore[a] = totalScore[b];
                        totalScore[b] = totalScoreSort;

                        studentNamesSort = studentNames[a];
                        studentNames[a] = studentNames[b];
                        studentNames[b] = studentNamesSort;
                    }

                }
            }
        }

    }
}