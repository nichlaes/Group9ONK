using Delopgaveprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    public class VaerktoejskasseRepository : IVaerktoejskasseRepository
    {
        private readonly AppDbContext.AppDbContext _dbContext;

        public VaerktoejskasseRepository(AppDbContext.AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddVaerktoejskasse(Vaerktoejskasse vaerktoejskasse)
        {
            if (vaerktoejskasse != null)
            {
                _dbContext.Vaerktoejskasses.Add(vaerktoejskasse);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteVaerktoejskasse(Vaerktoejskasse vk)
        {
            if (vk!=null)
            {
                _dbContext.Vaerktoejskasses.Remove(vk);
                _dbContext.SaveChanges();
            }
        }

        public Vaerktoejskasse GetById(int id)
        {
            if (id != 0)
            {
                _dbContext.Vaerktoejskasses.Find(id);
            }
            return null;
        }

        public List<Vaerktoejskasse> GetVaerktoejskasses()
        {
            return _dbContext.Vaerktoejskasses.ToList();
        }

        public void UpdateVaerktoejskasse(Vaerktoejskasse vaerktoejskasse)
        {
            if (vaerktoejskasse != null)
            {
                _dbContext.Vaerktoejskasses.Update(vaerktoejskasse);
                _dbContext.SaveChanges();
            }
        }
    }
}
