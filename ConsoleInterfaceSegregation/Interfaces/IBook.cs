﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation.Interfaces
{
    public interface IBook : ILibraryItem
    {
        string Auteur { get; set; }
        int Pages { get; set; }
    }
}
