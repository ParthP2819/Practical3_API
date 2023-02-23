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
    public class OrderRepository : Repository<Orders>, IOrderRepository
    {
        private ApplicationDbContext _db;

        public OrderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Orders obj)
        {
            _db.Orders.Update(obj);
        }
    }
}
