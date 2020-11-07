using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {

        public static double CalculateBMI(double weight, double height)
        {
            height = height * 0.3048;
            weight = weight / 2.205;
            return weight / (height * height);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Your weight (in pounds)");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your height (in feet)");
            var height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("BMI (Body Mass Index): {0}", CalculateBMI(weight, height));
            if (CalculateBMI(weight, height) < 18.5)
            {
                Console.WriteLine("You are underweight. Make sure to eat a little more!");
            } else if (CalculateBMI(weight, height) == 18.5 || (CalculateBMI(weight, height) < 24.9 && CalculateBMI(weight, height) > 18.5))
            {
                Console.WriteLine("You are normal. You are fine!");
            } else if (CalculateBMI(weight, height) > 25 && CalculateBMI(weight, height) < 29.9)
            {
                Console.WriteLine("You are overweight. Make sure to exercise a little more and make some good habits!");
            } else if (CalculateBMI(weight, height) > 30 && CalculateBMI(weight, height) < 34.9)
            {
                Console.WriteLine("You are obese. Do not worry, all you have to do is add good habits and exercise a lot more!");
            } else if (CalculateBMI(weight, height) > 35)
            {
                Console.WriteLine("You are extremely obese. Make sure to exercise so much, and you start doing weights. Control your food consumption.");
            }

        }
    }
}
