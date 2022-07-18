namespace School
{
    class Student
    {
        static void Main(string[] args)
        {
            string studentName;
            int english, maths, science;
            float percent = 0, amount = 0;

            Console.Write("Enter the name of the student: ");
            studentName = Console.ReadLine();

            Console.Write("Enter marks in English: ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Maths: ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in Science: ");
            science = Convert.ToInt32(Console.ReadLine());

            if ((english >= 0 && english <= 100) && (maths >= 0 && maths <= 100) && (science >= 0 && science <= 100))
            {
                if (english >= 35 && maths >= 35 && science >= 35)
                {
                    percent = ((english + maths + science) * 100) / 300;

                    if (percent > 75)
                        amount = 1500;
                    else if (percent >= 60 && percent <= 75)
                        amount = 1000;
                    else
                        amount = 0;

                    Console.WriteLine("\nStudent name: " + studentName);
                    Console.WriteLine("Total marks: " + (english + maths + science));
                    Console.WriteLine("Percentage: " + percent + "%");

                    Console.WriteLine("Scholarshop Amount: " + amount + "$");
                }
                else
                {
                    Console.WriteLine("\nStudnet name: " + studentName);
                    Console.WriteLine("Result: Failed");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry of marks");
            }
        }
    }
}