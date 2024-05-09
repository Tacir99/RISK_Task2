
namespace Task_2.Classes
{
    public class Person
    {
        private static int nextId = 1;

        public Person(string name, string surname)
        {
            Id = nextId++;
            Name = name;
            Surname = surname;
        }

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Surname}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Person other = (Person)obj;
            return Name == other.Name && Surname == other.Surname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Surname);
        }
    }
}
