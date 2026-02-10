using VetMedicationMinimalApi.Models;
using VetMedicationMinimalApi.Services;
using VetMedicationMinimalApi.Logging;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 DI
builder.Services.AddSingleton<VetMedicationMinimalApi.Logging.ILogger, MainLogger>();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vet Medication API v1");
    c.RoutePrefix = "swagger"; 
});


app.MapGet("/", () => Results.Redirect("/swagger"));

app.MapPost("/api/medication/checkexpiration",
(
    MedicationReqDto dto,
    VetMedicationMinimalApi.Logging.ILogger logger
) =>
{
    IMedication medication = new PetMedication(
        dto.Name,
        dto.Dosage,
        dto.Price,
        dto.ExpiryDate,
        logger);

    var medService = new MedicationService(medication, logger);
    bool isExpired = medService.CheckExpiration();

    return Results.Ok(new
    {
        medication.Name,
        IsExpired = isExpired
    });
})
.WithName("CheckMedicationExpiry")
.WithOpenApi(); // 👈 important for Swagger

app.Run();
