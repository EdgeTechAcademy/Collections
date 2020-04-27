using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"C:\Projects\csv\Titanic.csv";
            // Example #1
            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(fileName);

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of " + fileName + " = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(fileName);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of " + fileName + " = ");
            Boolean firstLine = true;
            List<Passenger> passengers = new List<Passenger>();
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }
                string[] props = line.Split(",");
                if (props[1].Length == 0) props[1] = "0";
                string[] names = props[0].Split("/");
                Passenger pax = new Passenger(names[0], names[1], float.Parse(props[1]), props[2], props[3].Equals("Passenger"), props[4], props[5].Equals("T"));
                passengers.Add(pax);
                // Use a tab to indent each line of the file.
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
