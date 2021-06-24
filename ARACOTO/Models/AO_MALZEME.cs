namespace ARACOTO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AO_MALZEME
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Kod { get; set; }

        [StringLength(50)]
        public string Barkod { get; set; }

        [StringLength(50)]
        public string Birim { get; set; }

        public bool Durum { get; set; }
    }
}
