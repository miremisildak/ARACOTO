using ARACOTO.Models;
using ARACOTO.Models.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ARACOTO.DataAccess
{
    public class EfAracKayit : Model1, IAracDal
    {
        public List<AracKayitDto> AracList()
        {
            using (Model1 context = new Model1())
            {
                var result = from aractip in context.AO_ARACTIP
                             join arackayit in context.AO_ARACKAYIT
                             on aractip.id equals arackayit.aractip_id
                             join musteri in context.AO_MUSTERILER
                             on arackayit.musteri_id equals musteri.id
                             select new AracKayitDto
                             {
                                 musteri_Name = musteri.Name,
                                 aractip_Name = aractip.Name,
                                 plaka = arackayit.plaka,
                                 notlar = arackayit.notlar,
                                 AracKayit_id = arackayit.id,
                                 musteri_KimlikNo = musteri.KimlikNo,
                                 musteri_TelefonNo = musteri.TelefonNo,
                                 musteri_Sehir = musteri.Sehir
                             };
                return result.ToList();
            }
        }
    }
}
