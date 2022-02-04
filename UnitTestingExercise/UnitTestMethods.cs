using System;
using System.Linq;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference


        public static int AddMethod(int num1, int num2, int num3)
        {
            return num1 + num2 + num3; 
        }

        public static int SubtractMethod(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public static int MultiplyMethod(int multnum1, int multnum2)
        {
            return multnum1 * multnum2;
        }

        public static int DivideMethod(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        public string GetHey()
        {
            return "HEY HEY HEY!";
        }

        public string GetVictory()
        {
            return "WE WON, AGAIN!";
        }

        // Create an Add method that passes 3 integers

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers

        // Create a Divide method that passes 2 integers



        // Create 2 methods that will utilize the [Fact] tests you wrote


    }
}
