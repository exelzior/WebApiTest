using AppModels;
using BusinessIntelligence.Implementations;
using BusinessIntelligence.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private IBusinessMenu _businessMenu;

        public MenuController(IBusinessMenu businessMenu)
        {
            _businessMenu = businessMenu;
        }

        // GET: api/<MenuController>
        [HttpGet]
        public async Task<Menu> Get()
        {
            return await _businessMenu.GetMenu();
        }

    }
}
