﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllById(int id)

        {
            return _carDal.GetAll(p => p.Id == id); //her p için p nin Id si id ye eşitse filtrele
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p =>p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=>p.ColorId == colorId);
        }
    }
}
