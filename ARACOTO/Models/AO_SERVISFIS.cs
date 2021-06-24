namespace ARACOTO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AO_SERVISFIS
    {
        public int id { get; set; }

        public int AracKayıt_id { get; set; }

        public int Aractip_id { get; set; }

        [StringLength(50)]
        public string FisNo { get; set; }

        [StringLength(50)]
        public string AracGetiren { get; set; }

        public DateTime? Tarih { get; set; }
    }
}
