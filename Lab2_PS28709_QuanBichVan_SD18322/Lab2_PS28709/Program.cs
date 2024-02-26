using System;
using System.Collections.Generic;
using static Lab2_PS28709.Models.Bai1;
using static Lab2_PS28709.Models.Bai2;

namespace Lab2_PS28709
{
    public class Program
    {
        public static void WaitAndClearConsole()
        {
            Console.WriteLine("Press any key for continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Run ImplictlyVariable");
                Console.WriteLine("2. Run DictionaryExample");
                Console.WriteLine("3. Run Dynamic");
                Console.WriteLine("4. Run Test Method");
                Console.WriteLine("5. Run UserInfoExample");
                Console.WriteLine("6. Run UserInfoExampleVer2 have job info designation and location");
                Console.WriteLine("7. Run MathDelegateExample");
                Console.WriteLine("8. Exit");
                Console.WriteLine("Enter your choice:");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ImplictlyVariable.Run();
                        WaitAndClearConsole();
                        break;
                    case "2":
                        RunDictionaryExample example = new RunDictionaryExample();
                        example.Run();
                        WaitAndClearConsole();
                        break;
                    case "3":
                        RunDynamic runDynamic = new RunDynamic();
                        runDynamic.Run();
                        WaitAndClearConsole();
                        break;
                    case "4":
                        RunTestMethod runMethod = new RunTestMethod();
                        runMethod.Run();
                        WaitAndClearConsole();
                        break;
                    case "5":
                        UserInfoExample exampleUser = new UserInfoExample();
                        exampleUser.Run();
                        WaitAndClearConsole();
                        break;
                    case "6":
                        UserInfoExampleVer2 userVer2 = new UserInfoExampleVer2();
                        userVer2.Run();
                        WaitAndClearConsole();
                        break;
                    case "7":
                        MathDelegateExample mathExample = new MathDelegateExample();
                        mathExample.MathOperationsExample();
                        WaitAndClearConsole();
                        break;
                    case "8":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
