using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Models
{
    public class Citizen : ICitizen, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string BirthDate { get; private set; }

        public int Food { get; private set; } = 0;

        public int BuyFood()
        {
            return 10;
        }
    }
}
