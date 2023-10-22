using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;
using TransformAPI.Configuration.Model;

// ref: // https://github.com/timschreiber/DapperUnitOfWork/blob/master/DapperUnitOfWork/UnitOfWork.cs
namespace TransformAPI.DataAccess.Impl;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbConfig _dbConfig;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private IDbConnection _connection;
    private bool _disposed;
    private IProductRepository _productRepository;
    private IDbTransaction _transaction;

    public UnitOfWork(IOptions<DbConfig> dbConfig)
    {
        _dbConfig = dbConfig.Value;
        _connection = CreateConnection();
        _connection.Open();
        _transaction = _connection.BeginTransaction();
    }

    public IProductRepository ProductRepository =>
        _productRepository ?? (_productRepository = new ProductRepository(_transaction));


    public void Commit()
    {
        try
        {
            _transaction.Commit();
        }
        catch
        {
            _transaction.Rollback();
            throw;
        }
        finally
        {
            _transaction.Dispose();
            _transaction = _connection.BeginTransaction();
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private IDbConnection CreateConnection()
    {
        var connectionString =
            $"Server={_dbConfig.Server}; Database={_dbConfig.Database}; User Id={_dbConfig.UserId}; Password={_dbConfig.Password};";
        return new SqlConnection(connectionString);
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }

                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }
            }

            _disposed = true;
        }
    }
}