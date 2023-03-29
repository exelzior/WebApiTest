using AppModels;
using BusinessIntelligence.Interfaces;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessIntelligence.Implementations
{
    public class BusinessSandwichs : IBusinessSandwichs
    {
        private ISandwichs sandwich;

        public BusinessSandwichs(ISandwichs sandwich)
        {
            this.sandwich = sandwich;
        }

        public Task<List<Sandwich>> GetSandwichs()
        {
            return Task.Run(() =>
            {
                return this.sandwich.GetSandwich();
            });
        }
    }
}
