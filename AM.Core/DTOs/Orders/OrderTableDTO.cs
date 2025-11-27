namespace AM.Core.DTOs.Orders
{
    public class OrderTableDTO
    {
        public string OrderId { get; set; }

        public string Name { get; set; }

        public string CustomerName { get; set; }

        public int Price { get; set; }

        public bool Status { get; set; }

        public string RecieveDate { get; set; }
    }
}
