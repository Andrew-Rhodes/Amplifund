namespace RhodesShoppe.Api.Models
{
    public class GuitarRepair
    {
        public int Id { get; set; }
        public string GuitarModel { get; set; }
        public string Issue { get; set; }
        public string RepairStatus { get; set; }
        public decimal CostEstimate { get; set; }
        public DateTime DateReceived { get; set; }
    }
}
