
namespace Zoo
{
    public class Bear : Mammal
    {
        public Bear(string name) : base(name)
        {
            Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
