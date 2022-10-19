using System;

namespace EcommerceWA.Domain.Queries
{
    public class PurchaseOrderQuery
    {
        public int OrderPurchaseNumber { get; set; }
        public DateTime OrderPurchaseCreationDate { get; set; }
        public DateTime OrderPurchaseDeliveryDate { get; set; }
        public string OrderPurchaseAddress { get; set; }
        public string DeliveryTeamName { get; set; }
        public string DeliveryTeamVehiclePlate { get; set; }
        public int Total { get; set; }
    }
}
