using Delopgaveprojekt.DbFactory;
using Delopgaveprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    public class VaerktoejskasseRepository : IVaerktoejskasseRepository
    {
        private const string tableName = "";
        private readonly IDbFactory _dbFactory;

        public VaerktoejskasseRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public void AddVaerktoejskasse(Vaerktoejskasse vaerktoejskasse)
        {
            if (vaerktoejskasse != null)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Insert<Vaerktoejskasse>(vaerktoejskasse);
                }
            }
        }

        public void DeleteVaerktoejskasse(int id)
        {
            if (id != 0)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Delete<Vaerktoejskasse>(@"DELETE * FROM @0 WHERE VTKId= @1", tableName, id);
                }
            }
        }

        public Vaerktoejskasse GetById(int id)
        {
            if (id != 0)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    return db.FirstOrDefault<Vaerktoejskasse>(@"SELECT * FROM @0 WHERE VTKId= @1", tableName, id);
                }
            }
            return null;
        }

        public List<Vaerktoejskasse> GetVaerktoejskasses()
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.OpenSharedConnection();
                return db.Fetch<Vaerktoejskasse>(@"SELECT * FROM @0 ORDER BY VTKAnskaffet DESC", tableName);
            }
        }

        public void UpdateVaerktoejskasse(Vaerktoejskasse vaerktoejskasse)
        {
            if (vaerktoejskasse != null)
            {
                using (var db = _dbFactory.GetConnection())
                {
                    db.OpenSharedConnection();
                    db.Update<Vaerktoejskasse>(tableName, "VTKId", vaerktoejskasse);
                }
            }
        }
    }
}
