namespace houses_api.System
{
    public class ExceptionMessage
    {
        // Excepție pentru existența casei
        public static readonly string HouseExistException = "Obiectul casă există deja.";

        // Excepții pentru atributele casei
        public static readonly string NullHouseException = "Obiectul house nu poate fi gol";
        public static readonly string NullIdException = "Atributul ID este null.";
        public static readonly string IdHouseNotFoundException = "Atributul ID nu a fost găsit.";
        public static readonly string NullModelException = "Atributul Model este null, trebuie să îl completezi.";
        public static readonly string NullRoomsException = "Atributul Rooms este null, trebuie să îl completezi.";
        public static readonly string NullPriceException = "Atributul Price este null, trebuie să îl completezi.";

        // Excepții pentru existența atributelor casei
        public static readonly string PriceExistException = "Atributul Price există deja.";
        public static readonly string RoomsExistException = "Atributul Rooms există deja.";
        public static readonly string ModelExistException = "Atributul Model există deja.";

        // Excepție generală pentru lipsa casei
        public static readonly string HouseNotFoundException = "Casa nu a fost găsită.";

    }
}
