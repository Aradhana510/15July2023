using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize jagged array with student scores
        int[][] studentScores = new int[3][]
        {
            new int[] { 85, 92, 78 },
            new int[] { 90, 87, 93, 89 },
            new int[] { 76, 88 }
        };

        // Print scores of each student
        for (int i = 0; i < studentScores.Length; i++)
        {
            Console.WriteLine("Student " + (i + 1) + " scores:");
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                Console.Write(studentScores[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        // Calculate and print average score for each student
        for (int i = 0; i < studentScores.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                sum += studentScores[i][j];
            }
            double average = (double)sum / studentScores[i].Length;
            Console.WriteLine("Average score for Student " + (i + 1) + ": " + average.ToString("0.00"));
        }

        Console.WriteLine();

        // Calculate and print average score for all students combined
        int totalSum = 0;
        int totalCount = 0;

        for (int i = 0; i < studentScores.Length; i++)
        {
            for (int j = 0; j < studentScores[i].Length; j++)
            {
                totalSum += studentScores[i][j];
                totalCount++;
            }
        }

        double totalAverage = (double)totalSum / totalCount;
        Console.WriteLine("Average score for all students combined: " + totalAverage.ToString("0.00"));

        Console.ReadLine();
    }
}