using EcommerceWA.Domain.Interfaces;
using EcommerceWA.Domain.Queries;
using EcommerceWA.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWA.Infra.Data.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly EcommerceWADbContext context;

        public PurchaseOrderRepository(EcommerceWADbContext context)
        {
            this.context = context;
        }
        public Task<List<PurchaseOrderQuery>> GetPurchaseOrders(int skip, int take)
        {
            var purchaseOrderQuery = ((from p in context.PurchaseOrder
                                       join d in context.DeliveryTeam on p.DeliveryTeamId equals d.Id
                                       orderby p.CreationDate
                                       select new PurchaseOrderQuery()
                                       {
                                           OrderPurchaseNumber = p.Number,
                                           OrderPurchaseCreationDate = p.CreationDate,
                                           OrderPurchaseDeliveryDate = p.DeliveryDate,
                                           OrderPurchaseAddress = p.Address,
                                           DeliveryTeamName = d.Name,
                                           DeliveryTeamVehiclePlate = d.VehiclePlate,
                                           Total = (from p in context.PurchaseOrder
                                                    join d in context.DeliveryTeam on p.DeliveryTeamId equals d.Id select p).Count()
                                       })
                                       .Skip(skip)
                                       .Take(take));
            return Task.FromResult(purchaseOrderQuery.ToList());
        }
    }
}
