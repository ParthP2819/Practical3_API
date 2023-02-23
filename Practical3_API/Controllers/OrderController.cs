using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using Practical2.Models;
using Practical3_API.DataAccess.Repository.IRepository;
using Practical3_API.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Practical3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetCategory/")]
        public IEnumerable<Category> GetCategories()
        {
            return _unitOfWork.Category.GetAll();
        }

        [HttpGet]
        [Route("GetProducts/")]
        public IEnumerable<Product> GetProducts()
        {
            return _unitOfWork.Product.GetAll();
        }
        [HttpGet]
        [Route("GetOrders/")]
        public IEnumerable<Orders> GetOrder()
        {
            var result = _unitOfWork.Order.GetAll();
            return result;
        }
        [HttpPost]
        [Route("AddOrder")]

        public async Task<IActionResult> AddOrder(Orders order)
        {
            _unitOfWork.Order.add(order);
            _unitOfWork.Save();
            return Ok(order);
        }

        [HttpPost]
        [Route("AddOrderItems/")]

        public async Task<IActionResult> AddOrderItems(OrderItems orderItems)
        {
            _unitOfWork.OrderItem.add(orderItems);
            _unitOfWork.Save();
            return Ok(orderItems);
        }
    }
}
