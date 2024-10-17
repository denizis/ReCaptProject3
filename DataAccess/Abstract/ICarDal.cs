using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{                 
    // I :Interface i belirtir
    //car entity i belirtir.
    // Dal ise Data acces layer  veri erişim objesi
     
                                //EntityRepository Car için yapılandırdım.Ve aldı
    public interface ICarDal:IEntityRepository<Car>
    {

    }
}
