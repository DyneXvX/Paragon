using System;
using System.Threading;

namespace Paragon
{
    
    public class UserInterface
    {
        

        public void Run()
        {
            var user = new Person();
            Console.WriteLine("Welcome to the Paragon System build.");
            Console.WriteLine("What is your user name?");
            while (true)
            {
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("You must input your user name");
                    
                }
                else
                {
                    var loginName = user.Name(name);
                    AccessChecker(loginName);
                    Menu(loginName);
                }
            }
        }
        public void AccessChecker(string loginName)
        {
            Console.WriteLine("Processing User ID");
            Thread.Sleep(1000);
            Console.WriteLine("..................");
            Thread.Sleep(1000);
            Console.WriteLine("User Processed");
            Thread.Sleep(1000);

            if (loginName == "noAccess")
            {
                Console.WriteLine("You are not allowed access to this system.");
                Console.WriteLine("-----------");
                Console.WriteLine("Closing Now");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Access Granted {0}, Welcome", loginName);
                Console.WriteLine();
            }
        }
        public void Menu(string loginName)
        {
            var programs = new Programs();
            while (true)
            {
                if (loginName == "Master")
                {
                    Console.WriteLine("---------Master Menu----------");
                    Console.WriteLine("1: Open Outlook");
                    Console.WriteLine("2: Open Steam");
                    Console.WriteLine("3: Open PowerDVD");
                    Console.WriteLine("4: Custom Calculator (Beta Testing)");
                    Console.WriteLine("5: Log Out");
                    Console.WriteLine("6: Exit Paragon");
                    Console.WriteLine("-----------------------------");
                    var input = Console.ReadLine();
                    if (input != null)
                    {
                        var choice = input.ToLower();

                        Console.WriteLine();
                        switch (choice)
                        {
                            case "1":
                            case "outlook":
                                {
                                    programs.Outlook();
                                    break;
                                }

                            case "2":
                            case "steam":
                                {
                                    programs.Steam();
                                    break;
                                }
                            case "3":
                            case "powerdvd":
                                {
                                    programs.PowerDvd();
                                    break;
                                }
                            case "4":
                            case "calculator":
                            {
                                programs.Calculator();
                                break;
                            }
                            case "5":
                            case "log out":
                            {
                                Console.WriteLine("Logging Out {0}", loginName);
                                Thread.Sleep(1000);
                                Run();
                                break;
                            }
                            case "6":
                                {
                                    Console.WriteLine("Good by {0} I hope you enjoy your day", loginName);
                                    Console.WriteLine("Exiting System" +
                                                      "\nThank you");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You must input a choice from the menu.");
                                    break;
                                }
                        }
                    }

                }
                else
                {
                    Console.WriteLine("------------Menu-------------");
                    Console.WriteLine("1: Open Outlook");
                    Console.WriteLine("2: Open Steam");
                    Console.WriteLine("3: Log Out");
                    Console.WriteLine("4: Exit Paragon");
                    Console.WriteLine("-----------------------------");

                    var input = Console.ReadLine();
                    if (input != null)
                    {
                        var choice = input.ToLower();

                        Console.WriteLine();
                        switch (choice)
                        {
                            case "1":
                            case "outlook":
                                {
                                    programs.Outlook();
                                    break;
                                }

                            case "2":
                            case "steam":
                                {
                                    programs.Steam();
                                    break;
                                }
                            case "3":
                            case "log out":
                            {
                                Console.WriteLine("Logging Out {0}", loginName);
                                Thread.Sleep(1000);
                                Run();
                                break;
                            }
                            case "4":
                                {
                                    Console.WriteLine("Good by {0} I hope you enjoy your day", loginName);
                                    Console.WriteLine("Exiting System" +
                                                      "\nThank you");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("You must input a choice from the Menu");
                                    break;
                                }
                        }
                    }
                }
            }

        }
    }
}