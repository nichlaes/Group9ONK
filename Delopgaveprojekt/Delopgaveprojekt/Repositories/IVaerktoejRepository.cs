using Delopgaveprojekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.Repositories
{
    public interface IVaerktoejRepository
    {
        void AddVaerktoej(Vaerktoej vaerktoej);
        List<Vaerktoej> GetVaerktoejs();
        Vaerktoej GetById(int id);
        void UpdateVaerktoej(Vaerktoej vaerktoej);
        void DeleteVaerktoej(Vaerktoej vt);
    }
}
