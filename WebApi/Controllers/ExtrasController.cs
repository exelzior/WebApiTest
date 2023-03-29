using AppModels;
using BusinessIntelligence.Interfaces;
using DataAccess.Implementations;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtrasController : ControllerBase
    {
        private IBusinessExtras _businessExtras;

        public ExtrasController(IBusinessExtras businessExtras)
        {
            _businessExtras = businessExtras;
        }
        // GET: api/<ExtrasController>
        [HttpGet]
        public async Task<List<Extra>> Get()
        {
            return await _businessExtras.GetExtras();
        }
    }
}
