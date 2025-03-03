# API de Cadastro de Livros

## Descrição do Projeto
Esta é uma API para cadastro de livros, permitindo a gestão de livros e autores. O projeto segue os conceitos de CRUD (Create, Read, Update e Delete) e foi desenvolvido utilizando C# com o framework .NET.

## Tecnologias Utilizadas
- **C#**
- **.NET**
- **Entity Framework** (Code-First Approach)
- **SQL Server** (Banco de dados relacional)
- **Swagger** (Documentação da API)
- **MVC** (Arquitetura)
- **Logs** (Para monitoramento e depuração)
- **DTO (Data Transfer Object)** (Para manipulação de dados das entidades Livro e Autor)

## Funcionalidades
- Consulta de livros por ID
- Listagem de todos os livros
- Adição de novos livros
- Edição de informações dos livros
- Exclusão de livros
- Consulta de autores por ID
- Listagem de todos os autores
- Adição de novos autores
- Edição de informações dos autores
- Exclusão de autores

## Como Executar o Projeto
1. Clone o repositório:
   ```sh
   git clone https://github.com/wallaceg7/WebApi-CRUD-livros.git
   ```
2. Acesse o diretório do projeto:
   ```sh
   cd nome-do-repositorio
   ```
3. Configure a string de conexão com o SQL Server no arquivo **appsettings.json**.
4. Execute as migrações do banco de dados:
   ```sh
   dotnet ef database update
   ```
5. Inicie a aplicação:
   ```sh
   dotnet run
   ```
6. Acesse a documentação Swagger:
   - `http://localhost:5000/swagger`

## Estrutura do Projeto
```
/api-cadastro-livros
│── Controllers
│   ├── LivroController.cs
│   ├── AutorController.cs
│
│── Models
│   ├── Livro.cs
│   ├── Autor.cs
│
│── DTOs
│   ├── LivroDTO.cs
│   ├── AutorDTO.cs
│
│── Data
│   ├── ApplicationDbContext.cs
│
│── Services
│   ├── LivroService.cs
│   ├── AutorService.cs
│
│── Logs
│── appsettings.json
│── Program.cs
│── Startup.cs
```

## Contribuição
Contribuições são bem-vindas! Para isso:
1. Faça um fork do projeto.
2. Crie uma branch para sua funcionalidade: `git checkout -b minha-feature`
3. Faça commit das suas alterações: `git commit -m 'Adiciona nova funcionalidade'`
4. Envie para o repositório remoto: `git push origin minha-feature`
5. Abra um Pull Request.

## Licença
Este projeto está licenciado sob a MIT License - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

