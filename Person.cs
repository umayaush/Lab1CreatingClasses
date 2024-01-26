using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CreatingClasses
{
    public class Person
    {
        public int PersonId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        public Person(int personIdP, string firstNameP, string lastNameP, string favoriteColourP, int ageP, bool isWorkingP)
        {
            PersonId = personIdP;
            FirstName = firstNameP;
            LastName = lastNameP;
            FavoriteColour = favoriteColourP;
            Age = ageP;
            IsWorking = isWorkingP;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite colour is {FavoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return Age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
        }
    }

        
}
