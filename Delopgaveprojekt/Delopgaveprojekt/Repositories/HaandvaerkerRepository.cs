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
        private readonly IDbFactory _dbFactory;

        public HaandvaerkerRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public void AddHaandvaerker(Haandvaerker haandvaerker)
        {
            using (var db = _dbFactory.GetConnection())
            {
                db.OpenSharedConnection();
                db.Insert<Haandvaerker>(haandvaerker);
            }
        }

        public void DeleteHaandvaerker(int id)
        {
            throw new NotImplementedException();
        }

        public Haandvaerker GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Haandvaerker> GetHaandvaerkers()
        {
            throw new NotImplementedException();
        }

        public void UpdateHaandvaerker(Haandvaerker haandvaerker)
        {
            throw new NotImplementedException();
        }
    }
}
