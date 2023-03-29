using AppModels;
using BusinessIntelligence.Interfaces;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessIntelligence.Implementations
{
    public class BusinessExtras : IBusinessExtras
    {
        private readonly IExtras _extras;

        public BusinessExtras(IExtras extras) {
            _extras = extras;
        }

        public Task<List<Extra>> GetExtras()
        {
            return Task.Run(() =>
            {
                return this._extras.GetExtras();
            });
        }
    }
}
