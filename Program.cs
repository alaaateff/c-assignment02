using System.Drawing;

namespace secondproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1)
            Console.WriteLine("Please enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            #endregion

            #region question 2)
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");
            #endregion

            #region question 3)
            Console.WriteLine("Please enter 3 number");
            int[] nums;
            int max, min;
            nums = new int[3];
            for (int i = 0; i < 3; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            min = nums[0];
            max = nums[0];
            for (int i = 1; i < 3; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                else if (nums[i] < min)
                    min = nums[i];
            }
            Console.WriteLine("max : " + max);
            Console.WriteLine("min : " + min);



            #endregion

            #region question 4)
            Console.WriteLine("Please enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            #endregion


            #region question 5)
            Console.WriteLine("Please enter character");
            bool isvowel = false;
            char[] vowels = { 'a', 'e', 'I', 'o', 'u' };
            char character = char.Parse(Console.ReadLine());
            for (int i = 0; i < vowels.Length; i++)
            {
                if (character == vowels[i])
                    isvowel = true;
            }
            if (isvowel == true)
                Console.WriteLine("vowel");
            else
                Console.WriteLine("consonant");
            #endregion


            #region question 6)
            Console.WriteLine("Please enter number");
            int num = int.Parse(Console.ReadLine());
            int[] nums = new int[12];
            for (int i = 1; i <= 12; i++)
            {
                nums[i - 1] = num * i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            #endregion

            #region question 7)
            Console.WriteLine("Please enter 2 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int power = 1;
            while (num2 != 0)
            {
                power *= num1;
                num2--;
            }
            Console.WriteLine(power);
            #endregion


            #region question 8)

            Console.WriteLine("Enter Marks of five subjects:");
            int[] marks = new int[5];
            int sum = 0;
            float avg = 0, perc = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                sum += marks[i];
            }
            avg = sum / 5;
            perc = (avg / 100) * 100;
            Console.WriteLine("Total marks" + sum);
            Console.WriteLine("Average Marks" + avg);
            Console.WriteLine("Percentage" + perc);

            #endregion

            #region question 9)
            Console.WriteLine("Please enter number");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 2:
                    Console.WriteLine(29);
                    break;
                case 4:
                    Console.WriteLine(30);
                    break;
                case 6:
                    Console.WriteLine(30);
                    break;
                case 9:
                    Console.WriteLine(30);
                    break;
                case 11:
                    Console.WriteLine(30);
                    break;
                default:
                    Console.WriteLine(31);
                    break;

            }

            #endregion


            #region question 10)

            Console.WriteLine("Enter first coordinates :");
            Console.WriteLine("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second coordinates :");
            Console.WriteLine("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third coordinates :");
            Console.WriteLine("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("y3: ");
            double y3 = double.Parse(Console.ReadLine());

            double slope1 = (y2 - y1) * (x3 - x2);
            double slope2 = (y3 - y2) * (x2 - x1);

            if (slope1 == slope2)
            {
                Console.WriteLine("lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("do not lie on a single straight line.");
            }



            #endregion

            #region question 11)

            Console.WriteLine("please enter time taken in hours");
            float time = float.Parse(Console.ReadLine());
            if (time >= 2 && time < 3)
                Console.WriteLine("they are considered highly efficient.");
            else if (time >= 3 && time < 4)
                Console.WriteLine("they are instructed to increase their speed.");
            else if (time >= 4 && time <= 5)
                Console.WriteLine("they are provided with training to enhance their speed.");
            else if (time > 5)
                Console.WriteLine("they are required to leave the company.");
            #endregion


        }
    }
}
