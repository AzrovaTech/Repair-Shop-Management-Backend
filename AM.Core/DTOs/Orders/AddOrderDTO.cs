using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.DTOs.Orders
{
    public class AddOrderDTO
    {
        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string OrderName { get; set; }

        public bool OrderStatus { get; set; }

        public int OrderPrice { get; set; }

        public string OrderDescription { get; set; }
    }
}
