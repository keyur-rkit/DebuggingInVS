namespace DebuggingInVS
{
    /// <summary>
    /// Main program class demonstrating debugging techniques in Visual Studio.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method that executes the application logic, including conditional compilation and debugging features.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Conditional Compilation
            #if DEBUG
            Console.WriteLine("This is a DEBUG build.");
            #else
            Console.WriteLine("This is a RELEASE build.");
            #endif

            List<int> numbers = GenerateNumbers();

            foreach (int number in numbers)
            {
                Console.WriteLine($"Processing number: {number}");
                ProcessNumber(number); // Conditional break points
            }

            // Check complex data structures (List of Books)
            List<Book> books = GenerateBooks(); // Normal break point to view data tips    
            foreach (Book book in books)
            {
                Console.WriteLine($"Book Title: {book.Title}, Author: {book.Author}");
            }

            Console.WriteLine("Debugging is complete!"); // temporary breakpoint
        }

        /// <summary>
        /// Generates a list of integers from 1 to 10.
        /// </summary>
        /// <returns>A list of integers.</returns>
        public static List<int> GenerateNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 10; i++) 
            {
                numbers.Add(i);
            }

            return numbers;
        }

        /// <summary>
        /// Processes a given number, doubling it and printing the result. 
        /// If the number is 5, execution is paused.
        /// </summary>
        /// <param name="number">The number to be processed.</param>
        public static void ProcessNumber(int number)
        {
            if (number == 5)
            {
                Console.WriteLine("Hit number 5, pausing execution.");
            }

            int result = number * 2;
            Console.WriteLine($"Processed number {number}, result is {result}");
        }

        /// <summary>
        /// Generates a list of Book objects, each containing a title, author, and ISBN.
        /// </summary>
        /// <returns>A list of books.</returns>
        public static List<Book> GenerateBooks()
        {
            return new List<Book>
            {
                new Book { Title = "One Piece", Author = "Ichiro Oda", ISBN = "123456" },
                new Book { Title = "Atomic Habits", Author = "James Clear", ISBN = "654321" },
                new Book { Title = "Paratpar", Author = "Dr. A.P.J. Abdul Kalam", ISBN = "987654" }
            };
        }

        /// <summary>
        /// Represents a book with a title, author, and ISBN number.
        /// </summary>
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

        }
    }
}
