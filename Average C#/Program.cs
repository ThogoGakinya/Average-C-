namespace Average_C_
{
    internal class Program
    {
        static int total;
        static int counter;
        static int currentNumber;
        static string? marks;
        static void Main(string[] args)
        {
            Average();
        }
        public static void Average()
        {
           for(int counter = 0; counter < 20; counter++) 
            {
                Console.WriteLine("Please Enter Marks");
                string marks = Console.ReadLine();
                bool marksChecker = int.TryParse(marks, out currentNumber);

                if (marksChecker) 
                {
                    if(currentNumber == -1) 
                    {
                        int average = total / counter;
                        Console.WriteLine("The Average is {0} ", average);
                        break;
                    }
                    total += currentNumber;
                }
                else
                { 
                    Console.WriteLine("Please Enter an Number");
                    counter--;
                }
            }
           
        }
    }
}
