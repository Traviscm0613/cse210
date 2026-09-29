using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Horse Groomer";
        job1._company = "Bell Mountain Ranch";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "CarWash";
        job2._company = "Meadows Express Car Wash";
        job2._startYear = 2020;
        job2._endYear = 2022;
        
        Job job3 = new Job();
        job3._jobTitle = "Smoothies";
        job3._company = "Berry Blendz";
        job3._startYear = 2022;
        job3._endYear = 2023;
        
        Job job4 = new Job();
        job4._jobTitle = "Baker";
        job4._company = "Panera Bread";
        job4._startYear = 2025;
        job4._endYear = 2027;

        Resume myResume = new Resume();
        myResume._name = "Carter Travis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);

        myResume.Display();
    }
}