using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamalpreetkaur_8806104_Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable to store the value of option selected from menu
            int select;

            // Getting the value of length and width from the user
            Console.WriteLine("Please input the length and width of the Rectangle");
            Console.WriteLine("Length:");
            string l = Console.ReadLine();

            //validating the value of length entered by user
            int length = validateInt(l);

            Console.WriteLine("Width:");
            string w = Console.ReadLine();

            //validating the value of width entered by user
            int width = validateInt(w);

            //creating a rectangle object
            Rectangle rectObj = new Rectangle();

            // setting lenth and width of the rectangle object
            rectObj.SetLength(length);
            rectObj.SetWidth(width);

            // displaying user the main menu and performing functions associated with those options
            do
            {
                select = showMenu();

                // condition for "Get the Rectangle Length" option from the menu
                if (select == 1)
                {
                    Console.WriteLine("Length of the Rectangle: " + rectObj.GetLength());
                }

                // condition for "Change Rectangle Length" option from the menu
                else if (select == 2)
                {
                    Console.WriteLine("Enter new length of Rectangle:");
                    string newLengthString = Console.ReadLine();
                    int newLength = validateInt(newLengthString);
                    rectObj.SetLength(newLength);
                }

                // condition for "Get the Rectangle Width" option from the menu
                else if (select == 3)
                {
                    Console.WriteLine("Width of the Rectangle: " + rectObj.GetWidth());
                    Console.WriteLine("");
                }

                // condition for "Change Rectangle Width" option from the menu
                else if (select == 4)
                {

                    Console.WriteLine("Enter new width of Rectangle:");
                    string widthInput = Console.ReadLine();
                    width = validateInt(widthInput);
                    rectObj.SetWidth(width);
                }

                // condition for "Get Rectangle Perimeter" option from the menu
                else if (select == 5)
                {
                    string perimeter = rectObj.GetPerimeter().ToString();
                    Console.WriteLine("The perimeter of Rectangle:" + perimeter);
                    Console.WriteLine("");
                }

                // condition for "Get Rectangle Area" option from the menu
                else if (select == 6)
                {
                    string area = rectObj.GetArea().ToString();
                    Console.WriteLine("The area of Rectangle:" + area);
                    Console.WriteLine("");
                }
                // condition for "Exit from the program" option from the menu
                else if (select == 7)
                {
                    Environment.Exit(0);
                }

            } while (select != 7);

            Console.WriteLine(select);
            Console.ReadLine();
        }
        public static int validateInt(string input)
        {
            int intValue;
            while (!int.TryParse(input, out intValue))
            {
                Console.WriteLine("Please provide a valid integer value.");
                input = Console.ReadLine();
                intValue = int.Parse(input);
            }
            return intValue;
        }

        public static int showMenu()
        {

            Console.WriteLine("*****Rectangle Menu:******");
            Console.WriteLine("1. Get the Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get the Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
            Console.WriteLine("***************");
            Console.WriteLine("");
            string selectedOption = Console.ReadLine();
            int select = validateOption(selectedOption);
            return select;

        }
        public static int validateOption(string selectedOption)
        {
            int input;
            int[] options = { 1, 2, 3, 4, 5, 6, 7 };
            while (!options.Contains(int.Parse(selectedOption)) || !int.TryParse(selectedOption, out input))
            {
                Console.WriteLine("Invalid option, Please select from list");
                showMenu();
                selectedOption = Console.ReadLine();
            }
            return input;
        }
    }
}
