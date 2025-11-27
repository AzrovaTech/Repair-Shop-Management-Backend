using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.DTOs.Orders
{
    public class COrdersIndexDTO
    {
        public string CustomerName { get; set; }
        public List<COrderTableDTO> Orders { get; set; }
    }
}
