namespace TextFilter.Core
{
    public class ContainsLetterTTextFilter : BaseTextFilter
    {
        public override void Process(Request request)
        {
            if (!string.IsNullOrEmpty(request.Word) && request.IsValid)
            {
                //treat T and t the same? (add tolower())
                if (request.Word.Contains("t"))
                {
                    request.IsValid = false;
                    if (_nextHandler != null) _nextHandler.Process(request);
                }
                if (_nextHandler != null) _nextHandler.Process(request);
            }
            else
            {
                request.IsValid = false;
            }
        }
    }
}
