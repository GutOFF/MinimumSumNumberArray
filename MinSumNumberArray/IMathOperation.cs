using MinSumNumberArray.Monad;

namespace MinSumNumberArray
{
    public interface IMathOperation
    {
        Return<int> GetSumMinNumbers(int[] mas, int countDigitSum);
    }
}
