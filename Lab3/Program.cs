namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        //Problem 1: Simple For Loop  
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        //Problem 2: Even Numbers from 1 to 20 
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
        // Problem 3: While Loop Countdown

        int count = 5;
        while (count >= 1)
        {
            Console.WriteLine(count);
            count--;
        }
        //Problem 4: While Loop – Multiples of 10 from 10 to 1000

        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }
        // Problem 5: Seasons of the Year

        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        // Problem 6: Days of the Week

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine("Day: " + days[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid number. Must be 1 to 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        // Problem 7: Favorite Books and Authors
        string[] books = { "The Alchemist", "Metro 2033", "One Piece" };
        string[] authors = { "Paulo Coelho", "Dmitry Glukhovsky", "Eiichiro Oda" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        // Problem 8: Temperature Tracker

        int[] temps = { 52, 78, 66, 92, 69 };
        Array.Sort(temps);
        foreach (int temp in temps)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine("Lowest: " + temps[0]);
        Console.WriteLine("Highest: " + temps[temps.Length - 1]);
        // Problem 9: Reverse Countdown
           int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
