using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Passenger
    {
        string lastName;
        string firstName;
        float age;
        string paxClass;
        bool isPassenger;
        string role;
        bool survivor;

        public override string ToString()
        {
            return $"{firstName} {lastName} was a {paxClass} and " + (survivor?"survived":"did not survive");
        }

        public Passenger(string lastName, string firstName, float age, string paxClass, bool isPassenger, string role, bool survivor)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
            this.PaxClass = paxClass;
            this.IsPassenger = isPassenger;
            this.Role = role;
            this.Survivor = survivor;
        }

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public float Age { get => age; set => age = value; }
        public string PaxClass { get => paxClass; set => paxClass = value; }
        public bool IsPassenger { get => isPassenger; set => isPassenger = value; }
        public string Role { get => role; set => role = value; }
        public bool Survivor { get => survivor; set => survivor = value; }

        public static List<Passenger> LoadPassengers()
        {
            String fileName = @"C:\Projects\csv\Titanic.csv";

            // Read each line of the file into a string array. 
            // Each element of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(fileName);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of " + fileName);
            Boolean firstLine = true;
            List<Passenger> passengers = new List<Passenger>();

            foreach (string line in lines)
            {
                //Console.WriteLine(line);

                //  the first line is a header line, not data. Skip it
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }
                //  the data is comma separated. create an array of the properties from this line
                string[] props = line.Split(",");

                //  if the age field is empty set it to "0"
                if (props[1].Length == 0) props[1] = "0";

                //  the name field is both first and last name. They are separated with a slash
                string[] names = props[0].Split("/");

                //  create a passenger from the properties
                Passenger pax = new Passenger(names[0], names[1], float.Parse(props[1]), props[2], props[3].Equals("Passenger"), props[4], props[5].Equals("T"));

                //  add individual passenger to the list of passengers
                passengers.Add(pax);
            }
            return passengers;
        }
    }
}
