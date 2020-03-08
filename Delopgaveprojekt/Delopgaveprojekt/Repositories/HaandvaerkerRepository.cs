using Delopgaveprojekt.DbFactory;
using Delopgaveprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    public class HaandvaerkerRepository : IHaandvaerkerRepository
    {
        private const string tableName = "dbo.Haandvaerker";
        private readonly AppDbContext.AppDbContext _dbContext;

        public HaandvaerkerRepository(AppDbContext.AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddHaandvaerker(Haandvaerker haandvaerker)
        {
            if (haandvaerker != null)
            {
                _dbContext.Haandvaerkers.Local.Add(haandvaerker);

            }
        }
        //    public void DeleteHaandvaerker(int id)
        //    {
        //        if (id != 0)
        //        {
        //            using (var db = _dbContext.GetConnection())
        //            {
        //                db.OpenSharedConnection();
        //                db.Delete<Haandvaerker>(@"DELETE * FROM dbo.Haandvaerker WHERE HaandvaerkerId= @1", tableName, id);
        //            }
        //        }
        //    }

        //    public Haandvaerker GetById(int id)
        //    {
        //        if (id != 0)
        //        {
        //            using (var db = _dbContext.GetConnection())
        //            {
        //                db.OpenSharedConnection();
        //                return db.FirstOrDefault<Haandvaerker>(@"SELECT * FROM @0 WHERE HaandvaerkerId= @1", tableName, id);
        //            }
        //        }
        //        return null;
        //    }

        public List<Haandvaerker> GetHaandvaerkers()
        {
            return _dbContext.Haandvaerkers.Local.ToList();
            //using (var db = _dbContext.GetConnection())
            //{
            //    db.OpenSharedConnection();
            //    return db.Fetch<Haandvaerker>(@"SELECT * FROM dbo.haandvaerker ORDER BY HVAnsaettelsedato DESC");
            //}
        }

        //    public void UpdateHaandvaerker(Haandvaerker haandvaerker)
        //    {
        //        if (haandvaerker != null)
        //        {
        //            using (var db = _dbContext.GetConnection())
        //            {
        //                db.OpenSharedConnection();
        //                db.Update<Haandvaerker>(tableName, "HaandvaerkerId", haandvaerker);
        //            }
        //        }
        //    }
        //}
    }
}
