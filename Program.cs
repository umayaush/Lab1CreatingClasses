using System.Numerics;

namespace Lab1CreatingClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            person2.DisplayPersonInfo();

            Console.WriteLine(person3);

            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();

            Console.WriteLine($"{person4.FirstName} {person4.LastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            Relation relation1 = new Relation(Relation.RelationshipType.Sister);
            relation1.ShowRelationship(person2, person4);

            Relation relation2 = new Relation(Relation.RelationshipType.Brother);
            relation2.ShowRelationship(person1, person3);

            List<Person> listOfPeople = new List<Person>();
            listOfPeople.Add(person1);
            listOfPeople.Add(person2);
            listOfPeople.Add(person3);
            listOfPeople.Add(person4);

            int total = 0;
            foreach (Person person in listOfPeople) 
            {
                total += person.Age;
            }
            float average = (float)total / listOfPeople.Count;
            Console.WriteLine($"Average age is: {average}");

            Person youngest = listOfPeople.OrderBy(x  => x.Age).First();
            Console.WriteLine($"The youngest person is: {youngest.FirstName}");

            Person oldest = listOfPeople.OrderByDescending(x  => x.Age).First();
            Console.WriteLine($"The oldest person is: {oldest.FirstName}");

            List<Person> startWithM = listOfPeople.Where(x => x.FirstName.StartsWith("M")).ToList();
            foreach (Person person in startWithM) 
            {
                Console.WriteLine(person);
            }

            List<Person> likesBlue = listOfPeople.Where(x => x.FavoriteColour.Equals("Blue")).ToList();
            foreach (Person person in likesBlue)
            {
                Console.WriteLine(person);
            }

        }   
    }
}
