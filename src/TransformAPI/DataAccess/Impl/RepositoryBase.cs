using System.Data;

namespace TransformAPI.DataAccess.Impl;

public abstract class RepositoryBase<TEntity> where TEntity : class
{
    public RepositoryBase(IDbTransaction transaction)
    {
        Transaction = transaction;
    }

    protected IDbTransaction Transaction { get; }
    protected IDbConnection Connection => Transaction.Connection;
}