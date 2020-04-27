using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Passenger
    {
        string LastName;
        string FirstName;
        float Age;
        string paxClass;
        bool isPassenger;
        string Role;
        bool Survivor;

        public Passenger(string lastName, string firstName, float age, string paxClass, bool isPassenger, string role, bool survivor)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            this.paxClass = paxClass;
            this.isPassenger = isPassenger;
            Role = role;
            Survivor = survivor;
        }

    }
}
