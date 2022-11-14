using BorderControl.Models.Interfaces;

namespace BorderControl.Models
{
    public class Pet : IPet, ICreature
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }
        public string Name { get; private set; }

        public string BirthDate { get; private set; }
    }
}
