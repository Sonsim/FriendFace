using System.Net.Http.Headers;

namespace FriendFace
{
    internal class Program
    {
        public static List<People> allpeople = new List<People>();

        static void Main()
        {
            var Sondre = new People("Sondre Simensen", "Student", 30, "Fotball, spill og musikk", 190, "mann");
            var Trym = new People("Trym Ekeberg", "Financal Controller", 27, "Spill, fotball, padel", 185, "mann");
            var Synne = new People("Synne Ekeberg", "Vernepleier", 24, "Tattoveringer", 170, "Kvinne");
            var Thomas = new People("Thomas Lehne Olsen", "Fotballspiller", 32, "Fotball og gambling", 186, "Mann");
            var Saga = new People("Saga Andersson", "FBI Agent", 40, "Se på TV og leke med barna", 175, "Kvinne");
            

            allpeople.Add(Sondre);
            allpeople.Add(Trym);
            allpeople.Add(Synne);
            allpeople.Add(Thomas);
            allpeople.Add(Saga);

            User.createUser();
            menu();


        }

        public static void menu()
        {
            Console.WriteLine("Velg hva du vil gjøre");
            Console.WriteLine("1. Se alle profiler");
            Console.WriteLine("2. Legg til venner");
            Console.WriteLine("3. Fjerne venner");
            Console.WriteLine("4. Skriv ut liste over alle venner");
            Console.WriteLine("5. Velg èn venn og skriv ut info");
            Console.WriteLine("6. Avslutt program");
            var ans = Console.ReadLine();

            switch (ans)
            {
                case "1":
                    showAll();
                    break;
                case "2":
                    Console.Clear();
                    User.AddFriend();
                    break;
                case "3":
                    Console.Clear();
                    User.RemoveFriend();
                    break;
                case "4": 
                    Console.Clear();
                    User.ShowAllFriends();
                    break;
                case "5": 
                    Console.Clear();
                    User.showFriendInfo();
                    break;
                case "6": 
                    System.Environment.Exit(0);
                    break;

            }
        }

        public static void showAll()
        {
            
            Console.Clear();
            foreach (var person in allpeople)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine($"Navn: {person._fullname}");
                Console.WriteLine($"Alder: {person._age}");
                Console.WriteLine($"Kjønn: {person._gender}");
                Console.WriteLine($"Jobb: {person._job}");
                
            }
            Console.WriteLine("Trykk 8 for å gå tilbake eller 9 for å avslutte");
            var ans = Console.ReadLine();

            switch (ans)
            {
                case "8":
                    Console.Clear();
                    menu();
                    break;
                case "9":
                    System.Environment.Exit(0);
                    break;
            }

        }
    }
}