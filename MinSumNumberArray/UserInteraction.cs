using MinSumNumberArray.Monad;
using System;
using System.Linq;

namespace MinSumNumberArray
{
    public class UserInteraction
    {
        private readonly IMathOperation _mathOperation;
        public UserInteraction(IMathOperation mathOperation)
        {
            _mathOperation = mathOperation;
        }

        private bool IsMasNumber(string[] mas)
        {
            return mas
                .Any(w => int.TryParse(w, out _));
        }

        private Return<int[]> StringToArray(string numbers)
        {
            var masString = numbers
                .Split(',');

            if (!IsMasNumber(masString))
            {
                return Return<int[]>.ReturnFail("array_is_not_correct");
            }

            return Return<int[]>.ReturnSuccessfully(masString
                .Select(w => Convert.ToInt32(w))
                .ToArray());
        }

        public void DialogueWithUser()
        {
            Console.WriteLine("Enter the numbers that will be in the array, separated by commas = ");
            string numbersInArray = Console.ReadLine();

            var mas = StringToArray(numbersInArray);
            
            if (!mas.IsTrue)
            {
                Console.WriteLine(mas.Error);
                return;
            }

            Console.Write("Enter the number of numbers to add = ");
            int countDigitSum = Convert.ToInt32(Console.ReadLine());

            var sumMinDigit = _mathOperation.GetSumMinNumbers(mas.Information, countDigitSum);

            Console.WriteLine(sumMinDigit.IsTrue
                ? $"Sum of minimum numbers {sumMinDigit.Information}"
                : $"Error : {sumMinDigit.Error}");
        }
    }
}
