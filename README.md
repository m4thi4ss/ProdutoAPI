# 🛍️ ProdutoAPI

API RESTful para gerenciamento de produto, desenvolvida em .NET 6 com arquitetura em camadas.

---

## 📋 Sobre o Projeto

O **ProdutoAPI** permite criar, listar (com paginação), buscar por ID, atualizar e deletar produtos armazenados em SQLite.  
A estrutura segue boas práticas com camadas separadas para domínio, dados, serviço e apresentação (API).

---

## 🚀 Tecnologias Utilizadas

- 🧠 Linguagem: C# (.NET 6)  
- 🧰 ORM: Entity Framework Core com SQLite  
- 🧪 Documentação via Swagger (Swashbuckle)  
- 🗃️ Controle de versão: Git + GitHub  

---

## 📁 Estrutura do Projeto

Organização em 4 projetos:

### 📂 ProdutoAPI.Domain  
Contém entidades do domínio:  
- `Produto.cs`

---

### 📂 ProdutoAPI.Data  
Responsável pelo acesso ao banco de dados (SQLite) com EF Core:  
- `Context/BancoDeDadosContext.cs`  
- `Interfaces/IProdutoRepository.cs`  
- `Repositories/ProdutoRepository.cs`  
- Pastas `Migrations` (criação das tabelas via migração)

---

### 📂 ProdutoAPI.Service  
Contém a camada de serviço que chama os repositórios:  
- `Interfaces/IProdutoService.cs`  
- `Servicos/ProdutoService.cs`

---

### 📂 ProdutoAPI.Presentation  
Aplicação Web API que expõe os endpoints:  
- `Program.cs` (configuração de DI, EF Core e Swagger)  
- `Controllers/ProdutoController.cs`

---
### Configuração da String de Conexão

Antes de rodar o projeto, substitua o valor de `"ConexaoPadrao"` no arquivo `appsettings.json` pela sua string de conexão real com o banco de dados SQLite.

## 🛠️ Como Executar o Projeto

```bash
# Clone o repositório
git clone https://github.com/m4thi4ss/ProdutoAPI.git
cd ProdutoAPI

# Restaurar pacotes
dotnet restore

# Na pasta do projeto ProdutoAPI.Data, crie e aplique a migração
cd ProdutoAPI.Data
dotnet ef migrations add InicialCriacaoTabelas
dotnet ef database update
