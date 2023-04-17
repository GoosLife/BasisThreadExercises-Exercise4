namespace BasisThreadExercises_Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = '*';
            bool printCharacters = true;

            Thread input = new Thread(() => 
            {
                while (printCharacters)
                {
                    c = Console.ReadLine().FirstOrDefault();
                }
                }
            );

            Thread output = new Thread(() =>
            {
                while (printCharacters)
                {
                    Console.Write(c);
                }
            }
            );

            input.Start();
            output.Start();
        }
    }
}