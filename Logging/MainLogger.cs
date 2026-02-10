namespace VetMedicationMinimalApi.Logging
{
    public class MainLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
