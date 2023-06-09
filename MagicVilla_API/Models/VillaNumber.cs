﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Models
{
    public class VillaNumber
    {
        // Disable Identity Column as we don't want database to automatically generate the number
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VillaNo { get; set; }

        [ForeignKey("Villa")]
        public int VillaId { get; set; }

        // Navigation Property for Foreign Key
        public Villa Villa { get; set; }

        public string SpecialDetails { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
