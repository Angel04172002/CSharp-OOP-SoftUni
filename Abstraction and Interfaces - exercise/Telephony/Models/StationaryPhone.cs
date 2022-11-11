using System.Linq;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string number)
        {
            if (!ValidatePhoneNumber(number))
            {
                return "Invalid number!";
            }

            return $"Dialing... {number}";
        }
        private bool ValidatePhoneNumber(string number)
        {
            return number.All(ch => char.IsDigit(ch));
        }
    }
}
