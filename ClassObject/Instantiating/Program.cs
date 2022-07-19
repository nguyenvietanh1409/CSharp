class House
{
    public string HouseName;
    public int Members;
}
class Program
{
    static void Main(string[] args)
    {
        House londonHouse = new House { HouseName = "London street", Members = 3 };
        Console.WriteLine("House Name: {0}, Member {1}", londonHouse.HouseName, londonHouse.Members);
    }
}