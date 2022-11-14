namespace BorderControl.Models.Interfaces
{
    public interface ICitizen : ICreature, IBuyer
    {
        string Id { get; }
        string BirthDate { get; }
    }
}
