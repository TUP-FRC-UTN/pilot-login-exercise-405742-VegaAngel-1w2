using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AltaPiloto.Models
{
    public class Piloto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Piloto { get; set; }
        public string Nombre { get; set; }
        public int cantHorasVuelo { get; set; }
        [ForeignKey("id_Nacionalidad")]
        public int id_Nacionalidad { get; set; }
    } 
} 

