using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Compte_bancaire
{
    public class Compte
    {
        private string numero;
        private double solde;
        private Client leClient;
        private DateTime dateCreation;

        private static int nombreComptes = 0;

        public string Numero
        {
            get { return numero; }
        }
        public double Solde
        {
            get { return solde; }
        }
        public Client LeClient
        {
            get { return leClient; }
        }
        public DateTime DateCreation
        {
            get { return dateCreation; }
        }

        public Compte(string num, int solde, Client leClient)
        {
            this.numero = num;
            this.solde = solde;
            this.leClient = leClient;
            this.dateCreation = DateTime.Now;
            nombreComptes++;
        }
        public static int NombreComptes()
        {
            return nombreComptes;
        }

        public void CrediterCompte( int value)
        {
            this.solde += value;
        }
        public void DebiterCompte(int value)
        {
            if (value <= this.solde)
            {
                this.solde -= value;
            }
            else
            {
                this.solde -= 0;
            }
        }
        public string estStatus()
        {
            if (this.leClient.Status == true)
            {
                return "Le compte est ouvert";
            }
            else
            {
                return "Le compte est clos";
            }
        }
        public string RecupererNomClientParCompte(Client leClient)
        {
            return "Nom du client : " + leClient.Nom;
        }
        public string RecupererPrenomClientParCompte(Client leClient)
        {
            return "Prénom du client : " + leClient.Prenom;
        }

        public string Afficher()
        {
            return "Numéro de compte : " + this.numero +
                "\nSolde du compte : " + this.solde +
                "\nPropriétaire du compte : \n" + 
                this.leClient.Afficher_client_pour_cpt();

        }
        public string AfficherDetailDateCreation()
        {
            return "\nAffichage des informations de la date de création du compte : " +
                "\nAnnée = " + this.dateCreation.Year + 
                "\nMois = " + this.dateCreation.Month + 
                "\nJour = " + this.dateCreation.Day + 
                "\nHeure = " + this.dateCreation.Hour + 
                "\nMinute = " + this.dateCreation.Minute + 
                "\nSeconde = " + this.dateCreation.Second + 
                "\nMilliseconde = " + this.dateCreation.Millisecond;
        }

    }
}
