﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
      

        public int  Id { get; set; }
        public int BrandId { get; set; } //marka ıd
        public int  ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }// günlük fiyat
        public string Description { get; set; }// tanım 
    }
}
