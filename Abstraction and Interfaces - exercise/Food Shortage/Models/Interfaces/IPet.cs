namespace BorderControl.Models.Interfaces
{
    public interface IPet : ICreature
    {
        string Name { get; }
        string BirthDate { get; }

    }
}
