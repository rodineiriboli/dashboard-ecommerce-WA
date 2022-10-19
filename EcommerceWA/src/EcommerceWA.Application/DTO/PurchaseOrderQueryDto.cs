using System;

namespace EcommerceWA.Application.DTO
{
    public class PurchaseOrderQueryDto
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
