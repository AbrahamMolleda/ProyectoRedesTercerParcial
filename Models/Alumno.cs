using System.ComponentModel.DataAnnotations;

namespace Alumnado.Models
{
    public class Alumno
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string ApellidoP { get; set; }
        [Required]
        [MaxLength(50)]
        public string ApellidoM { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}