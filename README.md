# API de Integração em C# (.NET + SQL)


📌 Descrição
API REST em **C# (.NET Core)** que demonstra a integração entre clientes e vendas, com persistência em SQL Server.


🛠️ Tecnologias
- .NET 7
- Entity Framework Core
- SQL Server
- Swagger


📂 Como Executar
1. Configure a connection string no `appsettings.json`
2. Execute os comandos:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```
3. Acesse [https://localhost:5001/swagger](https://localhost:5001/swagger)


## Endpoints
- `GET /api/clientes`
- `POST /api/clientes`
- `GET /api/vendas`
- `POST /api/vendas`


---
