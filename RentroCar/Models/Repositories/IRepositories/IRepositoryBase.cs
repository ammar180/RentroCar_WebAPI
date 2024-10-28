﻿namespace RentroCar.Models.Repositories
{
    public interface IEntityReader<T>
    {
        T? GetById(int Id);
        List<T> GetAll();
    }

    public interface IEntityWriter<T>
    {
        void Add(T Entity);
        void Update(T Entity);
    }

    public interface IEntityRemover<T>
    {
        void Delete(T Entity);
    }
    
    public interface IRepositoryBase<T> : IEntityReader<T>, IEntityWriter<T>, IEntityRemover<T>
    {
    }
}