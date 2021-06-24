using ARACOTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ARACOTO.Models.Dto_s;

namespace ARACOTO.DataAccess
{
    public interface IAracDal
    {
        List<AracKayitDto> AracList();
    }
}
