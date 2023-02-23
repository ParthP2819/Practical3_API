using Practical3_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_API.DataAccess.Repository.IRepository
{
    public interface IOrderRepository : IRepository<Orders>
    {
        void add(Orders order);
        void Update(Orders obj);
    }
}
