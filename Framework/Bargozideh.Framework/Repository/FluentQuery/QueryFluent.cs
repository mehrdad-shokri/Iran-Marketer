﻿namespace Bargozideh.Framework.Repository.FluentQuery
{
    //public sealed class QueryFluent<TEntity, TPK> : IQueryFluent<TEntity, TPK> 
    //    where TEntity : class
    //    where TPK : IComparable

    //{
    //    #region Private Fields
    //    private readonly Expression<Func<TEntity, bool>> _expression;
    //    private readonly List<Expression<Func<TEntity, object>>> _includes;
    //    private readonly Repository<TEntity, TPK> _repository;
    //    private Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> _orderBy;
    //    #endregion Private Fields

    //    #region Constructors
    //    public QueryFluent(Repository<TEntity, TPK> repository)
    //    {
    //        _repository = repository;
    //        _includes = new List<Expression<Func<TEntity, object>>>();
    //    }

    //    public QueryFluent(Repository<TEntity, TPK> repository, IQueryObject<TEntity,TPK> queryObject) : this(repository) { _expression = queryObject.Query(); }

    //    public QueryFluent(Repository<TEntity, TPK> repository, Expression<Func<TEntity, bool>> expression) : this(repository) { _expression = expression; }
    //    #endregion Constructors

    //    public IQueryFluent<TEntity,TPK> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
    //    {
    //        _orderBy = orderBy;
    //        return this;
    //    }

    //    public IQueryFluent<TEntity,TPK> Include(Expression<Func<TEntity, object>> expression)
    //    {
    //        _includes.Add(expression);
    //        return this;
    //    }

    //    public Task<IEnumerable<TEntity>> SelectAsync()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    //public IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount)
    //    //{
    //    //    totalCount = _repository.Select(_expression).Count();
    //    //    return _repository.Select(_expression, _orderBy, _includes, page, pageSize);
    //    //}

    //    //public IEnumerable<TEntity> Select()
    //    //{
    //    //    return _repository.Select(_expression, _orderBy, _includes);
    //    //}

    //    //public IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector) { return _repository.Select(_expression, _orderBy, _includes).Select(selector); }

    //    //public async Task<IEnumerable<TEntity>> SelectAsync()
    //    //{
    //    //    return await _repository.SelectAsync(_expression, _orderBy, _includes);
    //    //}

    //    //public IQueryable<TEntity> SqlQuery(string query, params object[] parameters)
    //    //{
    //    //    return _repository.SelectQuery(query, parameters).AsQueryable();
    //    //}
    //}
}