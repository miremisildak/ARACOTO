using ARACOTO.Models.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARACOTO.DataAccess
{
    public interface IMalzemeDal
    {
        List<MalzemeKayitDto> MalzemeList();
    }
}
