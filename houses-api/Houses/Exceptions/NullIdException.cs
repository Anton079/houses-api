using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class NullIdException : Exception
    {
        public NullIdException() : base(ExceptionMessage.NullIdException) { }
    }
}
