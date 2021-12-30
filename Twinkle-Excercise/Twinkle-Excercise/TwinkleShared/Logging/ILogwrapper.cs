using System;

namespace Store.Logging
{
    public interface ILogwrapper<T> where T : class
    {
        public void Debug(string message);
        public void Error(string message);
        
    }
}
