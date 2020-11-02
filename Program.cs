using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace SavageLab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, welcome to Scranton, which office member would you like to learn about?");
                List<string> names = new List<string>()
                {
                "Theresa",
                "Pam",
                "Robert",
                "Bob",
                "Michael",
                "Dwight",
                "Jim",
                "Phyillis",
                "Stanely",
                "Ryan",
                "Kelly",
                "Andy",
                "Creed",
                "Meredith",
                "Angela",
                "Kevin",
                "Oscar",
                "Toby",
                "Holly",
                "Erin",
                "Jan",
                };
                List<string> hometown = new List<string>()
                {
                "Detroit",
                "Ann Arbor",
                "Allen Park",
                "Scranton",
                "Johnstown",
                "Pittsburgh",
                "Phillidelphia",
                "Wayne",
                "Standford",
                "Wyandotte",
                "Grand Rapids",
                "Springfield",
                "Livonia",
                "Las Vegas",
                "Reno",
                "Los Angelas",
                "Traverse City",
                "Southfield",
                "Denver",
                "Miami",
                "Garden City",
                };
                List<string> favFoods = new List<string>()
                {
                "Nachos",
                "Spehgetti",
                "Chicken Alfredo",
                "Hot dogs",
                "Soft pretzels",
                "Chicken Parmesan",
                "Pizza",
                "Tacos",
                "Enchilados",
                "Double Cheeseburger",
                "Double fudge brownies",
                "Lasagna",
                "Chili",
                "Baby back ribs",
                "Chicken Fried Rice",
                "Shawarma",
                "Burritos",
                "Pulled Pork",
                "Chili Cheese Fries",
                "Waffles",
                "Pancakes",
                };

                var userContinue = true;

                while (userContinue)
                {
                    Console.WriteLine("Please enter a number between 1 - 20.");
                    var classmateChosen = int.Parse(Console.ReadLine());

                    if (classmateChosen > 20 || classmateChosen < 1)
                    {
                        Console.WriteLine("Office member does not exisit. Please try again.");
                        userContinue = true;
                    }

                    Console.WriteLine(names[classmateChosen - 1]);

                    var classmate = names[classmateChosen - 1];

                    var invalidInput = true;
                  while (invalidInput)
                  {

                        Console.WriteLine($"Would you like to know what {classmate}'s favorite food is or their hometown?");
                    Console.WriteLine($"[1]{classmate}'s Favorite Food");
                    Console.WriteLine($"[2]{classmate}'s Hometown");
                    var informationSelected = int.Parse(Console.ReadLine());


                        if (informationSelected == 1)
                        {
                            Console.WriteLine($"{classmate}'s favorite food is {favFoods[classmateChosen - 1]}!");
                            invalidInput = false;
                        }
                        else if (informationSelected == 2)
                        {
                            Console.WriteLine($"{classmate}'s hometown is {hometown[classmateChosen - 1]}");
                            invalidInput = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, please try again.");
                            invalidInput = true;
                        }
                  }

                    Console.WriteLine("Would you like to get to know another office memeber? [y/n]");
                    var userInput= Console.ReadLine();
                    if (userInput.Equals("yes", StringComparison.OrdinalIgnoreCase) || userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Thank you! Lets go again!");
                        userContinue = true;
                    }
                    else
                    {
                        Console.WriteLine("Thank you and have a great day!");
                        userContinue = false;
                    }

                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();
            }
            
  

        }
        
    }
}
