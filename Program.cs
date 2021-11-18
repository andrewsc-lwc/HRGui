using System;

namespace HR
{
    class Program
    {
        private static void Ignore(string[] args)
        {
            Staff staff1 = new Staff("Bob", 1, "09/09/1999", "bob@lordwandsworth.org");
            Console.WriteLine(staff1.DisplayInfo());
            Coach coach1 = new Coach("Chris Andrews", 25000, "03 / 09 / 1984", "andrewsc@lordwandsworth.org", "Goalkeeping");
            Console.WriteLine(coach1.DisplayInfo());
            Player player1 = new Player("Cristiano Ronaldo", 40000000, "05 / 10 / 1985", "ronaldoc@lordwandsworth.org","Forward",78,90000000);
            Console.WriteLine(player1.DisplayInfo());
            Cleaner cleaner1 = new Cleaner("George Jones", 8000, "13 / 03 / 1989", "jonesg@lordwandsworth.org");
            Console.WriteLine(cleaner1.DisplayInfo());
            Physio physio1 = new Physio("James Jones", 15000, "30 / 02 / 1967", "jonesj@lordwandsworth.org", "Muscle");
            Console.WriteLine(physio1.DisplayInfo());
        }
    }
}
