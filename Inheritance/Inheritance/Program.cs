class Product
{
    public int id;
    public string name;
    public double price;

    public virtual void showInfo()
    {
        Console.WriteLine("Product ID: " + id);
        Console.WriteLine("Product Name: " + name);
        Console.WriteLine("Product Price: $" + price);
    }
}

class Laptop : Product
{
    public string ram;
    public string chip;
    public Laptop(int id, string name, double price, string ram, string chip)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.ram = ram;
        this.chip = chip;
    }

    public override void showInfo()
    {
        Console.WriteLine("Product ID: " + id);
        Console.WriteLine("Product Name: " + name);
        Console.WriteLine("Product Price: $" + price);
        Console.WriteLine("Laptop RAM: "+ ram);
        Console.WriteLine("Laptop Chip: "+ chip);
    }
}

class Book : Product
{
    public string author;

    public Book(int id, string name, double price, string author)
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.author = author;
    }

    public override void showInfo()
    {
        Console.WriteLine("Product ID: " + id);
        Console.WriteLine("Product Name: " + name);
        Console.WriteLine("Product Price: $" + price);
        Console.WriteLine("Book Author: " + author);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop = new Laptop(1, "Acer Aspire 7", 860, "8GB", "Intel Core i5 10300H");
        Book book = new Book(2, "Dac nhan tam", 4.5, "Dale Carnegie");

        Console.WriteLine("---- Laptop ----");
        laptop.showInfo();
        Console.WriteLine("---- Book ----");
        book.showInfo();
    }
}