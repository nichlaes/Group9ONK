using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.DbFactory
{
    public interface IDbFactory
    {
        IDatabase GetConnection();
    }
}
