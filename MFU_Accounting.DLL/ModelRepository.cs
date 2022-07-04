using MFU_Accounting.DAL.Interfaces;
using MFU_Accounting.Entities;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace MFU_Accounting.DAL
{
    public class ModelRepository : IModelRepository
    {
        private string _connectionString = DbOptions.connectionString;

        public ModelRepository()
        {
        }

        public void AddModel(Model model)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var querry = "INSERT INTO Models (Name, CountFueled, CountEmpty, CountBroken) VALUES (@Name, @CountFueled, @CountEmpty, @CountBroken)";
                db.Query(querry,model);
            }
        }

        public void DeleteModel(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "DELETE FROM Models WHERE ModelId = @Id";
                db.Query(querry,param);
            }
        }

        public List<Model> GetModels()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var querry = "SELECT * FROM Models";
                return db.Query<Model>(querry).ToList();
            }
        }

        public void UpdateBrokenMinuse(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "UPDATE Models SET CountBroken = CountBroken - 1 WHERE ModelId = @Id";
                db.Query(querry, param);
            }
        }

        public void UpdateBrokenPlus(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "UPDATE Models SET CountBroken = CountBroken + 1 WHERE ModelId = @Id";
                db.Query(querry, param);
            }
        }

        public void UpdateEmptyMinus(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "UPDATE Models SET CountEmpty = CountEmpty - 1 WHERE ModelId = @Id";
                db.Query(querry, param);
            }
        }

        public void UpdateEmptyPlus(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "UPDATE Models SET CountEmpty = CountEmpty + 1 WHERE ModelId = @Id";
                db.Query(querry, param);
            }
        }

        public void UpdateFueledMinus(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "UPDATE Models SET CountFueled = CountFueled - 1 WHERE ModelId = @Id";
                db.Query(querry, param);
            }
        }

        public void UpdateFueledPlus(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                var param = new DynamicParameters();
                param.Add("Id", id);
                var querry = "UPDATE Models SET CountFueled = CountFueled + 1 WHERE ModelId = @Id";
                db.Query(querry,param);
            }
        }
    }
}
