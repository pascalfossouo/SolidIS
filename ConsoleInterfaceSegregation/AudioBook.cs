using ConsoleInterfaceSegregation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaceSegregation
{
    public class AudioBook : IAudioEmpruntable
    {
        public int LibraryId { get; set; }
        public string Auteur { get; set; }
        public DateTime DateEmprunter { get; set; }
        public string Emprunteur { get; set; }
        public int NombreJourEmprunter { get; set; } = 14;
        public string Titre { get; set; }


       


        public int DurerdeAudio { get; set; }

        public void prendre(string emprunteur)
        {
            Emprunteur = emprunteur;
            DateEmprunter = DateTime.Now;
        }

        public void remettre()
        {
            Emprunteur = "";
        }

        public DateTime RemettreLe()
        {
            return DateEmprunter.AddDays(NombreJourEmprunter);
        }
    }
}
