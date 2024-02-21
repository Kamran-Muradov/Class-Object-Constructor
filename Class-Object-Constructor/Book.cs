
namespace Class_Object_Constructor
{
    internal class Book
    {
        public string name;
        public string author;

        public Book()
        {
            Console.WriteLine("PB101");
        }

        public Book(string name)
        {
           this.name = name;
        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        
    }
}
