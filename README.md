# ProductClientHub 📦

ProductClientHub é uma aplicação desenvolvida em C# com o objetivo de gerenciar produtos e clientes.
Este projeto foi criado durante o **Minicurso de C# da [Rocketseat](https://www.rocketseat.com.br/)**, onde foram abordados conceitos essenciais de desenvolvimento com C#, Entity Framework Core e SQLite.

## Funcionalidades ✨

- **Cadastro de Clientes ✏️**: Permite adicionar, editar e remover informações de clientes.
- **Cadastro de Produtos 🛍️**: Possibilita o gerenciamento do catálogo de produtos.
- **Associação Produto-Cliente 🔗**: Relaciona produtos aos clientes, facilitando o controle de vendas ou interesses.

## Estrutura do Projeto 📂
- ProductClientHub.API: Contém os controladores e configurações da API.
- ProductClientHub.Communication: Gerencia a comunicação entre as camadas da aplicação.
- ProductClientHub.Exceptions: Define as exceções personalizadas utilizadas no projeto.

## Tecnologias Utilizadas 🛠️

- **Linguagem**: C#
- **Framework**: ASP.NET Core
- **Banco de Dados**: SQLite
- **ORM**: Entity Framework Core

## Pré-requisitos 📋

- [.NET SDK](https://dotnet.microsoft.com/download) versão 8.0 ou superior.

## Como Executar o Projeto 🏃‍♂️

1. **Clone o repositório**:

   ```
   git clone https://github.com/Yurif-s/ProductClientHub.git
   ```

2. **Navegue até o diretório do projeto**:
 
    ```
    cd ProductClientHub
    ```

3. **Restaure as dependências**:
    ```
    dotnet restore
    ```
    
4. **Atualize o banco de dados**:
    ```
    dotnet ef database update
    ```

4. **Execute a aplicação**:
    ```
    dotnet run
    ```
    
## Contribuição 🤝
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests. 💬

## Licença 📜
Este projeto está licenciado sob a Licença MIT.
