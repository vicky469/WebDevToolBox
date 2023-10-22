using System.Data;
using TransformAPI.Model.Entity;

namespace TransformAPI.DataAccess.Impl;

public class ProductRepository : RepositoryBase<ProductEntity>, IProductRepository
{
    public ProductRepository(IDbTransaction transaction) : base(transaction)
    {
    }
}