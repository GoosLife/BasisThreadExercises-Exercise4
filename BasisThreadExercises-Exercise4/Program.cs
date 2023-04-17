namespace BasisThreadExercises_Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = '*'; // The character to print to the console.
            bool printCharacters = true; // A flag to indicate whether the threads should continue to print characters. In this case, it is always true, so the threads will continue to print characters until the program is terminated.

            // Create two threads, one for reading input and one for printing the character

            // Create a thread for reading input from the console.
            Thread input = new Thread(() => 
            {
                while (printCharacters)
                {
                    // Read a character from the console and use it to set the value of c. The user must press enter to confirm the input.
                    // If the first character of the input is null, ignore the input and continue.
                    if (Console.ReadLine()?[0] != null)
                    {
                        c = Console.ReadLine()![0];
                    }
                }
                }
            );

            // Create a thread for writing to the console.
            Thread output = new Thread(() =>
            {
                while (printCharacters)
                {
                    Console.Write(c);
                }
            }
            );

            // Start the threads.
            input.Start();
            output.Start();

            // Join the threads to the main thread to avoid terminating the main thread before the input and output threads are done.
            input.Join();
            output.Join();

            // Wait for user input before terminating the program.
            Console.ReadKey();
        }
    }
}