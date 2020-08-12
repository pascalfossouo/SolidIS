using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation.Interfaces
{
    public interface IEmpruntable
    {
        DateTime DateEmprunter { get; set; }
        string Emprunteur { get; set; }
        int NombreJourEmprunter { get; set; }
        void remettre();
        void prendre(string emprunteur);

        DateTime RemettreLe();
    }
}
