using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hambi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hambiar = 1000;
            int sultkrumpar = 300;
            int menuar = 1300;
            int hambiszam = 0;
            int sultkrumpliszam = 0;
            int menuszam = 0;
            int vegosszeg = (hambiszam * hambiar) + (sultkrumpliszam * sultkrumpar) + (menuszam * menuar);

        eleje:
            Console.Write("Kérem adja meg hogy mit kér, hamburger(t), sültkrumpli(t) vagy menü(t): ");

            string valaszt = Console.ReadLine();

            if (valaszt == "sültkrumpli")
                sultkrumpliszam++;

            else if (valaszt == "hamburger")
                hambiszam++;

            else if (valaszt == "menü")
                menuszam++;

            if (valaszt != "sültkrumpli" && valaszt != "hamburger" && valaszt != "menü")
                Console.WriteLine("A megadott termék nem létezik!");

            Console.WriteLine();

            Console.WriteLine($"Jelenlegi rendelése: {hambiszam} hamburger, {sultkrumpliszam} sültkrumpli és {menuszam} menü.");

            Console.WriteLine();

            Console.Write("Szeretne bármi mást hozzáadni a rendeléshez? (Igen/Nem) ");

            string ujterm = Console.ReadLine();

            if (ujterm == "igen")
                goto eleje;

            else if (ujterm == "nem")
                goto donation;

            donation:

            Console.WriteLine("Szeretné 100 Ft-al támogatni a cégünket? (Igen/Nem)");

            string dono = Console.ReadLine();

            if (dono == "Igen")
                vegosszeg = vegosszeg + 100;

            else if (dono == "Nem")
                goto folyt;

            folyt:

            Console.Beep(500, 250);
            Console.Beep(500, 250);
            Console.Beep(300, 250);
            Console.Beep(700, 250);
            Console.Beep(900, 250);
            Console.WriteLine("Köszönjük! A rendelése: ");
            Console.WriteLine();
            Console.WriteLine("|-----Hambi Place-----|");

            if (hambiszam > 0)
                Console.WriteLine($"|-----{hambiszam} hamburger-----|");

            if (sultkrumpliszam > 0)
                Console.WriteLine($"|----{sultkrumpliszam} sültkrumpli----|");

            if (menuszam > 0)
                Console.WriteLine($"|--------{menuszam} menü-------|");

            Console.WriteLine();

            Console.WriteLine($"|---{vegosszeg} Ft a fizetendő végösszeg---|");
            Console.WriteLine();
            Console.WriteLine("Köszönjük hogy nálunk vásárolt! C:");
            Console.ReadLine();

        }
    }
}
