using AppModels;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class Extras : IExtras
    {
        private List<Extra> extraList = new()
        { 
            new Extra{ Name = "Fries", Cost = 2M  },
            new Extra{ Name = "Soft Drink", Cost = 2.5M  },
        };
         
        public List<Extra> GetExtras()
        {
            return extraList;
        }

    }
}
