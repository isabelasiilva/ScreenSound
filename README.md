<h3>🎵 Projeto de Gerenciamento de Músicas</h3>
<I>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Fazendo a transição de ADO.NET para Entity Framework em um projeto</I>
<br>
<br>
<p>
    Esse exercício teve foco no aprendizado e prática de acesso a dados utilizando
    <strong>ADO.NET</strong>, <strong>Entity Framework Core</strong>, <strong>Migrations</strong> e
    padrões de arquitetura como a <strong>DAL (Data Access Layer)</strong>.
    A aplicação realiza operações em um banco SQL Server e evolui gradualmente do acesso direto com ADO.NET
    para uma abordagem baseada em ORM.
</p>
<br>
<h4>🚀 Tecnologias Utilizadas</h4>
<ul>
    <li>C# / .NET</li>
    <li>SQL Server</li>
    <li>ADO.NET</li>
    <li>Entity Framework Core</li>
    <li>Migrations</li>
</ul>
<br>
<h4>📌 Primeiros Passos</h4>
<ul>
    <li>Criar um banco de dados SQL Server utilizando o Pesquisador de Objetos do Visual Studio.</li>
    <li>Construir a primeira tabela do projeto diretamente no banco.</li>
</ul>
<br>
<h4>🔌 Acesso a Dados com ADO.NET</h4>
<ul>
    <li>Conectar a aplicação ao banco de dados utilizando ADO.NET.</li>
    <li>Criar e organizar uma Data Access Layer (DAL) para encapsular toda a lógica de acesso ao banco.</li>
    <li>Implementar e testar métodos para inserir, consultar, atualizar e excluir dados diretamente pela aplicação.</li>
    <li>Refatorar o código da DAL para torná-lo mais objetivo, limpo e reutilizável.</li>
</ul>
<br>
<h4>🟦 Evolução para Entity Framework</h4>
<ul>
    <li>Instalar e configurar o Entity Framework no projeto.</li>
    <li>Implementar um ORM para gerenciar entidades, consultas e persistência de dados.</li>
    <li>Ajustar o código da aplicação para utilizar o EF no lugar das operações manuais de ADO.NET.</li>
    <li>Refatorar menus e fluxos da aplicação para consumirem dados via ORM.</li>
</ul>
<br>
<h4>🛠️ Migrations e Controle de Versão do Banco</h4>
<ul>
    <li>Criar e configurar migrations para versionamento do banco de dados.</li>
    <li>Adicionar novas migrations para modificar a estrutura das tabelas (ex.: adicionar nova coluna).</li>
    <li>Inserir dados iniciais utilizando <code>migrationBuilder.InsertData</code>.</li>
    <li>Atualizar o banco utilizando <code>Update-Database</code>, garantindo sincronização com o código.</li>
</ul>
<br>
<h3>🔗 Relacionamentos e Recursos Avançados do EF</h3>
<ul>
    <li>Implementar relacionamento entre tabelas usando Fluent API ou Data Annotations.</li>
    <li>Utilizar o pacote <strong>EF Core Proxies</strong> para habilitar lazy loading.</li>
    <li>Refatorar novamente o menu da aplicação, agora utilizando dados relacionados (ex.: tabela de músicas).</li>
</ul>
