class Workspace
{
    static void Main(string[] args)
    {
        List<Box<string>> stringList = new List<Box<string>>();
        List<Box<double>> doubleList = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double doubleValue))
            {
                doubleList.Add(new Box<double>(doubleValue));
            }
            else
            {
                stringList.Add(new Box<string>(input));
            }
        }

        string pattern = Console.ReadLine();
        int count = 0;
        if(stringList.Count == 0 && double.TryParse(pattern, out double element))
        {
            count = doubleList.First().compareByValue(doubleList, element);
        } else
        {
            count = stringList.First().compareByValue(stringList, pattern);
        }

        Console.WriteLine(count);
    }
}