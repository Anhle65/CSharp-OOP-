using System;
using System.Data.Common;

namespace Interface
{
    public class Order
    {
        public int Id { get; set; }
        public Shipment Shipment { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice {get; set; }
    }
}
