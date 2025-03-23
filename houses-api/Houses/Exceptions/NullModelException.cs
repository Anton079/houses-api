using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class NullModelException:Exception
    {
        public NullModelException() :base(ExceptionMessage.NullModelException) {}
    }
}
