using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CreatingClasses
{
    public class Relation
    {
        public enum RelationshipType
        {
            Sister, Brother, Mother, Father
        }

        public RelationshipType Relationship { get; set; }

        public Relation(RelationshipType relationshipP)
        {
            Relationship = relationshipP;
        }

        public string GetRelationshipDescription()
        {
            switch (Relationship)
            {
                case RelationshipType.Sister:
                    return "Sisterhood";
                case RelationshipType.Brother:
                    return "Brotherhood";
                case RelationshipType.Mother:
                    return "Motherhood";
                case RelationshipType.Father:
                    return "Fatherhood";
                default:
                    return Relationship.ToString();
            }
        }

        public void ShowRelationship(Person person1, Person person2)
        {
            string relationshipDescription = GetRelationshipDescription();
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {relationshipDescription}");
        }
    }
}
