using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class HouseExistException:Exception
    {
        public HouseExistException() : base(ExceptionMessage.HouseExistException) { }
    }
}
