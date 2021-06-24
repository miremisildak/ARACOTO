using ARACOTO.Models;
using ARACOTO.Models.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACOTO.DataAccess
{
    public class EfMalzemeKayit : Model1, IMalzemeDal
    {
        public List<MalzemeKayitDto> MalzemeList()
        {
            using (Model1 context = new Model1())
            {
                var result = from malzeme in AO_MALZEME
                             join malzemehareket in AO_MALZEMEHAREKETLERI
                             on malzeme.id equals malzemehareket.malzeme_id
                             join stok in AO_STOK
                             on malzeme.id equals stok.malzeme_id
                             select new MalzemeKayitDto
                             {
                                 malzeme_id= malzeme.id,
                                 stok_miktar = stok.miktar,
                                 malzeme_Name = malzeme.Name,
                                 malzeme_Kod = malzeme.Kod,
                                 malzeme_Barkod = malzeme.Barkod,
                                 malzeme_Birim = malzeme.Birim,
                                 malzemehareket_miktar = malzemehareket.miktar,
                              
            };
                return result.ToList();
            }
        }
    }
}
