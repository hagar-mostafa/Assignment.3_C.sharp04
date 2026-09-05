using System;
# nullable disable
internal class Program
{
        
    static void Main(string[] args)
    {
        #region Question 1
        double[] prices = new double[] { 25.5, 40.0, 33.75 };
        Console.WriteLine($"The second element of the array is: {prices[1]}");
        #endregion

        Console.WriteLine("----------------------------------------------");

        #region Question 2
        int[,] shelfCopies = new int[,] {
        {3 ,5 }, // shelf 0
        { 2 , 6 }, // shelf 1
        { 1 , 4}
        };
        Console.WriteLine($"The number of copies on shelf 1, slot 0: {shelfCopies[1, 0]}");
        #endregion

        Console.WriteLine("----------------------------------------------");

        #region Question 3
        void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        PrintWelcomeMessage();
        #endregion

        Console.WriteLine("----------------------------------------------");


    }
}