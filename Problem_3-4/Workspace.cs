class Workspace
{
    static void Main(string[] args)
    {
        List<Box<string>> stringList = new List<Box<string>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            stringList.Add(new Box<string>(input));
        }

        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); ;
        swapMethod(stringList, numbers[0], numbers[1]);

        foreach (Box<string> box in stringList)
        {
            int intValue;
            if (int.TryParse(box.value, out intValue))
            {
                Box<int> intBox = new Box<int>(intValue);
                Console.WriteLine(intBox.ToString());
            }
            else { Console.WriteLine(box.ToString()); }
        }  
    }
    static void swapMethod<T>(List<T> list, int i1, int i2)
    {
        T temporaryBox = list[i1];
        list[i1] = list[i2];
        list[i2] = temporaryBox;
    }
}