﻿using data_Access_layer.context;
using projectBLL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBLL.repo
{
    public class genericRepo<T> : IgenericRepo<T> where T : class
    {
        private readonly mvcAppDbcontext _context;
        public genericRepo(mvcAppDbcontext context)
        {
            _context = context;
        }
        public int add(T item)
        {
            _context.Add(item);
            return _context.SaveChanges();
        }

        public int delete(T item)
        {
            _context.Remove(item);
            return _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T getbyid(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int update(T item)
        {
            _context.Update(item);
            return _context.SaveChanges();
        }
    }
}
