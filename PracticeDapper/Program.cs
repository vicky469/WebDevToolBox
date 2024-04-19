// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
// using System.Reflection;
// using Dapper;
// using MySqlConnector;
// using Z.Dapper.Plus;
//
// public class Program
// {
//     public static string ConnectionString = FiddleHelper.GetConnectionStringMySql();
//
//     public static void Main()
//     {
//         // CONNECTION
//         using (var connection = new MySqlConnection(ConnectionString))
//         {
//             connection.Open();
//
//             // CREATE TABLE
//             connection.CreateTable<Customer>();
//
//             // SEED
//             var list = new List<Customer>();
//             list.Add(new Customer() { Name = "Jonathan Magnan", Email = "info@zzzprojects.com" });
//             list.Add(new Customer() { Name = "ZZZ Projects", Email = "sales@zzzprojects.com" });
//             list.Add(new Customer() { Name = "Sara", Email = "sara@zzzprojects.com" });
//             connection.BulkInsert(list);
//
//             // CODE
//             var repository = new Repository<Customer>(connection);
//             var customer = repository.GetById(1);
//             customer.Name = "Updated Name";
//             repository.Update(customer);
//
//             // OUTPUT
//             var outputList = connection.Query<Customer>("SELECT * FROM Customer").ToList();
//             FiddleHelper.WriteTable(outputList);
//         }
//     }
//
//     [Table("Customer")]
//     public class Customer
//     {
//         [Key]
//         [Column("CustomerID")]
//         public int Id { get; set; }
//         public string Name { get; set; }
//         public string Email { get; set; }
//     }
//
//     public class Repository<TEntity>
//     {
//         private readonly MySqlConnection _connection;
//
//         public Repository(MySqlConnection connection)
//         {
//             _connection = connection;
//         }
//
//         public TEntity GetById(int id)
//         {
//             var tableName = GetTableName();
//             var primaryKey = GetPrimaryKey();
//
//             var query = $"SELECT * FROM {tableName} WHERE {primaryKey} = @Id";
//             return _connection.QuerySingleOrDefault<TEntity>(query, new { Id = id });
//         }
//
//         public void Update(TEntity entity)
//         {
//             var tableName = GetTableName();
//             var primaryKey = GetPrimaryKey();
//             var properties = GetProperties();
//
//             var updateQuery = $"UPDATE {tableName} SET ";
//             var updateParameters = new DynamicParameters();
//
//             foreach (var property in properties)
//             {
//                 var propertyName = property.Name;
//                 var propertyValue = property.GetValue(entity);
//
//                 updateQuery += $"{propertyName} = @{propertyName}, ";
//                 updateParameters.Add(propertyName, propertyValue);
//             }
//
//             updateQuery = updateQuery.TrimEnd(',', ' ');
//             updateQuery += $" WHERE {primaryKey} = @{primaryKey}";
//             updateParameters.Add(primaryKey, entity.GetType().GetProperty(primaryKey).GetValue(entity));
//
//             _connection.Execute(updateQuery, updateParameters);
//         }
//
//         private string GetTableName()
//         {
//             var tableAttribute = typeof(TEntity).GetCustomAttribute<TableAttribute>();
//             return tableAttribute?.Name ?? typeof(TEntity).Name;
//         }
//
//         private string GetPrimaryKey()
//         {
//             var primaryKeyProperty = typeof(TEntity).GetProperties()
//                 .FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);
//
//             return primaryKeyProperty?.Name;
//         }
//
//         private PropertyInfo[] GetProperties()
//         {
//             return typeof(TEntity).GetProperties();
//         }
//     }
// }
