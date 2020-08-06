namespace TextFilter.Core
{
    public interface ITextFilter
    {
        void SetNextHandler(ITextFilter handler);
        void Process(Request request);
    }
}
