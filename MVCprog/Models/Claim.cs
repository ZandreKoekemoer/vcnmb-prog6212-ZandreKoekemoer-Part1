namespace ContractClaimSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public int LecturerId { get; set; }
        public string Description { get; set; }
        public decimal HoursWorked { get; set; }
        public string Status { get; set; } = "Submitted";
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
    }
}
