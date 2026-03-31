using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFFICE.Models
{
    class Manager:Employee
    {
        public double Salary { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Id} - {Firstname} - {Lastname} - {Phonenumber} - {Address} - {Email} - {Salary}");
        }
    }
}
