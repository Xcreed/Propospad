﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Solution.DAL.Repository
{
    public interface IRepositoryAspNetUsersRoles<T> where T : class
    {
        IQueryable<T> AsQueryble();
        IEnumerable<T> GetAll();
        IEnumerable<T> Search(Expression<Func<T, bool>> predicado);
        T GetOne(Expression<Func<T, bool>> predicado);
        T GetOneById(string id);
        void Commit();
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        void AddRange(IEnumerable<T> t);
        void UpdateRange(IEnumerable<T> t);

        void RemoveRange(IEnumerable<T> t);
    }
}