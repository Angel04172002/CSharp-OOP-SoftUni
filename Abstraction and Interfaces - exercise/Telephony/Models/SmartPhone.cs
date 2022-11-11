using System.Linq;
using Telephony.Models.Interfaces;

namespace Telephony.Models
{
    public class SmartPhone : ISmartPhone
    {
        public string Browse(string url)
        {
            if(!ValidateUrl(url))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            if(!ValidatePhoneNumber(number))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        private bool ValidatePhoneNumber(string number)
        {
            return number.All(ch => char.IsDigit(ch));
        }

        private bool ValidateUrl(string url)
        {
            return url.All(ch => !char.IsDigit(ch));
        }
    }
}
