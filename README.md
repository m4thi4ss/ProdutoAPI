#  ProdutoAPI

API RESTful para gerenciamento de produto, desenvolvida em .NET 6 com arquitetura em camadas.

---

## Sobre o Projeto

O **ProdutoAPI** permite criar, listar (com paginação), buscar por ID, atualizar e deletar produtos armazenados em SQLite.  
A estrutura segue boas práticas com camadas separadas para domínio, dados, serviço e apresentação (API).

---

##  Tecnologias Utilizadas

-  Linguagem: C# (.NET 6)  
-  ORM: Entity Framework Core com SQLite  
-  Documentação via Swagger (Swashbuckle)  
-  Controle de versão: Git + GitHub  

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
### Paginação

Para obter os produtos com paginação, utilize os parâmetros `pagina` e `quantidade` na URL:

**Exemplo:**
- `pagina`: número da página que deseja consultar (padrão = 1)
- `quantidade`: quantidade de registros por página (padrão = 10)
---
## Configuração da String de Conexão

No arquivo `ProdutoAPI.Presentation/appsettings.json`, localize o campo `"ConexaoPadrao"` e defina o caminho absoluto do seu arquivo `.db`. Exemplo:

```json
"ConnectionStrings": {
  "ConexaoPadrao": "Data Source=C:\\CAMINHO\\PARA\\ProdutoAPI\\BancoDeDados.db"
}
```
## Visualizar o Banco de Dados (Opcional)

Você pode abrir o arquivo `BancoDeDados.db` com o [DB Browser for SQLite](https://sqlitebrowser.org/dl/) para visualizar os dados diretamente.

Basta abrir o programa e clicar em **"Open Database"**, navegando até o local do arquivo `.db`.

## 🛠️ Como Executar o Projeto

```bash
# Clone o repositório
git clone https://github.com/m4thi4ss/ProdutoAPI.git
cd ProdutoAPI

## Restaurar pacotes
dotnet restore

## Na pasta do projeto ProdutoAPI.Data, crie e aplique a migração
cd ProdutoAPI.Data
dotnet ef migrations add InicialCriacaoTabelas
dotnet ef database update
