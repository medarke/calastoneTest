namespace TextFilter.Core
{
    public class MiddleVowelTextFilter : BaseTextFilter
    {
        public override void Process(Request request)
        {
            if (!string.IsNullOrEmpty(request.Word) && request.IsValid)
            {
                var middleText = TextFilter.GetMiddleOfString(request.Word);

                if (TextFilter.ContainsVowel(middleText))
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
