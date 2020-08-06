namespace TextFilter.Core
{
    public interface ITextFilter
    {
        void SetNextFilter(ITextFilter handler);
        void Process(Request request);
    }
}
