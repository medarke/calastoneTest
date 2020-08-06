using System;

namespace TextFilter.Core
{
    public abstract class BaseTextFilter : ITextFilter
    {
        protected ITextFilter _nextHandler;
        public BaseTextFilter()
        {
            _nextHandler = null;
        }

        public void SetNextFilter(ITextFilter handler)
        {
            _nextHandler = handler;
        }

        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
