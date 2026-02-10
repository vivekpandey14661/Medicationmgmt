namespace VetMedicationMinimalApi.Models
{
    public abstract class VetMedicationBase
    {
        protected VetMedicationBase(string name, string dosage, decimal price, DateTime expiryDate)
        {
            ValidateFields(name, dosage, expiryDate);

            Name = name;
            Dosage = dosage;
            Price = price;
            ExpiryDate = expiryDate;
        }

        public string Name { get; protected set; }
        public string Dosage { get; protected set; }
        public decimal Price { get; protected set; }
        public DateTime ExpiryDate { get; protected set; }

        protected void ValidateFields(string name, string dosage, DateTime expiryDate)
        {
            if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name is required");

            if (string.IsNullOrWhiteSpace(dosage))
            throw new ArgumentException("Dosage is required");

            if (expiryDate == default)
            throw new ArgumentException("Invalid expiry date");
        }
    }
}
