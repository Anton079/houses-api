using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class HouseNotFoundException:Exception
    {
        public HouseNotFoundException() :base(ExceptionMessage.HouseExistException) { }
    }
}
