using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp5
{
    public class Client
    {
        private int identifiant;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private bool status;

        public int Identifiant
        {
            get { return identifiant; }
            set { identifiant = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        public bool Status
        {
            get { return Status; }
            set { status = value; }
        }

        public Client()
        {
            this.identifiant = 0;
            this.nom = "";
            this.prenom = "";
            this.dateNaissance = new DateTime();
            this.status = true;

        }
        public Client(int id, string nom, string prenom, DateTime dateNaissance, bool status)
        {
            this.identifiant = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.status = status;

        }

        public string estStatus()
        {
            if (this.status == true)
            {
                return "Le client est actif";
            }
            else
            {
                return "Le client est inactif";
            }
        }

        public string Afficher()
        {
            return "Identifiant du client : " + this.identifiant +
                "\nNom du client : " + this.nom +
                "\nPrénom  du client : " + this.prenom +
                "\nDate de naissance du client : " + this.dateNaissance +
                "\nStatus du client : " + this.status;
        }

        public string Afficher_client_pour_cpt()
        {
            return "Identifiant du client : " + this.identifiant +
                " - Nom du client : " + this.nom +
                " - Prénom  du client : " + this.prenom +
                " - Date de naissance du client : " + this.dateNaissance +
                " - Status du client : " + this.status;
        }
 
    }
}
