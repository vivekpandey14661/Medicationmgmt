namespace VetMedicationMinimalApi.Models
{
    public class MedicationReqDto
    {
        public required string Name { get; set; }
        public required string Dosage { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
