using System.Linq;
using MinSumNumberArray.Monad;

namespace MinSumNumberArray
{
    public class ImplementationWithLinq : IMathOperation
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

            var masOrder = mas
                .OrderBy(w => w)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < countDigitSum; i++)
            {
                sum += masOrder[i];
            }

            return Return<int>.ReturnSuccessfully(sum);
        }
    }
}
