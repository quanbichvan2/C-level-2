using System.Text;
using System.Xml.Serialization;
using static Lab3.Models.Bai1;
using Lab3.UI;
using static Lab3.Models.Bai2;
using Lab3.Models;

namespace Lab3
{
    class Program
    {
        public static int choice;
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                do
                {
                    try
                    {
                        choice = Context.Menu(); 
                    }
                    catch (System.Exception)
                    {
                        choice = 5;
                    }
                    switch (choice)
                    {
                        case 1:
                            CreateStreamFile example1a = new CreateStreamFile();
                            example1a.StreamFile();
                            Context.Notification();
                            break; 
                        case 2:
                            StreamWriteAndReader example1b = new StreamWriteAndReader();
                            example1b.StreamFile();
                            Context.Notification();
                            break;
                        case 3:
                            TextWriterAndTextReader example1c = new TextWriterAndTextReader();
                            example1c.TextFile();
                            Context.Notification();
                            break;
                        case 4:
                            Bai2.CreateDirectory();
                            Bai2.CreateFile();
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
                    while (choice != 0) ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}