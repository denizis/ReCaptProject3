using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


internal class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car{ BrandId = 1, CarId = 14, CarDailyPrice = 500, CarModelYear = 2022, CarName = "Renault", CarDescription = "2022 model Renault" };



        CarManager carManager =new CarManager(new EfCarDal());

        carManager.Add(car1);
        




        //Fiyatı 800 ile 800 arasındaki Arabların fiyatını getir.
        //   foreach (var car in carManager.GetByUnitPrice(500,800))
        //{
        //      Console.WriteLine(car.CarId+" "+car.CarDescription);
        //}







        //Kategori Numarası 2 olan Arabaları getir Demek
        //foreach (var car in carManager.GetAllByCategoryıd(2))
        //{
        //    Console.WriteLine(car.CarId + " " + car.CarDescription);
        //}



        //Bütün Arabaları Getir.Sistemdeki bütün Arabaları getri.
        foreach (var car in carManager.GetAll())
        {
        Console.WriteLine(car.CarId+" "+car.CarName);
        }


        Console.Read();

    }

}