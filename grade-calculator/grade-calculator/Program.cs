/*  Ella Clevens
 *  IGME 201
    10/13/24*/
namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //String variable to hold name of student (me)
            string studentName = "Ella";
            //Create int array of 10 numbers
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };

            //program start
            Console.WriteLine("Welcome " + studentName);
            Console.WriteLine("Here are your grades: ");

            //Loop through grades array
            for (int i = 0; i < grades.Length; i++)
            {
                int grade = grades[i];
                Console.WriteLine(grade);
                //if else statement
                if (100 >= grade && grade >= 90)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grade == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (89 >= grade && grade >= 80)
                {
                    Console.WriteLine("This grade is a B");
                }
                else if (79 >= grade && grade >= 70)
                {
                    Console.WriteLine("This grade is a C");
                }
                else if (69 >= grade && grade >= 65)
                {
                    Console.WriteLine("This grade is a D");
                }
                else if (64 >= grade && grade >= 0)
                {
                    Console.WriteLine("This grade is an F");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }
            //find average
            int sum = 0;
            //loop to calculate sum
            for (int i = 0; i < grades.Length; i++)
            {
                //calculate sum
                sum += grades[i];
            }
            //calculate average
            int average = (int)(sum / grades.Length);

            //display average
            Console.WriteLine("Your final calculated average is: " + average);
            Console.WriteLine("We haved displayed all grades for " + studentName);

        }
    }
}
