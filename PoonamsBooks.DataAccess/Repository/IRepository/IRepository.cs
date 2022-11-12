﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace PoonamsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // Retrieve a category from the database by id
        T Get(int id);


        // List of Categories based on requirements 
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null     // Useful for foreign key references 
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );


        void Add(T entity);     // to add an entity
        void Remove(int id);    // to remove an object or category
        void Remove(T entity);  // another way to remove an object 
        void RemoveRange(IEnumerable<T> entity);    // remove a complete range of entities
    }
}
