using Delopgaveprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    interface IVaerktoejskasseRepository
    {
        void AddVaerktoejskasse(Vaerktoejskasse vaerktoejskasse);
        List<Vaerktoejskasse> GetVaerktoejskasses();
        Vaerktoejskasse GetById(int id);
        void UpdateVaerktoejskasse(Vaerktoejskasse vaerktoejskasse);
        void DeleteVaerktoejskasse(int id);
    }
}
