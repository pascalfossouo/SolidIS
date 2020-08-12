using ConsoleInterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation
{
    public class ReferenceBook : IReferenceBook
    {
        public int LibraryId { get; set; }
        public string Auteur { get; set; }      
        
        public int Pages { get; set; }
        public string Titre { get; set; }


    }
}
