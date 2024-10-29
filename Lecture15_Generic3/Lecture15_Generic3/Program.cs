using System.Text;


namespace Lecture15_Generic3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DataStorage<Person> personStorage = new DataStorage<Person>();
            personStorage.addItem(new Person("Marcela", 40));
            personStorage.addItem(new Person("Marcela", 38));
            personStorage.addItem(new Person("Marcelo", 36));
            personStorage.addItem(new Person("Marcelo", 18));
            personStorage.addItem(new Person("Marcelo", 7));
            personStorage.addItem(new Person("Benicio", 24));

            personStorage.displayItems();

            Console.WriteLine();

            var person30 = personStorage.Items.Where(p => p.Age > 30);

            Console.WriteLine("People aged greater than 30:");


            foreach (var person in person30)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var personNames = personStorage.Items.Select(p => p.Name);

            Console.WriteLine("People names");

            foreach (var person in personNames)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();


            var sortedByAge = personStorage.Items.OrderBy(p => p.Age);

            Console.WriteLine("People sorted by age:");
            foreach (var person in sortedByAge)
            {
                Console.WriteLine($"{person.Name} - Age: {person.Age}");
            }

            var peopleByName = personStorage.Items.GroupBy(p => p.Name);

            foreach (var group in peopleByName)
            {
                Console.WriteLine($"Name: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"  {person.Age}");
                }
            }


            int totalPeople = personStorage.Items.Count();
            int totalAge = personStorage.Items.Sum(p => p.Age);
            double averageAge = personStorage.Items.Average(p => p.Age);
            int youngest = personStorage.Items.Min(p => p.Age);
            int oldest = personStorage.Items.Max(p => p.Age);

            Console.WriteLine($"Total People: {totalPeople}");
            Console.WriteLine($"Total Age: {totalAge}");
            Console.WriteLine($"Average Age: {averageAge}");
            Console.WriteLine($"Youngest Age: {youngest}");
            Console.WriteLine($"Oldest Age: {oldest}");

            // Using LINQ to filter and order the list
            var adults = personStorage.Items.Where(p => p.Age >= 21).OrderBy(p => p.Name).Select(p => p.Name);

            Console.WriteLine("Adults sorted by name:");
            foreach (var name in adults)
            {
                Console.WriteLine(name);
            }





        }
    }
    
}