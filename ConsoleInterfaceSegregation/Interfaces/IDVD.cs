using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation.Interfaces
{
    public interface IDVD : ILibraryItem
    {
        List<string> Auteurs { get; set; }
        int DurerdeAudio { get; set; }
    }
}
