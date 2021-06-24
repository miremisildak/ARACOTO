using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACOTO.Models.Dto_s
{
    public class AracKayitDto:IDto
    {


        [Required]
        [StringLength(50)]
        public string plaka { get; set; }

        [StringLength(50)]
        public string notlar { get; set; }

        public int AracKayit_id { get; set; }

        [Required]
        [StringLength(50)]
        public string aractip_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string musteri_KimlikNo { get; set; }

        [StringLength(50)]
        public string musteri_TelefonNo { get; set; }

        [StringLength(50)]
        public string musteri_Sehir { get; set; }

        [Required]
        [StringLength(50)]
        public string musteri_Name { get; set; }
    }
}
