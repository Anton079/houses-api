using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class NullPriceException:Exception
    {
        public NullPriceException() : base(ExceptionMessage.NullPriceException) { }
    }
}
