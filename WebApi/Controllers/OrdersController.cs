using AppModels;
using BusinessIntelligence.Interfaces;
using DataAccess.Implementations;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IBusinessOrders _businessOrders;

        public OrdersController(IBusinessOrders businessOrders)
        {
            _businessOrders = businessOrders;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<List<Order>> Get()
        {
            return await _businessOrders.GetOrders();
        }

        // POST api/GetTotalPrice
        [HttpPost("GetTotalPrice")]
        public async Task<IActionResult> GetTotalPrice(Order order)
        {
            try
            {

                return Ok( await _businessOrders.GetTotalPrice(order));
            }
            catch (Exception ex)
            {
                return StatusCode(406, ex.Message);
            }
        }

        // POST api/SaveOrder
        [HttpPost("SaveOrder")]
        public async Task<HttpStatusCode> SaveOrder(Order order)
        {
            if (await _businessOrders.SaveOrder(order))
                return HttpStatusCode.OK;
            else
                return HttpStatusCode.BadRequest;
        }

        // PUT api/UpdateOrder
        [HttpPut("UpdateOrder")]
        public async Task<HttpStatusCode> UpdateOrder(Order order)
        {
            if (await _businessOrders.UpdateOrder(order))
                return HttpStatusCode.OK;
            else
                return HttpStatusCode.BadRequest;
        }

        // DELETE api/DeleteOrder/5
        [HttpDelete("DeleteOrder/{id}")]
        public async Task<HttpStatusCode> Delete(int id)
        {
            if (await _businessOrders.DeleteOrder(id))
                return HttpStatusCode.OK;
            else
                return HttpStatusCode.BadRequest;
        }
    }
}
