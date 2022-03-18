using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            This program generates a profile for a new match-making service.
            It focus on the creation of a new user's profile.

            The Profile should store the following information:

                User’s name
                User’s age
                User’s city
                User’s country
                User’s pronouns
                User’s hobbies
                And this is how users should be able to interact with their own profiles:

                Create a new profile with some information
                Add hobbies
                View profile
             
                        Author: Ricardo Carvalheira

            */

            Profile NewUser = new Profile();
            string result3 = NewUser.ViewProfile();
            NewUser.SetHobbies();

            //Profile sam = new Profile("New York", "USA", "Sam Drakkila", 18, "He/Him");
            //string result = sam.ViewProfile();
            //sam.SetHobbies(new string[] { "listening to audiobooks and podcast", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" });
            //result = sam.ViewProfile();
            //Console.WriteLine($"Profile 1: {result}");

            //Profile Kelly = new Profile("New York", "USA");
            //string result2 = Kelly.ViewProfile();
            //Console.WriteLine($"\nProfile 2: {result2}");

            Console.WriteLine($"\nNew Profile: {result3}");


            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
