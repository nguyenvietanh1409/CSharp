class Authors
{
    static void Main(string[ ]args)
    {
        Array objAuthorID = Array.CreateInstance(typeof(int), 3);
        Array objAuthorNames = Array.CreateInstance(typeof(string), 3);
        Array objAddres = Array.CreateInstance(typeof(string), 3);
        Array objState = Array.CreateInstance(typeof(string), 3);

        string input = "";
        for(int i = 0; i < objAuthorNames.Length; i++)
        {
            Console.Write("Enter the ID of author: ");
            input = Console.ReadLine();
            objAuthorID.SetValue(Convert.ToInt32(input), i);

            Console.Write("Enter the name of author: ");
            input = Console.ReadLine();
            objAuthorID.SetValue(input, i);

            Console.Write("Enter the address: ");
            input = Console.ReadLine();
            objAddres.SetValue(input, i);

            Console.Write("Enter the name of state: ");
            input = Console.ReadLine();
            objState.SetValue(input, i);
            Console.WriteLine();
        }

        Console.WriteLine("\nDetails of the authors: \n");
        Console.WriteLine("Author ID\tName\t\tAddress\t\tState");
        for(int i=0; i<objAuthorNames.Length; i++)
        {
            Console.Write(objAuthorID.GetValue(i) + "\t\t");
            Console.Write(objAuthorNames.GetValue(i) + "\t");
            Console.Write(objAddres.GetValue(i) + "\t");
            Console.Write(objState.GetValue(i));
        }

        Array.Sort(objAuthorNames);

        Console.WriteLine("\nAuthor names after sorting: \n");
        for (int i = 0; i <= objAuthorNames.GetUpperBound(0); i++)
        {
            Console.WriteLine(objAuthorNames.GetValue(i) + "\t");
        }
    }
}