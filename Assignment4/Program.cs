using System.ComponentModel;

namespace Assignment_4_Session_6.Enum
{
    
    internal class Program
    {
        static double Add(int num1, int num2) { return num1 + num2; }
        static double sub(int num1, int num2) { return num1 - num2; }
        static double mul(int num1, int num2) { return num1 * num2; }
        static double div(int num1, int num2) { return num1 / num2; }
        static void calculateCircle(double radius, out double circum, out double area) {
            circum = 2 * 3.14 * radius;
            area = 3.14 * radius * radius;
        }
        static void Main(string[] args)
        {
            #region part1 Question1
      
            Console.WriteLine("Enter a day Number (0-6)");
            bool flag1 = int.TryParse(Console.ReadLine(), out int num);

            if (!flag1 || num < 0 || num > 6)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            DayOfWeek day = (DayOfWeek) num;
            Console.WriteLine($"Day is: {day}");
            switch (day)
            {
                case DayOfWeek.friday:
                case DayOfWeek.saturday:
                    Console.WriteLine("it is weekend");
                    break;
                case DayOfWeek.sunday:
                case DayOfWeek.monday:
                case DayOfWeek.tuesday:
                case DayOfWeek.wedensday:
                    Console.WriteLine("it is weekday");
                    break;
                default:
                    Console.WriteLine("Unknown day");
                    break;

            }
            #endregion
            #region part2  Question1
           
            Console.WriteLine("Enter the Array Size");
            bool flag2 = int.TryParse(Console.ReadLine(), out int size);
            
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element[{i}]: ");
                array[i]=int.Parse(Console.ReadLine());
            }
            int sum = 0, max = array[0],min = array[0];
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
                if(max < array[i]) { max=array[i]; }
                if(min > array[i]) { min=array[i]; }
            }
            double avg = sum / array.Length;
            Console.WriteLine($"the Sum of Array is : {sum}");
            Console.WriteLine($"the Avg of Array is : {avg}");
            Console.WriteLine($"the Max of Array is : {max}");
            Console.WriteLine($"the Min of Array is : {min}");
            // reverse
            Console.WriteLine("\nArray in reverse:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            #endregion
            #region part2  Question2
                int[,] grades = new int[3, 4];
                for (int student = 0; student < 3; student++)
                {
                    Console.WriteLine($"\nEnter grades for Student {student + 1}:");

                    for (int subject = 0; subject < 4; subject++)
                    {
                        Console.Write($"Subject {subject + 1}: ");
                        grades[student, subject] = int.Parse(Console.ReadLine());
                    }
                }

                double totalSum = 0;
                for (int student = 0; student < 3; student++)
                {
                    int sum1 = 0;

                    for (int subject = 0; subject < 4; subject++)
                    {
                        sum1 += grades[student, subject];
                    }

                    double avg1 = (double)sum1 / 4;
                    Console.WriteLine($"\nStudent {student + 1} Average = {avg1}");

                    totalSum += sum1;
                }

                double classAverage = totalSum / (3 * 4);

                Console.WriteLine($"\nClass Average = {classAverage}");

            #endregion
            #region Part 3 Question 1
            Console.WriteLine("Enter the first Number");
            bool flagn1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter the second Number");
            bool flagn2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter the operation  (+, -, *, /): ");
            string op = Console.ReadLine();
            double result = 0;
            switch (op)
            {
                case "+":
                    result = Add(num1, num2);
                    Console.WriteLine($"the output of :{num1} {op} {num2} = {result}");
                    break;
                case "-":
                    result = sub(num1, num2);
                    Console.WriteLine($"the output of :{num1} {op} {num2} = {result}");
                    break;
                case "*":
                    result = mul(num1, num2);
                    Console.WriteLine($"the output of :{num1} {op} {num2} = {result}");
                    break;
                case "/":
                    if(num2 == 0) {
                        Console.WriteLine(" Error division by zero "); return;}
                    result = div(num1, num2);
                    Console.WriteLine($"the output of :{num1} {op} {num2} = {result}");
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
            #endregion
            #region Part 3 Question 2
            Console.WriteLine("Enter the radius");
            double r = double.Parse(Console.ReadLine());
            calculateCircle(r, out double p, out double area);
            Console.WriteLine($"the circumference is: {p}");
            Console.WriteLine($"the area  is: {area}");

            #endregion
        }
    }
}
