﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Bargozideh.Framework.Repository.FluentQuery
{
    public interface IQueryFluent<TEntity,TPK> where TEntity : class 
    {
        IQueryFluent<TEntity,TPK> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
        IQueryFluent<TEntity, TPK> Include(Expression<Func<TEntity, object>> expression);
        //IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount);
        //IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector = null);
        //IEnumerable<TEntity> Select();
        Task<IEnumerable<TEntity>> SelectAsync();
        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);
    }
}