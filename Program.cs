using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Clients
            Client client1 = new Client(123456, "Dupont", "Loic", new DateTime(1990, 05, 12), true);
            Client client2 = new Client(789456, "Samba", "Amine", new DateTime(1986, 12, 15), true);

            // Comptes
            Compte compte1 = new Compte("ACE123", 1000, client1);
            Compte compte2 = new Compte("DFG456", 2000, client2);

            // Autres
            string texteClient = "Les informations d'un client : ";
            string texteCompte = "Les informations d'un compte : ";

            string murClient = new string('#', 30);
            string murCompte = new string('$', 35);
            string mur = new string('/', 105);

            // Code
            Console.WriteLine($"{murClient} {texteClient} {murClient}");
            Console.WriteLine(client1.Afficher());

            Console.WriteLine("\nLes données pour le compte 1 : ");
            Console.WriteLine($"Création d'un objet compte avec le client précedent N°1 - Numero : {compte1.Numero} - Solde : {compte1.Solde}");

            Console.WriteLine($"\n{murCompte} {texteCompte} {murCompte}");
            Console.WriteLine(compte1.Afficher());
            Console.WriteLine();

            Console.WriteLine(mur);
            Console.WriteLine(mur);
            Console.WriteLine();

            Console.WriteLine($"{murClient} {texteClient} {murClient}");
            Console.WriteLine(client2.Afficher());

            Console.WriteLine("\nLes données pour le compte 2 : ");
            Console.WriteLine($"Création d'un objet compte avec le client précedent N°2 - Numero : {compte2.Numero} - Solde : {compte2.Solde}\n");

            Console.WriteLine($"{murCompte} {texteCompte} {murCompte}");
            Console.WriteLine(compte2.Afficher());
            Console.WriteLine();

            //Dépôt
            Console.WriteLine("Donner le montant à déposer : ");
            int montant_depot = int.Parse(Console.ReadLine());
            if (montant_depot >= 1)
            {
                compte2.CrediterCompte(montant_depot);
                Console.WriteLine("Opération bien effectuée");
            }
            else
            {
                Console.WriteLine("Opération annulée");
            }
            Console.WriteLine();

            Console.WriteLine($"{murCompte} {texteCompte} {murCompte}");
            Console.WriteLine(compte2.Afficher());
            Console.WriteLine();

            //Retrait
            Console.WriteLine("Donner le montant à retirer : ");
            int montat_retrait = int.Parse(Console.ReadLine());     
            if (montat_retrait <= 0)
            {
                Console.WriteLine("Opération annulée");
            }
            else if (montat_retrait <= compte2.Solde)
            {
                compte2.DebiterCompte(montat_retrait);
                Console.WriteLine("Opération de retrait bien effectuée");
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
            }
            Console.WriteLine();

            Console.WriteLine($"{murCompte} {texteCompte} {murCompte}");
            Console.WriteLine(compte2.Afficher());

            Console.WriteLine(compte2.AfficherDetailDateCreation());

            Console.WriteLine($"\nLe nombre de comptes crées est : {Compte.NombreComptes()}");
        }
    }
}
