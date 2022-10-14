using EcommerceWA.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EcommerceWA.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IPurchaseOrderService purchaseOrderService;
        public PurchaseOrderController(IPurchaseOrderService purchaseOrderService)
        {
            this.purchaseOrderService = purchaseOrderService;
        }

        [HttpGet]
        [Authorize(Roles = "manager")]
        public async Task<ActionResult<dynamic>> GetPurchaseOrder(int skip, int take)
        {
            var purchaseOrders = await purchaseOrderService.GetPurchaseOrders(skip, take);
            return purchaseOrders;
        }
    }
}
