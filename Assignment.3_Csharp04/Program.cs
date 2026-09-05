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

        #region Question 4
        void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book Title: {title}");
        }

        PrintBookTitle("Clean Code");
        #endregion

        Console.WriteLine("----------------------------------------------");

        #region Question 5 
         int AddBonusPages(int pages) => pages + 50;
        int pages = 400;
        Console.WriteLine($"Total pages after bonus: {AddBonusPages(pages)}");
        Console.WriteLine($"Pages: {pages}");
        // No changes to the original pages variable , And that's because of calling by value.
        #endregion

        Console.WriteLine("----------------------------------------------");

        #region Question 6
       double ApplyDiscount(double[] prices) => prices[0] - 5;
        double[] Prices = { 25.5, 40.0 }; 
        Console.WriteLine($"Discounted price: {ApplyDiscount(Prices)}");
        Console.WriteLine($"Original prices: [{Prices[0]}]");
        // The Original value definitely changed because of calling by reference. 
        // arrays works by reference 
        #endregion

        Console.WriteLine("----------------------------------------------");

        #region Question 7

        #endregion
    }
}