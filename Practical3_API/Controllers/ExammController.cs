using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Practical2.Models;
using Practical3_API.DataAccess.Repository.IRepository;
using Practical3_API.Models;
using System.Data;
using System.Net;

namespace Practical3_API.Controllers
{
    [Authorize(Roles = "admin,user")]
    [Route("api/[controller]")]
    [ApiController]
    public class ExammController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        public ExammController(IUnitOfWork unitOfWork)
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

        
        
    }
}
