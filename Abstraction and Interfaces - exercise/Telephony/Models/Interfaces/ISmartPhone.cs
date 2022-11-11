namespace Telephony.Models.Interfaces
{
    public interface ISmartPhone : IStationaryPhone
    {
        string Browse(string url);
    }
}
