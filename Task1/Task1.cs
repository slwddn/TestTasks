namespace Task1;

class Task1
{
    static void Main(string[] args)
    {
        if (args.Length < 2 ||
            string.IsNullOrWhiteSpace(args[0]) ||
            string.IsNullOrWhiteSpace(args[1]))
        {
            throw new ArgumentException("Не заполнены аргументы командной строки >:(");
        }

        var maxValue = int.Parse(args[0]);
        var interval = int.Parse(args[1]);

        var myArray = new int[maxValue];

        for (var i = 0; i < maxValue; i++)
        {
            myArray[i] = i + 1;
        }

        var resultIntegers = new List<int>();

        var index = 0;
        do
        {
            resultIntegers.Add(myArray[index]);

            index += (interval - 1);
            index = index % myArray.Length;
        } while (myArray[index] != myArray[0]);

        foreach (var integerValue in resultIntegers)
        {
            Console.Write(integerValue);
        }
        
        Console.ReadLine();
    }
}