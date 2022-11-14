namespace BorderControl.Models.Interfaces
{
    public interface ICreature : IBuyer
    {
        string Name { get; }
        int Age { get; }

        //string BirthDate { get; }
    }
}
