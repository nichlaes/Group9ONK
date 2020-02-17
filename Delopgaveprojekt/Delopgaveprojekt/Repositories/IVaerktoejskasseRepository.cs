using Delopgaveprojekt.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    interface IVaerktoejskasseRepository
    {
        void AddVaerktoejskasse(Vaerktoejskasse vaerktoejskasse);
        List<VaerktoejskasseRepository> GetVaerktoejskasses();
        VaerktoejskasseRepository GetById(int id);
        void UpdateVaerktoejskasse(Vaerktoejskasse vaerktoejskasse);
        void DeleteVaerktoejskasse(int id);
    }
}
