﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IGenericService<T>
    {
        void Add(T model);
        void Delete(int Id);
        void Update(T model);
        IEnumerable<T> GetAll();
        T Get(int Id);
    }
}