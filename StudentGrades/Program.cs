using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
Name: Victor Jdanovitch
Date Modified: 07/24/2016
Student#: 300869472
Description: Assignment 5 - Array and List Practice
 */
namespace COMP123_S2016_ASSIGNMENT_5
{
    class Program
    {
        /**
        * @static
        * @method Main
        * @returns {void}
        */
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        /**
* <summary>
* This method displays the menu using a while loop
* </summary>
* 
* @static
* @method DisplayMenu
* 
* @returns {void}
*/
        static void DisplayMenu()
        {
            bool ContinueLoop = true;
            while (ContinueLoop == true)
            {
                Console.WriteLine("   1. Display Grades");
                Console.WriteLine("   2. Exit");
                Console.WriteLine("   Please Select Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayGrades();
                        break;
                    case 2:
                        ContinueLoop = false;
                        break;
                }

            }
        }
        /**
         * <summary>
         * This method displays the menu using a while loop placed in a try and catch.
         * </summary>
         * 
         * @static
         * @method DisplayGrades
         * 
         * @returns {void}
         */
        static void DisplayGrades()
        {
            FileStream inFile;
            StreamReader reader;
            try
            {
                Console.WriteLine("What is the name of the file?");
                string file = "..\\..\\";
                file += Console.ReadLine();
                file += ".txt";
                inFile = new FileStream(file, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                string recordString = reader.ReadLine();
                string[] Fields = new string[5];
                int counter = 0;
                while (recordString != null)

                {

                    Fields[counter++] = recordString;

                    recordString = reader.ReadLine();

                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(Fields[i]);

                }
                reader.Close();
                inFile.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Error: No Such File");
            }
        }

    }

}
