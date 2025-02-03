using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace houses_api.Houses.Models
{
    [Table("animal")]
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("street")]
        public string street { get; set; }

        [Required]
        [Column("number")]
        public int Number { get; set; }

        [Required]
        [Column("surface")]
        public int surface { get; set; }

        [Required]
        [Column("price")]
        public int price { get; set; }
    }
}
