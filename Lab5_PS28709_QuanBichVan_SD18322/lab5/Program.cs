using lab5.Models;
using Lab5.UI;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using lab5.Models;
namespace lab5
{
    class Program
    {
        public static int choice;
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                var contacts = new List<Contact>
            {
                new Contact { Age = 11 , FirstName = "Trump", LastName = " Donald", Address = "Ha Noi"},
                new Contact { Age = 21 , FirstName = "Obama", LastName = " Barrack", Address = "Sai Gon"},
                new Contact { Age = 31 , FirstName = "Bush", LastName = " Geogre", Address = "Ha Noi"},
                new Contact { Age = 41 , FirstName = "Bill", LastName = " Clinton", Address = "Da Nang"},
                new Contact { Age = 51 , FirstName = "Reagan", LastName = " Ronald", Address = "Da Nang"},
                new Contact { Age = 61 , FirstName = "Jimmy", LastName = " Carter", Address = "Sai Gon"},
                new Contact { Age = 71 , FirstName = "Gerald", LastName = " Ford", Address = "Ha Noi"},
                new Contact { Age = 81 , FirstName = "Nixon", LastName = " Richard", Address = "Ha Noi"}
            };
                do
                {
                    try
                    {
                        choice = Context.Menu();
                    }
                    catch (System.Exception)
                    {
                        choice = 8;
                    }
                    switch (choice)
                    {
                        case 1:
                            var kt = from temp in contacts
                                     where temp.Address == "Ha Noi"
                                     select temp;
                            Context.CenterWrite(17);
                            foreach (var dc in kt)
                            {
                                Context.CenterWrite(17);
                                Console.WriteLine($"{dc.Age} | {dc.FirstName} | {dc.LastName} | {dc.Address}");
                            }
                            Context.Notification();
                            break;
                        case 2:
                            int Tuoi = contacts.Max(t => t.Age);
                            Context.CenterWrite(17);
                            Console.WriteLine("Số tuổi lớn nhất là: {0}", Tuoi);
                            Context.Notification();
                            break;
                        case 3:
                            int DS = contacts.Count();
                            Context.CenterWrite(17);
                            Console.WriteLine("Số người trong contacts là: {0}", DS);
                            Context.Notification();
                            break;
                        case 4:
                            var obj = contacts.OrderBy(x => x.Age);
                            foreach (var contact in obj)
                            {
                                Context.CenterWrite(17);
                                Console.WriteLine(contact.Age);
                            }
                            Context.Notification();
                            break;
                        case 5:
                            var ost = contacts.OrderBy(x => x.Age).ThenBy(x => x.FirstName);
                            foreach (var contact in ost)
                            {
                                Context.CenterWrite(17);
                                Console.WriteLine("Tuổi = {0} - FirstName: {1}", contact.Age, contact.FirstName);
                            }
                            Context.Notification();
                            break;
                        case 6:
                            var tk = from temp in contacts
                                     where temp.FirstName.StartsWith("B")
                                     select temp;
                            foreach (var ct in tk)
                            {
                                Context.CenterWrite(17);
                                Console.WriteLine($"{ct.Age} | {ct.FirstName} | {ct.LastName} | {ct.Address}");
                            }
                            Context.Notification();
                            break;
                        case 7:
                            var tlp = contacts.ToLookup(x => x.Address);
                            foreach (var tolookup in tlp)
                            {
                                Context.CenterWrite(17);
                                Console.WriteLine(tolookup.Key);
                                foreach (var tl in tlp[tolookup.Key])
                                {
                                    Context.CenterWrite(17);
                                    Console.WriteLine($"{tl.Age} | {tl.FirstName} | {tl.LastName} | {tl.Address}");
                                }
                            }
                            Context.Notification();
                            break;
                        case 0:
                            Context.EndingProgram();
                            System.Environment.Exit(0);
                            break;
                        default:
                            Context.NotificationError();
                            break;

                    }
                    Console.WriteLine();
                }
                while (choice != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}