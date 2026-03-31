using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFFICE.Models
{
    class SMMManager:Employee
    {
        public double WorkHours { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Id} - {Firstname} - {Lastname} - {Phonenumber} - {Address} - {Email} - {WorkHours}");
        }
    }
}
