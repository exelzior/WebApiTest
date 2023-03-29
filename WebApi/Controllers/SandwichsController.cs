using AppModels;
using BusinessIntelligence.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SandwichsController : ControllerBase
    {
        private IBusinessSandwichs _businessSandwichs;

        public SandwichsController(IBusinessSandwichs businessSandwichs) {
            _businessSandwichs = businessSandwichs;
        }

        // GET: api/<SandwichController>
        [HttpGet]
        public async Task<List<Sandwich>> Get()
        {
            return await this._businessSandwichs.GetSandwichs();
        }
    }
}
