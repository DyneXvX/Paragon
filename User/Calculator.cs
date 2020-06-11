using System;
using System.Collections.Generic;

namespace Paragon
{
    public class Calculator
    {
        public void CalculatorBuild()
        {
            UserInterface resetInterface = new UserInterface();
            while (true)
            {
                
                Console.WriteLine("What do you need today?");
                
                LoopStart:
                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine("1: Addition");
                Console.WriteLine("2: Subtraction");
                Console.WriteLine("3: Multiple");
                Console.WriteLine("4: Division");
                Console.WriteLine("5: Main Menu");
                Console.WriteLine("--------------");
                var input = Console.ReadLine();

                if (input != null)
                {
                    var lower = input.ToLower();
                    switch (lower)
                    {
                        case "1":
                        case "addition":
                        {
                            Addition();
                            break;
                        }
                        case "2":
                        case "subtraction":
                        {
                            Subtraction();
                            break;
                        }
                        case "3":
                        case "multiple":
                        {
                            Multiple();
                            break;
                        }
                        case "4":
                        case "division":
                        {
                            Division();
                            break;
                        }
                        case "5":
                        case "return":
                        case "menu":
                        {
                            return;
                        }
                        default:
                            Console.WriteLine("Pick your Selection from above");
                            goto LoopStart;
                            
                    }
                }
                AnotherCalculation:
                Console.WriteLine("Do you need to another calculation? Y or N");
                while (true)
                { 
                    
                    try
                    {
                        var answer = Console.ReadLine();
                        if (string.IsNullOrEmpty(answer))
                        {
                            Console.WriteLine("Y or N only");
                            goto AnotherCalculation;
                        }
                        else if (answer == "N" || answer == "n")
                        {
                            return;
                        }
                        goto LoopStart;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Mistype: Y/N Only please");

                    }
                }
            }

        }
        public double Addition()
        {
            var values = new List<double>();
            var results = 0.00;
            var error = false;
            while (true)
            {
                Console.WriteLine("Input your numbers to add separated by a space");
                var input = Console.ReadLine().Split(',', ' ', '+');
                foreach (var number in input)
                {
                    try
                    {
                        var numbers = Convert.ToDouble(number);
                        values.Add(numbers);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can only use numbers here.");
                        error = true;
                        break;
                    }
                    error = false;
                }

                if (error == false)
                {
                    foreach (var value in values)
                    {
                        results = results + value;
                    }

                    Console.WriteLine("Your numbers added together equal {0}", results);
                    return results;
                }
            }

        }
        public double Subtraction()
        {
            var values = new List<double>();
            var error = false;
            while (true)
            {
                Console.WriteLine("Input numbers with spaces please");
                var input = Console.ReadLine().Split(',', ' ', '-');

                foreach (var number in input)
                {
                    try
                    {
                        var numbers = Convert.ToDouble(number);
                        values.Add(numbers);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can only use numbers here");
                        error = true;
                        break;
                    }
                    error = false;
                }

                if (error == false)
                {
                    var results = values[0];
                    for (int i = 1; i < values.Count; i++)
                    {
                        results = results - values[i];
                    }

                    Console.WriteLine("Your numbers subtracted equals {0}", results);
                    return results;
                }
            }
        }
        public double Multiple()
        {
            var values = new List<double>();
            var error = false;
            while (true)
            {
                Console.WriteLine("Input the numbers with spaces or commas please");
                var input = Console.ReadLine().Split(',' ,' ', '*');

                foreach (var number in input)
                {
                    try
                    {
                        var numbers = Convert.ToDouble(number);
                        values.Add(numbers);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Only Numbers Please");
                        error = true;
                        break;
                        
                    }
                    error = false;

                }

                if (error == false)
                {
                    var results = values[0];
                    for (var i = 1; i < values.Count; i++)
                    {
                        results *= values[i];
                    }

                    Console.WriteLine("The numbers multiplied together equal: {0}", results);
                    return results;
                }
            }
        }

        public double Division()
        {
            var values = new List<double>();
            var error = false;
            while (true)
            {
                Console.WriteLine("Input the numbers with spaces or commas please");
                var input = Console.ReadLine().Split(',', ' ', '/');

                foreach (var number in input)
                {
                    try
                    {
                        var numbers = Convert.ToDouble(number);
                        values.Add(numbers);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Only Numbers Please");
                        error = true;
                        break;

                    }
                    error = false;

                }
                if (error == false)
                {
                    var results = values[0];
                    for (var i = 1; i < values.Count; i++)
                    {
                        results /= values[i];
                    }

                    Console.WriteLine("The numbers divided equal: {0}", results);
                    return results;
                }
            }
        }
    }
}