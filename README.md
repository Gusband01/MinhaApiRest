MinhaApiRest
API REST desenvolvida em C# com ASP.NET Core, usando banco de dados SQLite, ideal para fins didáticos e portfólio.

### 📌 Funcionalidades
Esta API possui 3 endpoints principais:

1. '/api/ordenar'
Método: 'POST'
Descrição: Recebe uma lista de números e retorna a mesma lista ordenada.
Exemplo de entrada:
[5, 3, 8, 1]

2. '/api/mensagens'
Métodos:

POST: Salva uma nova mensagem no banco.

GET: Lista todas as mensagens salvas.

Estrutura da mensagem: { "texto": "Olá, mundo!" }

3. '/api/cep/{cep}'
Método: GET

Descrição: Consulta endereço com base no CEP via API do ViaCEP.

Exemplo:

Requisição: /api/cep/01001000

Resposta: { "cep": "01001-000", "logradouro": "Praça da Sé", "bairro": "Sé", "localidade": "São Paulo", "uf": "SP" }

### 🚀 Como executar localmente
✅ Pré-requisitos: .NET SDK 6.0 ou superior

SQLite (opcional para visualizar o banco)

### 🧭 Passos:
git clone https://github.com/Gusband01/MinhaApiRest.git cd MinhaApiRest dotnet restore dotnet ef database update dotnet run

### 🧪 Testar via Swagger
Após executar o projeto, acesse:

http://localhost:5176/swagger (A porta pode mudar, portanto se atente ao terminal) Você poderá testar todos os endpoints por uma interface visual interativa.

### 💡 Tecnologias Usadas
ASP.NET Core Web API

Entity Framework Core (SQLite)

Swagger (Swashbuckle)

API pública ViaCEP

### 📂 Estrutura do Projeto
MinhaApiRest/ ├── Controllers/ │ ├── OrdenarController.cs │ ├── MensagensController.cs │ └── CepController.cs ├── Data/ │ └── AppDbContext.cs ├── Models/ │ └── Mensagem.cs ├── Program.cs

### 👤 Autor
Gustavo Bandeira Estudante de Engenharia de Software | GitHub: https://github.com/Gusband01
