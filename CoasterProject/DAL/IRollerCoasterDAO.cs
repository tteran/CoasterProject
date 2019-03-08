using CoasterProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoasterProject.DAL
{
    public interface IRollerCoasterDAO
    {
        IList<RollerCoaster> GetCoasters();
    }
}
