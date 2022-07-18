class Student
{
    public String name;
    public int age;
}
class Class
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.name = "Empty!";
        student.age = 0;
        Console.WriteLine("Student name before: " + student.name);
        Console.WriteLine("Student age before: " + student.age);
        Console.WriteLine("==== Change Value ====");
        changeValue(student);
        Console.WriteLine("Student name after: " + student.name);
        Console.WriteLine("Student age after: " + student.age);
    }
    public static void changeValue(Student n)
    {
        n.name = "Viet Anh";
        n.age = 19;
    }
}