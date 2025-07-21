namespace CommerceCraft.Api.Dto.AnalyticsDTO
{
    public class GetHighestRevenueProductDto
    {
        public Guid ProductId {  get; set; }

        public decimal Revenue {  get; set; }
    }
}
