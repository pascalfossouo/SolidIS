using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation.Interfaces
{
    public interface IAudio : ILibraryItem
    {
        int DurerdeAudio { get; set; }
        string Auteur { get; set; }
    }
}
