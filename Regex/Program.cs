using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string Time = "Завтрак в 09:00";
        Regex regex = new Regex("([0-1][0-9]|2[0-3]):[0-5][0-9]");
        MatchCollection matches = regex.Matches(Time);
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
        else
        {
            Console.WriteLine("Время некорректно");
        }
        
    }
}