using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class IdHouseNotFoundException:Exception
    {
        public IdHouseNotFoundException() : base(ExceptionMessage.IdHouseNotFoundException) { }
    }
}
