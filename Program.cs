using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new ITCompanyEntities())

            {
                Console.WriteLine("Select table: 1 - Projects, 2 - People");
                int table = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select action: 1 - Add, 2 - Update, 3 - Delete");
                int action = Convert.ToInt32(Console.ReadLine());


                switch (action)
                {
                    case 1:
                        if (table == 1)
                        {
                            ctx.Projects.Add(new Projects() { ProjectName = "Trynow", CustomerName = "John", StartDate = DateTime.Now });

                        }
                        else
                        {
                            ctx.People.Add(new People() { FirstName = "Olena", LastName = "Hul", Role = "Python developer" });
                        }
                        ctx.SaveChanges();
                        Console.WriteLine("New entity was successfully added");
                        break;
                    case 2:
                        if (table == 1)
                        {
                            var project = ctx.Projects.FirstOrDefault();
                            project.ProjectName = "Newsoft inside";

                        }
                        else
                        {
                            var person = ctx.People.FirstOrDefault();
                            person.FirstName = "Olenaaaaaa";
                        }
                        ctx.SaveChanges();
                        Console.WriteLine("Entity was successfully updated");
                        break;
                    case 3:
                        if (table == 1)
                        {
                            var project = ctx.Projects.FirstOrDefault();
                            ctx.Projects.Remove(project);

                        }
                        else
                        {
                            var person = ctx.People.FirstOrDefault();
                            ctx.People.Remove(person);
                        }
                        ctx.SaveChanges();
                        Console.WriteLine("Entity was successfully deleted");
                        break;
                }
            }
        }
    }

}
