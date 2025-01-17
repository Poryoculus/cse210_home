using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Sony";
        job1._jobTitle = "Data Analyst";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Data Scientist";
        job2._startYear = 2010;
        job2._endYear = 2020; 

        Resume resume1 = new Resume();
        resume1._name = "Juan Albercado";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}