using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace houses_api.Houses.Models
{
    [Table("house")]
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("model")]
        public string model { get; set; }

        [Required]
        [Column("rooms")]
        public int rooms { get; set; }

        [Required]
        [Column("price")]
        public int price { get; set; }


    }
}
