🎵 Projeto de Gerenciamento de Músicas para implementar uma transição de ADO.NET + Entity Framework

Este projeto foi desenvolvido com foco no aprendizado e prática de acesso a dados utilizando ADO.NET, Entity Framework, Migrations e padrões de arquitetura como DAL (Data Access Layer).
A aplicação realiza operações em um banco SQL Server e evolui gradualmente do acesso direto com ADO.NET para uma abordagem baseada em ORM.


🚀 Tecnologias Utilizadas
- C# / .NET
- SQL Server
- ADO.NET
- Entity Framework Core
- Migrations


📌 Primeiros passos
- Criar um banco de dados SQL Server utilizando o Pesquisador de Objetos do Visual Studio.
- Construir a primeira tabela do projeto diretamente no banco.


🔌 Acesso a Dados com ADO.NET
- Conectar a aplicação ao banco de dados utilizando ADO.NET.
- Criar e organizar uma Data Access Layer (DAL) para encapsular toda a lógica de acesso ao banco.
- Implementar e testar métodos para inserir, consultar, atualizar e excluir dados diretamente pela aplicação.
- Refatorar o código da DAL, deixando-o mais objetivo e reutilizável.


🟦 Evolução para Entity Framework
- Instalar e configurar o Entity Framework no projeto.
- Implementar um ORM para gerenciar entidades, consultas e persistência de dados.
- Ajustar o código da aplicação para utilizar o EF no lugar das operações manuais de ADO.NET.
- Refatorar os menus e fluxos da aplicação para consumirem corretamente os dados via ORM.


🛠️ Migrations e Controle de Versão do Banco
- Criar e configurar migrations para versionamento do banco de dados.
- Adicionar novas migrations para alterar a estrutura das tabelas (ex.: adicionar nova coluna).
- Inserir dados iniciais utilizando migrationBuilder.InsertData.
- Atualizar o banco com Update-Database, garantindo sincronização entre código e banco.

🔗 Relacionamentos e Recursos Avançados do EF
- Implementar relacionamento entre tabelas usando Fluent API ou Data Annotations.
- Utilizar o pacote EF Core Proxies para habilitar lazy loading.
- Refatorar novamente o menu da aplicação, agora utilizando os dados relacionados (ex.: tabela de músicas).
