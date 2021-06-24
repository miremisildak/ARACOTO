namespace ARACOTO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AO_SERVISFISSATIR
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int servis_id { get; set; }

        public int malzeme_id { get; set; }

        public decimal? miktar { get; set; }

        public decimal? fiyat { get; set; }

        [Required]
        [StringLength(50)]
        public string birim { get; set; }
    }
}
