namespace ARACOTO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AO_ARACTIP
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
