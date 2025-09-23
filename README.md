# API de Integração em C# (.NET + SQL)

## 📌 Descrição
Este projeto é uma API REST desenvolvida em **C# (.NET Core)** que realiza integração entre sistemas de vendas e clientes.  
O objetivo é demonstrar como criar endpoints seguros e escaláveis para consumo de dados corporativos.

## 🛠️ Tecnologias Utilizadas
- C# / .NET 6
- Entity Framework Core
- SQL Server
- Swagger para documentação

## 📂 Estrutura do Projeto
- `/Controllers` → Endpoints da API  
- `/Models` → Entidades e DTOs  
- `/Data` → Contexto e repositórios de banco de dados  

## 🚀 Como Executar
1. Clone o repositório  
2. Configure a connection string no `appsettings.json`  
3. Rode as migrations:  
   ```bash
   dotnet ef database update
