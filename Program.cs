using OFFICE.Models;

namespace OFFICE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> users = new List<Employee>();

            Developer developer1 = new()
            {
                Id = 1,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                ProjectCount = "3",
                Speciality = "IT",

                
            };

            Developer developer2 = new()
            {
                Id = 2,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                ProjectCount = "7",
                Speciality = "IT",

            };

            Developer developer3 = new()
            {
                Id = 3,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                ProjectCount = "5",
                Speciality = "IT",

            };

            users.Add(developer1);
            users.Add(developer2);
            users.Add(developer3);

            Manager manager1 = new()
            {
                Id = 4,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 1500
            };

            Manager manager2 = new()
            {
                Id = 5,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000.50
            };

            users.Add(manager1);
            users.Add(manager2);

            SMMManager smmmanager1 = new()
            {
                Id = 6,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                WorkHours = 8
            };

            SMMManager smmmanager2 = new()
            {
                Id = 7,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                WorkHours = 8
            };

            SMMManager smmmanager3 = new()
            {
                Id = 8,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                WorkHours = 8
            };

            SMMManager smmmanager4 = new()
            {
                Id = 9,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                WorkHours = 8
            };

            users.Add(smmmanager1);
            users.Add(smmmanager2);
            users.Add(smmmanager3);
            users.Add(smmmanager4);

            Saler saler1 = new()
            {
                Id = 10,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000,
                Benefit = 50
            };

            Saler saler2 = new()
            {
                Id = 11,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000,
                Benefit = 50
            };

            Saler saler3 = new()
            {
                Id = 12,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000,
                Benefit = 50
            };

            Saler saler4 = new()
            {
                Id = 13,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000,
                Benefit = 50
            };
            Saler saler5 = new()
            {
                Id = 14,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000,
                Benefit = 50
            };

            Saler saler6 = new()
            {
                Id = 15,
                Firstname = "Rauf",
                Lastname = "Bextiyyarli",
                Phonenumber = " 544565",
                Address = " baki",
                Email = " rauf123@gmail.com",
                Salary = 2000,
                Benefit = 50
            };

            users.Add(saler1);
            users.Add(saler2);
            users.Add(saler3);
            users.Add(saler4);
            users.Add(saler5);
            users.Add(saler6);


            foreach ( var user in users)
            {
                user.GetInfo();
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            foreach(var user in users)
            {
                if(user is Saler)
                {
                    Saler saler = (Saler)user;
                    saler.Salary=saler.Salary*1.1;
                    saler.GetInfo();
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();


            foreach (var user in users)
            {
                if (user is SMMManager)
                {
                    SMMManager workhours = (SMMManager)user;
                    workhours.WorkHours = workhours.WorkHours - 3;
                    workhours.GetInfo();
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            foreach (var user in users)
            {
                if(user is Developer)
                {
                    Developer developer = (Developer)user;
                    developer.ProjectCount = developer.ProjectCount + 2;
                    developer.GetInfo();
                }
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();

            foreach (var user in users)
            {
                if (user is Manager)
                {
                    Manager manager = (Manager)user;
                    manager.Salary = manager.Salary * 1.3;
                    manager.GetInfo();
                }
            }


















        }
    }
}
