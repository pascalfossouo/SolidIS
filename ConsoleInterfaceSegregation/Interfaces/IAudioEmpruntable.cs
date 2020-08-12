using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation.Interfaces
{
    public interface IAudioEmpruntable : IAudio, IEmpruntable
    {
    }
}
