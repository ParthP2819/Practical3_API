using Practical3_API.DataAccess.Data;
using Practical3_API.DataAccess.Repository.IRepository;
using Practical3_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_API.DataAccess.Repository
{
    public class OrderItemRepository : Repository<OrderItems>, IOrderItemRepository
    {
        private ApplicationDbContext _db;

        public OrderItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(OrderItems obj)
        {
            _db.OrderItems.Update(obj);
        }
    }
}
