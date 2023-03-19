using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        [Required]
        [DisplayName("Villa Number")]
        public int VillaNo { get; set; }

        [Required]
        [DisplayName("Villa")]
        public int VillaId { get; set; }

		public VillaDTO Villa { get; set; }

        [DisplayName("Special Details")]
		public string SpecialDetails { get; set; }
        
    }
}
