using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 =new Job();
        job1._JobTitle = "Project manager";
        job1._Company = "U.S. Air Force";
        job1._StartYear = 2012;
        job1._EndYear = 2017;

        Job job2 = new Job();
        job2._JobTitle = "Analyst";
        job2._Company = "CIA";
        job2._StartYear= 2018;
        job2._EndYear= 2023;

        Resume myResume = new Resume();
        myResume._name = "Mosiah Valdez";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}