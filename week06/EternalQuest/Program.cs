using System;

public class Program
{
    public static void Main(string[] args)
    {
        DataManager dataManager = new DataManager();
        User currentUser = null;
        
        int choice = 0;
        //Login menu
        while (true)
        {
            Console.WriteLine("\n1.- Yes, I have an Account");
            Console.WriteLine("2.- No, I don't have an account");
            Console.WriteLine("3.- Quit");
            
            // Get user input
            string input = Console.ReadLine();
            
            // Try to parse the input to an integer
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    Console.Write("Introduce your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Introduce your password: ");
                    string password = Console.ReadLine();
                    
                    
                    if(dataManager.AuthenticateUser(username, password) == null)
                    {
                        
                        currentUser = dataManager.AuthenticateUser(username, password);
                        Console.WriteLine("try again.");
                    }
                    else 
                    {
                        break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Let's Create a new User");

                    Console.Write("Introduce your new username: ");
                    string username = Console.ReadLine();
                    Console.Write("Introduce your new password: ");
                    string password = Console.ReadLine();

                    User newUser = new User(username,password);
                    dataManager.AddOrUpdateUser(newUser);
                    Console.WriteLine($"User {username} created successfully!");

                    currentUser = newUser;
                    
                    break;
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exiting...");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            
        }
        GoalManager goalManager = new GoalManager(currentUser);
        goalManager.Start();
        
    //Eternal Quest Menu
        
        while (true)
        {
            goalManager.DisplayPlayerInfo();

            //Menu Interface
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Exit");
            
            string choiceMenu = Console.ReadLine();
            if (int.TryParse(choiceMenu, out choice))
            {

                if (choice == 1)
                {
                    
                    Console.Clear();
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal");

                    Console.WriteLine("Which type of goal would you like to create? ");
                    int typeofGoal = int.Parse(Console.ReadLine());

                    if (typeofGoal == 1)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string nameofGoal = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal? ");
                        string descriptionofGoal = Console.ReadLine();
                        Console.WriteLine("What is a amount of point associated with this goal? ");
                        int pointofGoal = int.Parse(Console.ReadLine());

                        SimpleGoal newGoal = new SimpleGoal(nameofGoal, descriptionofGoal, pointofGoal);

                        goalManager.CreateGoal(newGoal);

                    }
                    else if (typeofGoal == 2)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string nameofGoal = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal? ");
                        string descriptionofGoal = Console.ReadLine();
                        Console.WriteLine("What is a amount of point associated with this goal? ");
                        int pointofGoal = int.Parse(Console.ReadLine());

                        EternalGoal newGoal = new EternalGoal(nameofGoal, descriptionofGoal, pointofGoal);

                        goalManager.CreateGoal(newGoal);
                    }
                    else if (typeofGoal == 3)
                    {
                        Console.WriteLine("What is the name of your goal? ");
                        string nameofGoal = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal? ");
                        string descriptionofGoal = Console.ReadLine();
                        Console.WriteLine("What is a amount of point associated with this goal? ");
                        int pointofGoal = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                        int targetofGoal = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the bonus for accomplishing it many times?");
                        int bonusofGoal = int.Parse(Console.ReadLine());


                        ChecklistGoal newGoal = new ChecklistGoal(nameofGoal, descriptionofGoal, pointofGoal, targetofGoal, bonusofGoal);

                        goalManager.CreateGoal(newGoal);
                    }
                    else 
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }


                }
                else if (choice == 2)
                {
                    goalManager.ListGoals();
                    continue;
                }
                else if (choice == 3)
                {
                    goalManager.ListGoals();

                    Console.WriteLine("Which goal did you accomplished? ");
                    int goalChoice = int.Parse(Console.ReadLine());
                    int goalIndex = goalChoice - 1;
                    goalManager.RecordEvent(goalIndex);
                    continue;
                }
                else if (choice == 4)
                {
                    Console.WriteLine("See you soon!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }

        }
    }
}