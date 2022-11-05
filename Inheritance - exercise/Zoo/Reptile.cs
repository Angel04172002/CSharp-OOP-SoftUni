namespace Zoo
{
    public class Reptile : Animal
    {
        public Reptile(string name) : base(name)
        {
            Name = name;
        }
        public override string Name { get => base.Name; set => base.Name = value; }
    }
}
