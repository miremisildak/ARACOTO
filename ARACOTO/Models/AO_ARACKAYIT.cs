namespace ARACOTO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AO_ARACKAYIT
    {
        public int id { get; set; }

        public int musteri_id { get; set; }

        public int aractip_id { get; set; }

        [Required]
        [StringLength(50)]
        public string plaka { get; set; }

        [StringLength(50)]
        public string notlar { get; set; }

        public bool Durum { get; set; }
    }
}
