using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
           if(car.CarName.Length>2 && car.CarDailyPrice>0)
            {

                _carDal.Add(car);
                Console.WriteLine("Sisteme eklendi "+car.CarId+" "+car.CarName );
            }
            else
            {
                Console.WriteLine("Sisteme Eklenmedi");
            }
        }

        public List<Car> GetAll()
        {
            //İş Kodları
            // Yetkisi varmı kontrol edebilr burada

            return _carDal.GetAll();
                 
        }
        //Sonraan implemente ettim önce ICarServic e ekledim
        public List<Car> GetAllByCategoryıd(int id)
        {
            //benim gönderdiğim İd Marka id sine eşitse gönder demek Ekrana getir.
            return _carDal.GetAll(p => p.BrandId == id);
        }

        //en az x fiyat ile en çok y fiyat aralığında getir.
        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.CarDailyPrice >=min && p.CarDailyPrice<=max);
        }
    }
}
