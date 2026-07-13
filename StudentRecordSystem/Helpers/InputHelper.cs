namespace StudentRecordSystem.Helpers
{
    public static class ValidationHelper
    {
        public static int ReadInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid input. Enter only numbers.");
            }
        }
        public static double ReadDouble(string message)
        {
            double value;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid input.");
            }
        }
        public static string ReadString(string message)
        {
            while (true)
            {
                Console.Write(message);
                string value = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(value))
                    return value;
                Console.WriteLine("Value cannot be empty.");
            }
        }
    }
}