using EcommerceWA.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceWA.Application.Interfaces
{
    public interface IPurchaseOrderService
    {
        Task<List<PurchaseOrderQueryDto>> GetPurchaseOrders(int skip, int take);
    }
}
