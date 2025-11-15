using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.DTOs.Customers
{
    public class CustomerTableDTO
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalCode { get; set; }
        public int TotalPayment { get; set; }
    }
}
