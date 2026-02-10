### Vet Medication Minimal API (.NET)

A clean and modular **ASP.NET Core Minimal API** for managing veterinary medications.  
This project demonstrates **SOLID principles**, **dependency injection**, **Swagger**

## Followed Design Principles

- **Encapsulation** – protected setters, validation inside domain
- **Abstraction** – interfaces for medication and logging
- **Inheritance** – abstract base class for shared logic

##  Tech Stack
# .NET 8 Minimal API
# Swagger (OpenAPI)
# Dependency Injection

## Dot Net bash Command
# dotnet restore
# dotnet build
# dotnet run

## Then navigate to:
http://localhost:5192/swagger/index.html

### Swagger Details
##  URL Method - /api/medication/check-expiry

## Body 
```json
{
    "name": "vivek",
    "dosage": "1",
    "price": 100,
    "expiryDate": "2026-02-10T09:36:49.008Z"
}
```
## Response 
```json
{
  "name": "vivek",
  "isExpired": true
}
```

