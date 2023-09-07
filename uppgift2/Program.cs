using System;
namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändra bakgrundsfärg till blue
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            // Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your PC ran into a problem that i cuoldn´t handle, and now it needs to restart");
        }
    }
}