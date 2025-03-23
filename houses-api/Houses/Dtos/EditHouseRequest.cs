namespace apps_api.Houses.Dtos
{
    public class EditHouseRequest
    {
        public string Type { get; set; }
        public int? Rooms { get; set; }
        public int? Price { get; set; }
    }
}
