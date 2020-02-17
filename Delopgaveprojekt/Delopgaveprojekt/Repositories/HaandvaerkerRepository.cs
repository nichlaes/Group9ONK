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
        private const string dbo = "";
        private readonly IDbFactory _dbFactory;

        public HaandvaerkerRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public void AddHaandvaerker(Haandvaerker haandvaerker)
        {
            if (haandvaerker != null)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Insert<Haandvaerker>(haandvaerker);
                }
            }
        }
        public void DeleteHaandvaerker(int id)
        {
            if (id != 0)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Delete<Haandvaerker>(@"DELETE * FROM @0 WHERE HaandvaerkerId= @1", dbo, id);
                }
            }
        }

        public Haandvaerker GetById(int id)
        {
            if (id != 0)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    return db.FirstOrDefault<Haandvaerker>(@"SELECT * FROM @0 WHERE HaandvaerkerId= @1", dbo, id);
                }
            }
            return null;
        }

        public List<Haandvaerker> GetHaandvaerkers()
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.OpenSharedConnection();
                return db.Fetch<Haandvaerker>(@"SELECT * FROM @0 ORDER BY HVAnsaettelsedato DESC", dbo);
            }
        }

        public void UpdateHaandvaerker(Haandvaerker haandvaerker)
        {
            if (haandvaerker != null)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Update<Haandvaerker>(dbo, "HaandvaerkerId", haandvaerker);
                }
            }
        }
    }
}
