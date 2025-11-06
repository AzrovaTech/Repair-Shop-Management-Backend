using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.Domain.Entities.Order
{
    public class Order
    {
        [Key]
        public string OrderId { get; set; } = $"Ord-{Guid.NewGuid():N}".Substring(0, 12);

        public string OrderName { get; set; }

        public string Description { get; set; }

        public int OrderPrice { get; set; }

        public bool OrderStatus { get; set; }

        public DateTime RecieveDate { get; set; }

        public DateTime FinishDate { get; set; }

        public string UserId { get; set; }

        public string CategoryId { get; set; }

        #region Relations

        [ForeignKey("UserId")]
        public User.User User { get; set; }

        [ForeignKey("CategoryId")]
        public Category.Category Category { get; set; }

        #endregion
    }
}
