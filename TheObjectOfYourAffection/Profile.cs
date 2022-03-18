using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObjectOfYourAffection
{
    class Profile
    {
        //Field
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        public int Age
        {
            get { return age; }
            private set
            {
                if (value >= 18) 
                    age = value;
                else
                {
                    throw new Exception($"You must be over 18 yo to use this application!");

                }
            }
        }

        //Constructor
        public Profile(string city, string country, string name = "n/a", int age = 18, string pronouns = "they/them")
        {
            this.name = name;
            this.Age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[0];
        }
        public Profile()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            this.name = name;

            Console.Write("Enter Age: ");
            string ageString = Console.ReadLine();
            
            while (!Int32.TryParse(ageString, out age))
            {
                Console.Write("Invalid Age. Please try again.\r\n");
                Console.Write("Enter Age: ");
                ageString = Console.ReadLine();
            }

            this.Age = age;

            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            this.city = city;



            Console.Write("Enter Country: ");
            string country = Console.ReadLine();
            this.country = country;

            Console.Write("Enter Pronouns: ");
            string pronouns = Console.ReadLine();
            this.pronouns = pronouns;

            this.hobbies = new string[0];
        }
        //Methods
        public string ViewProfile()
        {
            string profile = $"Name: {name}\r\nAge: {age}\r\nCity: {city}\r\nCountry: {country}\r\nPronouns: {pronouns}";

            if (hobbies.Length != 0)
            {
                profile += "\r\nHobbies:";
                foreach (string hobby in hobbies)
                {
                    profile += $"\n- {hobby}";
                }

            }
            return profile;
        }
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

        public void SetHobbies()
        {
            Console.Write("How many hobbies would you like to add: ");
            string numHobbiesString = Console.ReadLine();
            int numHobbies;
            while (!Int32.TryParse(numHobbiesString, out numHobbies))
            {
                Console.Write("Invalid number of hobbies. Please try again.\r\n");
                Console.Write("How many hobbies would you like to add:");
                numHobbiesString = Console.ReadLine();

            }
            //Creates an array of strings to store the hobbies. Size is the number of Hobies
            string[] hobbiesAnswer = new string[numHobbies];
            //Capture the hobies from the user
            for (int i = 0; i < numHobbies; i++)
            {
                
                Console.Write($"Enter Hobby Number {i + 1}: ");
                hobbiesAnswer[i] = Console.ReadLine();
            }
            //Associates the hobbies from that user to their answers
            this.hobbies = hobbiesAnswer;
            
        }
    }
}
