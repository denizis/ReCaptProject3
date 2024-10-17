using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car>GetAll();
          //Kategori id sine göre getir. Markaya(Brand)a göre olabilir.
        List<Car> GetAllByCategoryıd(int id);

        //en az x fiyat ile en çok y fiyat aralığından getir.
        List<Car>GetByUnitPrice(decimal min,decimal max);
        void Add(Car entity);


    }
}
