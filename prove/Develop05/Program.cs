using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        string choice;
        string filename; 

        string name;
        string description;
        int points; 

        int bonus;
        int timesMax;

        while(true)
        {   
            Console.Clear();
            journal.DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            
            Console.WriteLine();
            // Create New Goal
            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create: ");
                choice = Console.ReadLine();

                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = int.Parse(Console.ReadLine());
                
                if (choice == "1")
                {
                    Simple simple = new Simple(name, description, points);
                    journal.AddGoal(simple);
                }
                else if (choice == "2")
                {
                    Eternal eternal = new Eternal(name, description, points);
                    journal.AddGoal(eternal);
                }
                else if (choice == "3")
                {   
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    timesMax = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    bonus = int.Parse(Console.ReadLine());

                    Checklist checklist = new Checklist(name, description, points, bonus, timesMax);
                    journal.AddGoal(checklist);
                }
                else
                {
                    Console.Write("That is not a valid option. Press Enter to go back to the menu ");
                    Console.ReadLine();
                }
            }
            // List Goals
            else if (choice == "2")
            {
                journal.DisplayList();

                Console.WriteLine();
                Console.Write("Press Enter to go back to the menu ");
                Console.ReadLine();
            }
            // Save Goals
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.Save(filename);
            }
            // Load Goals
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                journal.Load(filename);
            }
            // Record Event
            else if (choice == "5")
            {
                journal.DisplayListSimple();
                Console.WriteLine();
                Console.Write("Which goal did you accomplish? ");
                choice = Console.ReadLine();
                journal.SelectEvent(int.Parse(choice));
                
                Console.WriteLine();
                Console.Write("Press Enter to go back to the menu ");
                Console.ReadLine();
            }
            // Quit
            else
            {
                break;
            }
        }
    }
}