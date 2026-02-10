
namespace VetMedicationMinimalApi.Models
{
    public class PetMedication : VetMedicationBase, IMedication
    {
        public PetMedication(
            string name,
            string dosage,
            decimal price,
            DateTime expiryDate,
            Logging.ILogger logger)
            : base(name, dosage, price, expiryDate)
        {
            if (price < 0)
                throw new ArgumentException("Price cannot be negative");

            logger.Log($"Medication created: {name}");
        }
    }
}
