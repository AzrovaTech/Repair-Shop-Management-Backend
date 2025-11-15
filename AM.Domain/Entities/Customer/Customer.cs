using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.Entities.Customer
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; } = $"USR-{Guid.NewGuid():N}".Substring(0, 12);

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalCode { get; set; }

        public DateTime CreateDate { get; set; }

        #region Relations

        public ICollection<Order.Order> Orders { get; set; }

        #endregion
    }
}
