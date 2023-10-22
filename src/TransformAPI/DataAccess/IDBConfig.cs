using TransformAPI.Model.Enum;

namespace TransformAPI.DataAccess;

public interface IDBConfig
{
    DbProviderType GetDBType();
    string GetConnectionString();
}