

namespace Task3
{
    class Printer
    {
        public void Print(string message)
        {
            Console.WriteLine("Printing message: " + message);
        }

        public void Print(int number)
        {
            Console.WriteLine("Printing number: " + number);
        }

        public void Print(string message, int count)
        {
            Console.WriteLine($"Printing \"{message}\" {count} times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }
    }
}