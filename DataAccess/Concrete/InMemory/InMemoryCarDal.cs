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
    public class InMemoryCarDal :ICarDal
    {
        // GetById, GetAll, Add, Update, Delete

        List<Car> _cars; //bellekte araba listesi oluşturdu

        public InMemoryCarDal() 
        {

            _cars = new List<Car>() { 
            //ürünler kaydı
            new Car { Id = 1, BrandId=10,ColorId=101,ModelYear=2001,DailyPrice=1200,Description="BMW" },
            new Car { Id = 2, BrandId=11,ColorId=102,ModelYear=2005,DailyPrice=1400,Description="MERCEDES" },

            new Car { Id = 3, BrandId=13,ColorId=103,ModelYear=2020,DailyPrice=1800,Description="FORD" },

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);//listeye araba ekler

        }
        public void Delete(Car car)
        {
            Car carToDelete= null;
            
            carToDelete=_cars.SingleOrDefault(p=> p.Id==car.Id);//LINQ kullanımı listeyi tek dolaşır ıd ler eşit mi kontrol eder

            _cars.Remove(car);
        }
        public void Update(Car car)
        {
            Car carUpdate=_cars.SingleOrDefault(p=>p.Id==car.Id);

            carUpdate.Id= car.Id;
            carUpdate.BrandId= car.BrandId;
            carUpdate.ColorId= car.ColorId;
            carUpdate.DailyPrice= car.DailyPrice;
            carUpdate.Description= car.Description;
            carUpdate.ModelYear= car.ModelYear;
        }
        public List<Car> GetAll() 
        {
            return _cars; 
        }

        public List<Car> GetAllById(int id)
        {
            return _cars.Where(p=> p.Id==id).ToList();

        }

        public List<Car> GetAll(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
