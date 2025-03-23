using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class NullRoomsException:Exception
    {
        public NullRoomsException() :base(ExceptionMessage.NullRoomsException) {}
    }
}
