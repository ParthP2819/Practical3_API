using Practical3_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_API.DataAccess.Repository.IRepository
{
    public interface IOrderItemRepository : IRepository<OrderItems>
    {
        void add(OrderItems orderItems);
        void Update(OrderItems obj);
    }
    
}
