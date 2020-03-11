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
        private readonly AppDbContext.AppDbContext _dbContext;

        public HaandvaerkerRepository(AppDbContext.AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddHaandvaerker(Haandvaerker haandvaerker)
        {
            if (haandvaerker != null)
            {
                _dbContext.Haandvaerkers.Add(haandvaerker);
                _dbContext.SaveChanges();

            }
        }
        public void DeleteHaandvaerker(Haandvaerker hv)
        {
            if (hv != null)
            {
                _dbContext.Haandvaerkers.Remove(hv);
                _dbContext.SaveChanges();
            }
        }

        public Haandvaerker GetById(int id)
        {
            if (id != 0)
            {
                return _dbContext.Haandvaerkers.Find(id);
            }
            return null;
        }

        public List<Haandvaerker> GetHaandvaerkers()
        {
            var haandvaerkers = new List<Haandvaerker>();
            try
            {
                haandvaerkers= _dbContext.Haandvaerkers.ToList();
            }
            catch(Exception e)
            {
                haandvaerkers.Add(new Haandvaerker 
                { 
                    HaandvaerkerId = 0,
                    HVAnsaettelsedato = DateTime.Now, 
                    HVFornavn = e.Message, 
                    HVEfternavn = e.InnerException.ToString() 
                });
            }
            return haandvaerkers;
        }

        public void UpdateHaandvaerker(Haandvaerker haandvaerker)
        {
            if (haandvaerker != null)
            {
                _dbContext.Haandvaerkers.Update(haandvaerker);
                _dbContext.SaveChanges();
            }
        }
    }
}
}
