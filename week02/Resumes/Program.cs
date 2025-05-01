using System;

class Program
{
    static void Main(string[] args)
    {
        Resume userResume = new Resume();
        userResume._jobs.Add(new Job{_company = "LeVar Law", _jobTitle = "Investigator", _startYear = 2016, _endYear = 2025});
        userResume._jobs.Add(new Job{_company = "LDS Church", _jobTitle = "Missionary", _startYear = 2017, _endYear = 2019});

        userResume.DisplayJobDetails();
    }
}