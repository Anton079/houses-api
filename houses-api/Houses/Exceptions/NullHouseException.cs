using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class NullHouseException:Exception
    {
        public NullHouseException() :base(ExceptionMessage.NullHouseException) {}
    }
}
