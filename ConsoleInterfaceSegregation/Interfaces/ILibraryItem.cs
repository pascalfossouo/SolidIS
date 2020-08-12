using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation
{
    public interface ILibraryItem
    {
        int LibraryId { get; set; }
        string Titre { get; set; }
       
       

    }
}
