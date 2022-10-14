using AutoMapper;
using EcommerceWA.Application.DTO;
using EcommerceWA.Application.Interfaces;
using EcommerceWA.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceWA.Application.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IMapper mapper;
        private readonly IPurchaseOrderRepository purchaseOrderRepository;

        public PurchaseOrderService(IPurchaseOrderRepository purchaseOrderRepository, IMapper mapper)
        {
            this.purchaseOrderRepository = purchaseOrderRepository;
            this.mapper = mapper;
        }

        public async Task<List<PurchaseOrderQueryDto>> GetPurchaseOrders(int skip, int take)
        {
            var purchaseOrder = await purchaseOrderRepository.GetPurchaseOrders(skip, take);

            var purchaseOrderQueryDto = mapper.Map<List<PurchaseOrderQueryDto>>(purchaseOrder);

            return purchaseOrderQueryDto;
        }
    }
}
