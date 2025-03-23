using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class PriceExistException:Exception
    {
        public PriceExistException(): base(ExceptionMessage.PriceExistException){}
    }
}
