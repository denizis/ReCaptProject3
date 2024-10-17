using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        //Oracle sql Server gibi
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            
            new Car {CarId=1,BrandId=1,CarDailyPrice=800,CarDescription="Fiat Egea",CarModelYear=2022,CarName="Fiat"},
            new Car {CarId=2,BrandId=2,CarDailyPrice=900,CarDescription="Renault Cilo",CarModelYear=2022,CarName = "Renault "},
            new Car {CarId=3,BrandId=5,CarDailyPrice=700,CarDescription="Pejo 301",CarModelYear=2022,CarName = "Pejo"}
            };

        }


        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.CarId+":Id li Araba sisteme Eklendi ");
        }

        public void Delete(Car car)
        {
            Car carToDelete =_cars.SingleOrDefault(p=>p.CarId==car.CarId);
            _cars.Remove(carToDelete);

            Console.WriteLine(car.CarId + ":Id li Araba sistemden silindi ");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int CarId)
        {
         return _cars.Where(p=>p.CarId== CarId).ToList();
        }

        public void Update(Car car)
        {

           Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.CarId=car.CarId;
            carToUpdate.CarDailyPrice=car.CarDailyPrice;
            carToUpdate.CarDescription=car.CarDescription;
            carToUpdate.CarModelYear=car.CarModelYear;
            carToUpdate.BrandId=car.BrandId; 
            carToUpdate.CarName=car.CarName;
            Console.WriteLine(car.CarId + ":Id li Araba sistemden güncellendi ");

        }
    }
}
