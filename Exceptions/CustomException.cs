using System;

namespace ExWorkshop.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) :base(message) {}
    }
}

