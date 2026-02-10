using VetMedicationMinimalApi.Models;
using VetMedicationMinimalApi.Logging;

namespace VetMedicationMinimalApi.Services
{
    public class MedicationService
    {
        private readonly IMedication _medication;
        private readonly Logging.ILogger _logger;

        public MedicationService(IMedication medication, Logging.ILogger logger)
        {
            _medication = medication;
            _logger = logger;
        }

        public bool CheckExpiration()
        {
            bool expired = _medication.ExpiryDate < DateTime.UtcNow;

            _logger.Log(
                expired
                    ? $"{_medication.Name} is expired"
                    : $"{_medication.Name} is valid");

            return expired;
        }
    }
}
