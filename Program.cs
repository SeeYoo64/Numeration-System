













namespace Numeration_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to convert:");
            string numb = Console.ReadLine();

            Console.WriteLine("Enter the current number system (2, 8, 10 or 16):");
            int currentSystem = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the target number system (2, 8, 10 or 16):");
            int targetSystem = int.Parse(Console.ReadLine());

            Convert convert = new Convert();

            string result = convert.ConvertNumberSystem(numb, currentSystem, targetSystem);

            Console.WriteLine($"Result convertation is: {result}");




        }
    }
}






