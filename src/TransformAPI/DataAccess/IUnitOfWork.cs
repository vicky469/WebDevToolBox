namespace TransformAPI.DataAccess;

public interface IUnitOfWork : IDisposable
{
    IProductRepository ProductRepository { get; }
    void Commit();
}