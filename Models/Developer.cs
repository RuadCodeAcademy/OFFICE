using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFFICE.Models
{
    class Developer:Employee
    {
        public string ProjectCount { get; set; }
        public string Speciality { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Id} - {Firstname} - {Lastname} - {Phonenumber} - {Address} - {Email} - {ProjectCount} - {Speciality}" );
        }
    }
}
