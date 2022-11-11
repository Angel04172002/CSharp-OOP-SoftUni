using BorderControl.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Core.Interfaces
{
    public interface IEngine
    {
        void Run(IReader reader, IWriter writer);
    }
}
