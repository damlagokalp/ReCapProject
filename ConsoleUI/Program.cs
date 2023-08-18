// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

CarManager car = new CarManager(new EfCarDal());
foreach (var entity in car.GetAllById(1))

    {
    Console.WriteLine(entity);
    }

