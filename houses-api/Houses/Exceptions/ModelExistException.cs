using houses_api.System;

namespace houses_api.Houses.Exceptions
{
    public class ModelExistException:Exception
    {
        public ModelExistException() : base(ExceptionMessage.ModelExistException) { }
    }
}
