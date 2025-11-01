using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(int customerId, List<int> productIds);
        Task<decimal> CalculateTotalAmountAsync(List<int> productsIds);
    }
}
