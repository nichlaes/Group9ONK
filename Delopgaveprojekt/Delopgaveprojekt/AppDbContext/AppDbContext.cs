using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Delopgaveprojekt.Models;
using Microsoft.EntityFrameworkCore;

namespace Delopgaveprojekt.AppDbContext
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            LoadDefaultData();
        }
        public DbSet<Haandvaerker> Haandvaerkers { get; set; }
        public DbSet<Vaerktoej> Vaerktoejs { get; set; }
        public DbSet<Vaerktoejskasse> Vaerktoejskasses { get; set; }

        public void LoadDefaultData()
        {
            Haandvaerkers.Add(new Haandvaerker { HaandvaerkerId = 0, HVAnsaettelsedato = DateTime.Now, HVEfternavn = "durr", HVFagomraade = "kontanthjælp", HVFornavn = "hurr"});
            Vaerktoejs.Add(new Vaerktoej { VTId = 0, VTAnskaffet = DateTime.Now, VTSerienr = "", VTModel = "test", VTType = "test", VTFabrikat = "" });
        }

        //public Haandvaerker getHaandvarekrById(int id)
        //{
        //    return Haandvaerkers.FirstOrDefault(e => e.HaandvaerkerId == id);
        //}
        //public Vaerktoej getVaerktoejById(int id)
        //{
        //    return Vaerktoejs.FirstOrDefault(e => e.VTId == id);
        //}
        //public Vaerktoejskasse getVaerktoejsKasseById(int id)
        //{
        //    return Vaerktoejskasses.FirstOrDefault(e => e.VTKId == id);
        //}
        //public List<Haandvaerker> getHaandvaerkers() => Haandvaerkers.ToList();
        //public List<Vaerktoej> getVaerktoejs() => Vaerktoejs.ToList();
        //public List<Vaerktoejskasse> getVaerktoejskasse() => Vaerktoejskasses.ToList();

        //public void deleteHaandvarekrById(int id)
        //{
        //    Haandvaerkers.Remove.Find<Haandvaerker>(e => e.HaandvaerkerId == id);
        //}
        //public void deleteVaerktoejById(int id)
        //{
        //    return Vaerktoejs.FirstOrDefault(e => e.VTId == id);
        //}
        //public void deleteVaerktoejsKasseById(int id)
        //{
        //    return Vaerktoejskasses.FirstOrDefault(e => e.VTKId == id);
        //}
    }
}
