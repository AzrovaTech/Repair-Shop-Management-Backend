using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.Entities.User
{
    public class User
    {
        [Key]
        public string UserId { get; set; } = $"USR-{Guid.NewGuid():N}".Substring(0, 12);

        public string Password { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalCode { get; set; }

        #region Relations

        public ICollection<Order.Order> Orders { get; set; }

        #endregion
    }
}
