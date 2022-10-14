using System.Collections.Generic;

namespace EcommerceWA.Domain.Entities
{
    public class DeliveryTeam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VehiclePlate { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrder { get; set; }
    }
}
