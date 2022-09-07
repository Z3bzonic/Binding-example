using System.Collections.Generic;

namespace cursistToevoegen
{
    public class Cursist
    {
        public Cursist(string voornaam, string achternaam)
        {
            Naam = voornaam;
            Achternaam = achternaam;
        }

        public string Naam { get; set; }
        public string Achternaam { get; set; }

        public string Fullname { get => $"{Naam} {Achternaam}"; }
    }
}