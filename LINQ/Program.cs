namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string> { "Super Mario Bros","Fallout","Resident Evil","Legend of Zelda","Call of Duty","Grand Theft Auto","Metal Gear","The Elder Scrolls",
                                            "World of Warcraft","Halo","Half-Life","Street Fighter","Galaga","Pacman","Minecraft","Final Fantasy","Sonic the Hedgehog",
                                            "Tetris","The Witcher","NBA2K","Madden NFL","Duck Hunt","FIFA Soccer","God of War","Spider Man","League of Legends","Roblox"};
            ListPrinter("Raw list of games",games);
            ListPrinter("Sorted alphabetically",games.OrderBy(x => x));
            ListPrinter("Sorted by title length", games.OrderBy(x => x.Length));
            ListPrinter("Filtered for single word titles", games.Where(x => !x.Contains(" ")));

            var gamesSubset = from game in games orderby game descending select game;
            ListPrinter("Query syntax - descending alphabetical", gamesSubset);
        }

        public static void ListPrinter(string heading, IEnumerable<string> coll)
        {
            string output = "{";
            foreach (var item in coll)
                output += item + ",";
            output += "}";
            output = output.Replace(",}", "}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(heading);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(output);
        }
    }
}
