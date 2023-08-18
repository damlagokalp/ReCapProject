﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Generic constraint filtreleme sınırlandırma
    //class referans tip olabilir demek
    //IEntity-> ya IEntity olabilir ya da IEntity implemente eden nesne olabilir
    //new() new'lenebilir olmalı

    public interface IEntityRepository<T> where T : class ,IEntity ,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }  
    
}


   