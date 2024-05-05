namespace Task2;

class Task4
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Укажите путь до файла!");
            return 1;
        }

        var filePath = args[0];
        var lines = File.ReadAllLines(filePath);

        var arrayOfNumbers = Array.ConvertAll(lines, int.Parse);

        var average = (int)Math.Floor(arrayOfNumbers.Average());

        var result = 0;

        foreach (var number in arrayOfNumbers)
        {
            if (number > average)
            {
                result += number - average;
            }

            if (number < average)
            {
                result += average - number;
            }
        }

        Console.WriteLine(result);
        return 0;
    }
}