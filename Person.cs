using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabA2
{
    internal class Person
    {
        //Fields
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        //Properties
        public int PersonId { get => personId; set => personId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value; }
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        //Constructor
        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor= favoriteColor;
            this.isWorking = isWorking;
        }

        //Methods
        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted += personId + ": " + firstName + " " + lastName + "'s favorite colour is " + favoriteColor;


            return formatted;
        }

        public string ChangeFavoriteColour()
        {
            favoriteColor = "White";

            string newSentence = DisplayPersonInfo();

            return newSentence;
        }

        public override string ToString()
        {
            string list = "";

            list += "PersonId: " + personId + "\n";
            list += "FirstName: " + firstName + "\n";
            list += "LastName: " + lastName + "\n";
            list += "FavoriteColour: " + favoriteColor + "\n";
            list += "Age: " + age + "\n";
            list += "IsWorking: " + isWorking; ;

            return list;
        }

        public string GetAgeInTenYears()
        {
            int ageInTenYears = age + 10;

            string newAge = firstName + " " + lastName + "'s Age in 10 years is: " + ageInTenYears;

            return newAge;
        }
    }
}
