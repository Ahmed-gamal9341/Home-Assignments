
using System;
using System.Collections.Generic;
class Student
{
    private string Name { get; set; }
    private List<double> grades = new List<double>();

    public Student(string name)
    {
        Name = name;
    }
    public List<double> ReadScores()
    {
        double score;
        List<double> scores = new List<double>();
        Console.Write("Enter score (0-100): ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter score (0-100): ");
            if (double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
            {
                scores.Add(score);
            }
            else
                Console.WriteLine("Invalid score. Try again.");
        }
        return scores;
    }

    public double calculateAverage(List<double> Scores)
    {
        double sum = 0;
        foreach (var score in Scores)
        {
            sum += score;
        }
        return sum / Scores.Count;
    }

    public string DetermineGrade(double avg)
    {
        var grade = avg switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
        return grade;
    }

    public void printStudentInfo(string name, double average, string letterGrade)
    {
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Average Grade: {average:F2}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
    }
}

