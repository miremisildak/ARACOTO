namespace ARACOTO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AO_MALZEMEHAREKETLERI
    {
        public int id { get; set; }

        public int malzeme_id { get; set; }

        public int/*?*/ miktar { get; set; }

        public bool Durum { get; set; }
    }
}
