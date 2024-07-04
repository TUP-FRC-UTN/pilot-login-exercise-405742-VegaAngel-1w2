using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AltaPiloto.Models
{
    public class Nacionalidad
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Nacionalidad { get; set; }
        public string Nombre { get; set; }
    }
}
