using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenAchouri
{
    internal class Client
    {
        private int ClientId;
        private string  NomClient;
        private string PrenomClient;
        private string GenreClient;
        private string AdressClient;
        private string EmailClient;
        private string TelephoneClient;

        public int ClientId1 { get => ClientId; set => ClientId = value; }
        public string NomClient1 { get => NomClient; set => NomClient = value; }
        public string PrenomClient1 { get => PrenomClient; set => PrenomClient = value; }
        public string GenreClient1 { get => GenreClient; set => GenreClient = value; }
        public string AdressClient1 { get => AdressClient; set => AdressClient = value; }
        public string EmailClient1 { get => EmailClient; set => EmailClient = value; }
        public string TelephoneClient1 { get => TelephoneClient; set => TelephoneClient = value; }
    }
    class Entreprise : Client
    {
        private string NomEntreprise;
        private string NbrEmployer;
        private string SecteurActivite;

        public string NomEntreprise1 { get => NomEntreprise; set => NomEntreprise = value; }
        public string NbrEmployer1 { get => NbrEmployer; set => NbrEmployer = value; }
        public string SecteurActivite1 { get => SecteurActivite; set => SecteurActivite = value; }
    }
    class Particulier : Client
    {
        private string ProfessionPart;
        private string RevenuePart;

        public string ProfessionPart1 { get => ProfessionPart; set => ProfessionPart = value; }
        public string RevenuePart1 { get => RevenuePart; set => RevenuePart = value; }
    }
}
