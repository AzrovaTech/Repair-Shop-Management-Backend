using AM.Core.DTOs.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.DTOs.Customers
{
    public class CustomerDetailsDTO
    {
        public string CustomerName { get; set; }

        public ICollection<OrderTableDTO> Orders { get; set; }
    }
}
