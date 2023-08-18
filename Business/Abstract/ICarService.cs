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
        //GetCarsByBrandId , GetCarsByColorId 
        List<Car> GetAll();
        List<Car> GetAllById(int id);//id ye göre listele
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
    }
}
