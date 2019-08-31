using System;
using System.Collections.Generic;
using System.Text;

namespace Company
{
    enum JobTitle
    {
        Manager,
        Supervisor,
        Employee
    }

    class Employee
    {
        public string Name { get; set;}
        public JobTitle Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string name, JobTitle title, DateTime startDate)
        {
            Name = name;
            Title = title;
            StartDate = startDate;
        }
        
    }
}
