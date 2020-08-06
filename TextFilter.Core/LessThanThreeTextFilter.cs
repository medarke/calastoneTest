namespace TextFilter.Core
{
    public class LessThanThreeTextFilter : BaseTextFilter
    {
        public override void Process(Request request)
        {
            if (!string.IsNullOrEmpty(request.Word) && request.IsValid)
            {

                if (request.Word.Length < 3)
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
