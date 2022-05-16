using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Banca MontePaschi = new Banca("MontePaschi");
            Cliente cliente = new Cliente("giulio", "spugnini", "SPGGLI96H29G713C", 2000);
            MontePaschi.AggiungiCliente(cliente);
            MontePaschi.ModificaCliente("Carlo");
            MontePaschi.RimuoviCliente("SPGGLI96H29G713C");

            MontePaschi.AggiungiPrestito(cliente, 2000, 4, DateTime.Now, new DateTime(12/05/2030));

        }
    }
}
