
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the student's name:");
        string name = Console.ReadLine();
        Student student = new Student(name);
        List<double> scores = student.ReadScores();
        double avg = student.calculateAverage(scores);
        string letterGrade = student.DetermineGrade(avg);
        student.printStudentInfo(name, avg, letterGrade);

    }
}

