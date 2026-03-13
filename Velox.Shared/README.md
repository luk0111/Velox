Velox.Shared

This project contains DTOs, Enums and Interfaces shared across Velox projects (API, Client, Core). Use it to keep contracts consistent between backend and frontend.

- Interfaces: Velox.Shared.Interfaces
- DTOs: Velox.Shared.DTOs
- Enums: Velox.Shared.Enums

Recommended usage:
- Reference `Velox.Shared` from `Velox.Api` and `Velox.Client`.
- Keep this project free of infrastructure packages (no EF Core here).

Example: add reference from API project

```powershell
cd Velox.Api
dotnet add reference ..\Velox.Shared\Velox.Shared.csproj
```

