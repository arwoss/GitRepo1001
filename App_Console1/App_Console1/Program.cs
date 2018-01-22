using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definisco le variabili
            int primonumero = 0;
            int secondonumero = 0;
            int terzonumero = 0;
            //converto e mando in output le domande
            Console.WriteLine("Inserisci il primo numero");
            primonumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci secondo numero");
            secondonumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci terzo numero");
            terzonumero = Convert.ToInt32(Console.ReadLine());
            //creo tutte le combinazioni possibili per l'if
            if (primonumero < secondonumero && secondonumero < terzonumero)
            {
                Console.WriteLine("L'ordine è questo: 1 2 3");
            }
            if (secondonumero < primonumero && primonumero < terzonumero)
            {
                Console.WriteLine("L'ordine è questo: 2 1 3");
            }
            if (terzonumero < secondonumero && secondonumero < primonumero)
            {
                Console.WriteLine("L'ordine è questo: 3 2 1");
            }
            if (terzonumero < secondonumero && secondonumero < primonumero)
            {
                Console.WriteLine("L'ordine è questo: 3 1 2");
            }
            if (secondonumero < terzonumero && terzonumero < primonumero)
            {
                Console.WriteLine("L'ordine è questo: 2 3 1 ");
            }
            Console.WriteLine("Ciao e alla prossima!");
            //chiudo il programma
            Console.ReadLine();







        }
    }
}
