using System;
using System.Collections.Generic;

namespace EcommerceWA.Domain.Entities
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }

        //Reference entityframwork map
        public int DeliveryTeamId { get; set; }
        public DeliveryTeam DeliveryTeam { get; set; }


        //Reference entityframwork map
        public ICollection<Product> Product { get; set; }
    }
}
