using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class RoomsExistException:Exception
    {
        public RoomsExistException() :base(ExceptionMessage.HouseExistException) { }
    }
}
