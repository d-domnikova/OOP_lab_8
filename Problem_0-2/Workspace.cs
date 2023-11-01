class Workspace
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();          
            int intValue;
            if (int.TryParse(input, out intValue))
            {
                Box<int> intBox = new Box<int>(intValue);
                Console.WriteLine(intBox.ToString());
            }
            else 
            {
                Box<string> stringBox = new Box<string>(input);
                Console.WriteLine(stringBox.ToString()); 
            }
        }

    }
}