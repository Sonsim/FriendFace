using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class User
    {
        
        private string _fullname;
        private string _password;
        private string _job;
        private int _age;
        private string _interests;
        private int _height;
        private string _gender;
        static List<People> friends = new List<People>();

        public User(string Name, string Password, string Job, int Age, string Interest, int Heigth
        , string Gender)
        {
            _fullname = Name;
            _password = Password;
            _job = Job;
            _age = Age;
            _interests = Interest;
            _height = Heigth;
            _gender = Gender;
        }

        public User()
        {
            
        }

        public static void createUser()
        {
            Console.WriteLine();
            Console.WriteLine("Velkommen til FriendFace");
            Console.WriteLine("For å kunne logge inn må du svare på følgende spørsmål");
            Console.WriteLine("Fullt navn:");
            var name = Console.ReadLine();
            Console.WriteLine("Passord");
            var password = Console.ReadLine();
            Console.WriteLine("Jobb:");
            var job = Console.ReadLine();
            Console.WriteLine("Alder:");
            var age = Console.ReadLine();
            Console.WriteLine("Interesser:");
            var interest = Console.ReadLine();
            Console.WriteLine("Høyde:");
            var height = Console.ReadLine();
            Console.WriteLine("Kjønn:");
            var gender = Console.ReadLine();

            var user = new User($"{name}", $"{password}", $"{job}", Convert.ToInt32($"{age}"),
                $"{interest}", Convert.ToInt32($"{height}"), $"{gender}");
            Console.WriteLine($"Velkommen,{user._fullname}");
        }

        public static void AddFriendToList(People friend)
        {
            friends.Add( friend );
        }

        public static void AddFriend()
        {


            Console.WriteLine("Venner du kan legge til: ");
            for (int i = 0; i < Program.allpeople.Count; i++)
            {

                Console.WriteLine($"{i}. {Program.allpeople[i]._fullname}");

            }
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    AddFriendToList(Program.allpeople[0]);
                    Console.Clear();
                    AddFriend();
                    break;
                case "1":
                    AddFriendToList(Program.allpeople[1]);
                    Console.Clear();
                    AddFriend();
                    break;
                case "2":
                    AddFriendToList(Program.allpeople[2]);
                    Console.Clear();
                    AddFriend();
                    break;
                case "3":
                    AddFriendToList(Program.allpeople[3]);
                    Console.Clear();
                    AddFriend();
                    break;
                case "4":
                    AddFriendToList(Program.allpeople[4]);
                    Console.Clear();
                    AddFriend();
                    break;
                default:
                    Console.Clear();
                    Program.menu();
                    break;
            }

        }

        public static void RemoveFriendFromList(People friend)
        {
            friends.Remove( friend );
        }

        public static void RemoveFriend()
        {
            Console.WriteLine("Venner du kan fjerne: ");
            for (int i = 0; i < friends.Count; i++)
            {

                Console.WriteLine($"{i}. {friends[i]._fullname}");

            }
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "0":
                    RemoveFriendFromList(friends[0]);
                    RemoveFriend();
                    break;
                case "1":
                    RemoveFriendFromList(friends[1]);
                    RemoveFriend();
                    break;
                case "2":
                    RemoveFriendFromList(friends[2]);
                    RemoveFriend();
                    break;
                case "3":
                    RemoveFriendFromList(friends[3]);
                    RemoveFriend();
                    break;
                case "4":
                    RemoveFriendFromList(friends[4]);
                    RemoveFriend();
                    break;
                default:
                    Console.Clear();
                    Program.menu();
                    break;
            }
        }

        public static void ShowAllFriends()
        {
            for (int i = 0; i < friends.Count; i++)
            {
                Console.WriteLine($"{i}. {friends[i]._fullname}");
            }
            Console.WriteLine("Gå tilbake? Y/N");
            var ans = Console.ReadLine();
            if (ans.ToLower() == "y")
            {
                Console.Clear();
                Program.menu();
            }
            else System.Environment.Exit(0);
        }

        public static void showFriendInfo()
        {
            Console.WriteLine("Velg venn du vil se all informasjon til");
            ShowAllFriends();

            var ans = Convert.ToInt32(Console.ReadLine());
       

                Console.WriteLine($"Navn: {friends[ans]._fullname}");
                Console.WriteLine($"Alder: {friends[ans]._age}");
                Console.WriteLine($"Kjønn: {friends[ans]._gender}");
                Console.WriteLine($"Jobb: {friends[ans]._job}");
                Console.WriteLine($"Interesser: {friends[ans]._interests}");
                Console.WriteLine();
                Console.WriteLine("Se informasjonen til en annen? Y/N");
                var choice = Console.ReadLine();
                if (choice.ToLower() == "y")
                {
                    Console.Clear();
                    showFriendInfo();
                }
                else Console.Clear(); Program.menu();
                
            
        }
    }
}
