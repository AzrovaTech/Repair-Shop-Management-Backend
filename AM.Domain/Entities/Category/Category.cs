using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Domain.Entities.Category
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; } = $"Cat-{Guid.NewGuid():N}".Substring(0, 12);

        public string Name { get; set; }

        #region Relations

        public ICollection<Order.Order> Orders { get; set; }

        #endregion
    }
}
