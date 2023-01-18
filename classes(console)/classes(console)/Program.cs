using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_console_
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        /*private*/ float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots= 2;
            experience= 0f;
            Count++;
        }

        public void castSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }

            Console.WriteLine("Spell Slots: " + spellSlots);
            Console.WriteLine("Experience: " + experience);
        }

        public void meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots");
            spellSlots = 2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Wizard w01 = new Wizard();
            //w01.name = "Jacob";
            //w01.favoriteSpell = "Abracadabra";
            //w01.spellSlots = 2;
            //w01.experience = 0f;

            Wizard w02 = new Wizard("Jane", "Hocus Pocus");
            w02.castSpell();

            Wizard w03 = new Wizard("Via", "Alcazam");
            w03.castSpell();

            Console.WriteLine("Wizard Count: " + Wizard.Count);

            Console.ReadLine();
        }
    }
}
