namespace TextFilter.Core
{

    public class Request
    {
        public string Word { get; set; }
        public bool IsValid { get; set; }

        public Request()
        {
            IsValid = true;
        }

    }
}
