using System.ComponentModel.DataAnnotations;

namespace houses_api.Houses.Dtos
{
    public class AddHouseRequest
    {

        [Required(ErrorMessage = " 'Model' este null, trebuie sa il completezi")]
        [StringLength(100, ErrorMessage ="Trebuie sa aiba maxim 100 de caractere")]
        public string Model { get; set; }


        [Required(ErrorMessage = " 'Rooms' este null, trebuie sa il completezi")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Trebuie sa aiba maxim 100 de caractere")]
        public int Rooms { get; set; }


        [Required(ErrorMessage = " 'Price' este null, trebuie sa il completezi")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Trebuie sa aiba maxim 100 de caractere")]
        public int Price { get; set; }
    }
}
