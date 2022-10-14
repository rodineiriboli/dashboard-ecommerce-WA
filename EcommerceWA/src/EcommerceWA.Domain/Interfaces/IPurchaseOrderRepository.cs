using EcommerceWA.Domain.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceWA.Domain.Interfaces
{
    public interface IPurchaseOrderRepository
    {
        Task<List<PurchaseOrderQuery>> GetPurchaseOrders(int skip, int take);
    }
}
