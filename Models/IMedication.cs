namespace VetMedicationMinimalApi.Models
{
    public interface IMedication
    {
        string Name { get; }
        string Dosage { get; }
        decimal Price { get; }
        DateTime ExpiryDate { get; }
    }
}
