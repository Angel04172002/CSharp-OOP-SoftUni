using Telephony.IO.Interfaces;
using Telephony.Models.Interfaces;

namespace Telephony.Core.Interfaces
{
    public interface IEngine
    {
        void Run(IReader reader, IWriter writer, IStationaryPhone phone, ISmartPhone
             smartPhone);
    }
}
