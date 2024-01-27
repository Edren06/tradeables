using Api.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public interface IRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
}

public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public BaseRepository(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>();
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public virtual TEntity? GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public virtual void Add(TEntity entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public virtual void Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public virtual void Delete(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}

