using System;
using System.Linq;
using MinSumNumberArray.Monad;

namespace MinSumNumberArray
{
    public class OwnImplementationMathOperation : IMathOperation
    {
        public Return<int> GetSumMinNumbers(int[] mas, int countDigitSum)
        {
            if (mas is null)
            {
                return Return<int>.ReturnFail("mas_is_null");
            }

            if (mas.Length == 0)
            {
                return Return<int>.ReturnFail("mas_length_zero");
            }

            if (countDigitSum > mas.Length)
            {
                return Return<int>.ReturnFail("count_digit_sum_many_mas_length");
            }

            var masForSum = mas
                .Take(countDigitSum)
                .OrderBy(w => w)
                .ToArray();

            foreach (var number in mas.Skip(countDigitSum))
            {
                if (masForSum[^1] <= number) continue;

                masForSum[^1] = number;

                Array.Sort(masForSum);
            }

            return Return<int>.ReturnSuccessfully(masForSum.Sum());
        }

    }
}
