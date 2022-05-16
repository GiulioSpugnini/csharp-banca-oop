using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti 
che una banca concede ai propri clienti.

La banca è caratterizzata da 
- un nome 
- un insieme di clienti (una lista) 
- un insieme di prestiti concessi ai clienti (una lista)


I clienti sono caratterizzati da 
- nome, 
- cognome, 
- codice fiscale 
- stipendio

I prestiti sono caratterizzati da 
- intestatario del prestito (il cliente), 
- un ammontare, una rata, 
- una data inizio, 
- una data fine. 



Per la banca deve essere possibile:
- aggiungere, modificare, eliminare e ricercare un cliente. 
- aggiungere un prestito. 
- effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale 
- sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.

Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo 
con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere. 

*/

namespace csharp_banca_oop
{
    public class Banca
    {
        private string NomeBanca { get; set; }
        private List<Cliente> listaClienti { get; set; }
        private List<Prestito> listaPrestiti { get; set; }


        public Banca(string sNomeBanca)
        {
            NomeBanca = sNomeBanca;
            listaClienti = new List<Cliente>();
            listaPrestiti = new List<Prestito>();
        }


        // Funzione per aggiungere un cliente alla lista
        public void AggiungiCliente(Cliente c)
        {

            // In questo modo evito di fare il costruttore nella classe Cliente 

            listaClienti.Add(c);
        }


        // Funzione per modificare un cliente 
        public void ModificaCliente(string CodiceFCliente)
        {
            Cliente mioCliente = listaClienti.Find(x => x.CodiceFCliente == CodiceFCliente);

            Console.WriteLine("Decidi cosa modificare:");
            Console.WriteLine("Se vuoi modificare il nome inserisci : 1");
            Console.WriteLine("Se vuoi modificare il cognome inserisci : 2");
            Console.WriteLine("Se vuoi modificare il codice fiscale inserisci : 3");
            Console.WriteLine("Se vuoi modificare lo stipendio inserisci : 4");

            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Inserisci il nuovo nome");
                    string newName = Console.ReadLine();
                    mioCliente.NomeCliente = newName;
                    break;
                case 2:
                    Console.WriteLine("Inserisci il nuovo cognome");
                    string newCognome = Console.ReadLine();
                    mioCliente.CognomeCliente = newCognome;
                    break;
                case 3:
                    Console.WriteLine("Inserisci il nuovo codice fiscale");
                    string newCodiceFiscale = Console.ReadLine();
                    if (newCodiceFiscale.Length == 11)
                        mioCliente.CognomeCliente = newCodiceFiscale;
                    break;
                case 4:
                    Console.WriteLine("Inserisci il nuovo stipendio");
                    int newStipendio = Convert.ToInt32(Console.ReadLine());
                    mioCliente.Stipendio = newStipendio;
                    break;
            }


        }


        //Funzione per eliminare un cliente dalla lista clienti
        public void RimuoviCliente(string CodiceFCliente)
        {
            Cliente mioCliente = listaClienti.Find(x => x.CodiceFCliente == CodiceFCliente);
            listaClienti.Remove(mioCliente);

        }

        public void CercaCliente(string CodiceFCliente)
        {
            Cliente mioCliente = listaClienti.Find(x => x.CodiceFCliente == CodiceFCliente);
            Console.WriteLine(mioCliente.NomeCliente);
            Console.WriteLine(mioCliente.CognomeCliente);
            Console.WriteLine(mioCliente.Stipendio);
            Console.WriteLine(mioCliente.CodiceFCliente);

        }
        public void AggiungiPrestito(Cliente Intestatario, double AmmontarePrestito, double RataPrestito, DateTime DataInizio, DateTime DataFine)
        {
            Prestito nuovoPrestito = new Prestito();
            nuovoPrestito.Intestatario = Intestatario;
            nuovoPrestito.AmmontarePrestito = AmmontarePrestito;
            nuovoPrestito.RataPrestito = RataPrestito;
            nuovoPrestito.DataInizio = DataInizio;
            nuovoPrestito.DataFine = DataFine;
            listaPrestiti.Add(nuovoPrestito);
        }

    }

    public class Cliente
    {
        private string nomeCliente;
        public string NomeCliente
        {
            get => nomeCliente;
            set => nomeCliente = value;
        }
        private string cognomeCliente;
        public string CognomeCliente
        {
            get => cognomeCliente;
            set => cognomeCliente = value;
        }
        private string codiceFiscale;
        public string CodiceFCliente
        {
            get => codiceFiscale;
            set => codiceFiscale = value;
        }
        private int stipendio;
        public int Stipendio
        {
            get => stipendio;
            set => stipendio = value;
        }

        public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
        {
            this.NomeCliente = nome;
            this.CognomeCliente = cognome;
            this.CodiceFCliente = codiceFiscale;
            this.Stipendio = stipendio;
        }

    }

    public class Prestito
    {
        public Cliente Intestatario { get; set; }
        public double AmmontarePrestito { get; set; }
        public double RataPrestito { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }

       
        
    }
}