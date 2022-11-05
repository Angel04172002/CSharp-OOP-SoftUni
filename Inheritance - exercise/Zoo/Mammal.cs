
namespace Zoo
{
    public class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
            Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
