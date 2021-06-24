using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACOTO.Models.Dto_s
{
     public class MalzemeKayitDto:IDto
    {

        public int malzeme_id { get; set; }

        public decimal? stok_miktar { get; set; }

        [StringLength(50)]
        public string malzeme_Name { get; set; }

        [StringLength(50)]
        public string malzeme_Kod { get; set; }

        [StringLength(50)]
        public string malzeme_Barkod { get; set; }

        [StringLength(50)]
        public string malzeme_Birim { get; set; }

        public int? malzemehareket_miktar { get; set; }
        
    }
}
