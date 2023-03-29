using AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessIntelligence.Interfaces
{
    public interface IBusinessMenu
    {
        Task<Menu> GetMenu();
    }
}
