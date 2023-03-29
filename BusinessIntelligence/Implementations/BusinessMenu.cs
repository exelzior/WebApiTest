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
    public class BusinessMenu : IBusinessMenu
    {
        private readonly IExtras _extras;
        private ISandwichs _sandwich;

        public BusinessMenu(IExtras extras, ISandwichs sandwich)
        {
            this._extras = extras;
            this._sandwich = sandwich;
        }
        public Task<Menu> GetMenu()
        {
            return Task.Run(() =>
            {
                return new Menu { extras = _extras.GetExtras(), sandwiches = _sandwich.GetSandwich() };
            });
        }
    }
}
