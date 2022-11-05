

namespace Zoo
{
    public class Gorilla : Mammal
    {
        public Gorilla(string name) : base(name)
        {
            Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
