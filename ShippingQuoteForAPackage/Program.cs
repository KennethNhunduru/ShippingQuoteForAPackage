/*creation of a console-based application for getting a shipping quote for a package in C#.*/
using System;

namespace ShippingQuoteForAPackage
{
    class BranchingAssignmentSubmission
    {
        static void Main(string[] args)
        {
            //welcome page.
            Console.WriteLine("Welcome to Package Express. \nPlease follow the instructions below.");
            Console.WriteLine();
            
            //prompting for the weight of the package.
            Console.WriteLine("What is the weight of your package in lbs? /nEnter the weight: ");
            //creating an integer variable for the weight in kgs, obtaining the weight of the package from the keyboard and storing it.
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The weight of your package is :" + packageWeight + "lbs");
            Console.WriteLine();

            if (packageWeight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
            else
                {
                    Console.WriteLine();
                    //Prompting for package dimensions.
                    Console.WriteLine("What is the Width of your package in ins? /nEnter the Width: ");
                    //creating an integer variable for the package width in cms, obtaining the width of the package from the keyboard and storing it.
                    int packageWidth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is the Height of your package in ins? /nEnter the Height: ");
                    //creating an integer variable for the package height in cms, obtaining the height of the package from the keyboard and storing it.
                    int packageHeight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is the Length of your package in ins? /nEnter the Length: ");
                    //creating an integer variable for the package length in cms, obtaining the length of the package from the keyboard and storing it.
                    int packageLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    
                    if((packageWidth + packageHeight + packageLength) > 50)
                        {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        Console.ReadLine();
                        }
                    else
                        {
                        Console.WriteLine();
                        //creating an "double" type variable for the quote, calculating the quote to the and storing the result.
                        double packageQuote = ((packageWidth * packageHeight * packageLength) * packageWeight) / 100;
                        //Displaying the quote to the user.
                        Console.WriteLine("Your estimated total for shipping this package is: " + "$" + packageQuote + "\nThank you!");
                        }
                }

            Console.ReadLine();
        }
    }
}
