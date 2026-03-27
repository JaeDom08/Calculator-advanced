using System;
using System.Text.RegularExpressions;

class Program {
    // The Main method is the starting point of your app
    static void Main(string[] args) {
        bool run = true;
        while (run)
        {
            Console.Clear();
            Console.WriteLine("Please select: C for Cal, S for School Cal, P for password or X to Exit");
            string choice = Console.ReadLine().ToUpper();
        
            switch (choice)
            {
                case "C":
                AdvancedCalculator();
                break;
                case "S":
                SchoolCalculator();
                break;
                case "P":
                PasswordCreate();
                break;
                case "X":
                run = false;
                break;
                default:
                Console.WriteLine("Invalid choice. Please select C, S, or P.");
                break;
            }
        }

    }

    static void AdvancedCalculator() {
        bool keepRunning = true;

        while (keepRunning) {
            Console.WriteLine("Welcome to Advanced Calculator");
            
            Console.Write("1st number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2nd number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Select an operation (+, -, *, /): ");
            string operation = Console.ReadLine();

            // Logic for operations
            if (operation == "+") {
                Console.WriteLine("Result: " + (num1 + num2));
            } 
            else if (operation == "-") {
                Console.WriteLine("Result: " + (num1 - num2));
            } else if (operation == "*") {
                Console.WriteLine("Result: " + (num1 * num2));
            } else if (operation == "/") {
                if (num2 != 0) {
                    Console.WriteLine("Result: " + (num1 / num2));
                } else {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
            } else {
                Console.WriteLine("Invalid operation.");
            }

            // Ask to continue
            Console.Write("Continue? (y/n): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "y") {
                keepRunning = false;
            }
        }

    }

    static void SchoolCalculator()
    {
        bool keepRunning = true;

        Console.WriteLine("Welcome to School Calculator");

        while (keepRunning == true) {
            Console.Write("Enter your grade percentage: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 101 || grade < 0) {
                Console.WriteLine("enter a value between 0 and 100.");
            }
            else if (grade >= 85 && grade <= 100) 
            {
                Console.WriteLine("Grade : High Distinction");
            } else if (grade >= 75) {
                Console.WriteLine("Grade : Distinction");
            } else if (grade >= 65) {
                Console.WriteLine("Grade : Credit");
            } else if (grade >= 55) {
                Console.WriteLine("Grade : Pass");
            } else if (grade <= 54) {
                Console.WriteLine("Grade : Fail");
            }

            Console.Write("Continue? (y/n): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "y") {
                keepRunning = false;    
            }

        }

            
    }

    static void PasswordCreate()
    {   string Mpassword = "";
        bool MainPass = true;
        int checker = 0;
        bool access = false;

        while (MainPass == true)
        {
            Console.Write("Enter a password: ");
            Mpassword = Console.ReadLine();
            IsAlphanumeric(Mpassword);

            if (!IsAlphanumeric(Mpassword))
            {
                Console.WriteLine("Password must include letters, numbers and a special character.");
                continue;
            }
            
            Console.WriteLine("Password created successfully.");
            Console.WriteLine("Please re-enter your password to access the system.");
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            MainPass = false;
            Console.Clear();
            break;
            
        }

        while (checker < 3 && !access)
        {
            Console.Write("Re-Enter password: ");
            string Rpassword = Console.ReadLine();
            

            if (Rpassword == Mpassword)
            {
                checker++;
                Console.WriteLine($"Correct password {checker}/3");
                if (checker == 3)
                {
                    Console.WriteLine("Access granted.");
                    access = true;
                    break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
                checker = 0;
            }
        }

        
    }

    public static bool IsAlphanumeric(string str)
    {
        return Regex.IsMatch(str, @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*]).+$");
    }
       
}