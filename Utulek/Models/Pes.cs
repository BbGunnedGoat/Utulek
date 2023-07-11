using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Utulek.Models
{
    public class Pes
    {
        public int Id { get; set; }
        [DisplayName("Jméno")]
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Jmeno { get; set; } = "";
        [DisplayName("Pohlaví")]
        public PohlaviClass.Pohlavi Pohlavi { get; set; }
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Plemeno { get; set; } = "Míšenec";
        [DisplayName("Věk")]
        [Range(0,20, ErrorMessage = "Věk zvířete musí být mezi 0 a 20")]
        public int Vek { get; set; }
        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public decimal Hmotnost { get; set; }
        [DisplayName("Město nálezu")]
        public string? MestoNalezu { get; set; }
        public string? Foto { get; set; }
        [DisplayName("Volný")]
        public bool Volny { get; set; } = true;
    }
}
