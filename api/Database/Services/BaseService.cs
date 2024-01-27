using Api.Database;
using System;
using System.Collections.Generic;

public interface IService<TEntity> where TEntity : class
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(int id);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(int id);
}

public class Service<TEntity, TRepository> : IService<TEntity>
    where TEntity : class
    where TRepository : IRepository<TEntity>
{
    protected readonly TRepository _repository;

    public Service(TRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _repository.GetAll();
    }

    public TEntity? GetById(int id)
    {
        return _repository.GetById(id);
    }

    public void Add(TEntity entity)
    {
        _repository.Add(entity);
    }

    public void Update(TEntity entity)
    {
        _repository.Update(entity);
    }

    public void Delete(int id)
    {
        _repository.Delete(id);
    }
}