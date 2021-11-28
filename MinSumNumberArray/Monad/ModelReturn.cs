namespace MinSumNumberArray.Monad
{
    public class ModelReturn<T>
    {
        public bool IsTrue { get; protected set; }
        public string Error { get; protected set; }
        public T Information { get; protected set; }
    }
}