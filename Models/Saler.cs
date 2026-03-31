using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFFICE.Models
{
    class Saler:Employee
    {
        public double Salary { get; set; }

        public double Benefit { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Id} - {Firstname} - {Lastname} - {Phonenumber} - {Address} - {Email} - {Salary} - {Benefit}");
        }
    }
}
