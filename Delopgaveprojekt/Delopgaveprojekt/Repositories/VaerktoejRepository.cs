using Delopgaveprojekt.DbFactory;
using Delopgaveprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    public class VaerktoejRepository : IVaerktoejRepository
    {
        private const string tableName = "";
        private readonly IDbFactory _dbFactory;

        public VaerktoejRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public void AddVaerktoej(Vaerktoej vaerktoej)
        {
            if (vaerktoej != null)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Insert<Vaerktoej>(vaerktoej);
                }
            }
        }
        public void DeleteVaerktoej(int id)
        {
            if (id != 0)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Delete<Vaerktoej>(@"DELETE * FROM @0 WHERE VTId= @1", tableName, id);
                }
            }
        }
        public Vaerktoej GetById(int id)
        {
            if (id != 0)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    return db.FirstOrDefault<Vaerktoej>(@"SELECT * FROM @0 WHERE VTId= @1", tableName, id);
                }
            }
            return null;
        }
        public List<Vaerktoej> GetVaerktoejs()
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.OpenSharedConnection();
                return db.Fetch<Vaerktoej>(@"SELECT * FROM @0 ORDER BY VTAnskaffet DESC", tableName);
            }
        }

        public void UpdateVaerktoej(Vaerktoej vaerktoej)
        {
            if (vaerktoej != null)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Update<Vaerktoej>(tableName, "VTId", vaerktoej);
                }
            }
        }
    }
}
