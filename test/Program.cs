using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a Fulltime or Part-time student? : ");

            string student = Console.ReadLine();
            student = student.ToLower();

            if (student == "fulltime")
            {
                Console.WriteLine("What is your Course of Study? : ");
                string course = Console.ReadLine();
                Console.WriteLine(course + " is a good course. ");
            }
            else if (student == "part-time")
            {
                Console.WriteLine("How many credits are you taking? ; ");
                int credits = Convert.ToInt32(Console.ReadLine());
                if (credits > 6)
                {
                    Console.WriteLine("That's too much unit for a part-time student");
                }
                else
                {
                    Console.WriteLine("Proceed to Screen");
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}

