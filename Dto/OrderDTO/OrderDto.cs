using CommerceCraft.Api.Data;
using CommerceCraft.Api.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CommerceCraft.Api.Dto.OrderDTO
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }

        public Guid UserId { get; set; }


        public DateTime OrderDate { get; set; }
        public decimal TotalPriceAfterDiscount { get; set; }
        public decimal TotalDiscount { get; set; }

        public decimal TotalPrice { get; set; }

        public OrderStatus Status { get; set; }

    }
}
