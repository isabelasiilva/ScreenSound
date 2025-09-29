using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScreenSound.Banco
{
    // DAL = Data Access Layer
    internal class ArtistaDAL
    {
        // criando um método para listar/manipular as informações do banco
        public IEnumerable<Artista> Listar()
        {
            var lista = new List<Artista>(); // cria a lista onde vai salvar as informações que vai retornar pra gente 

            // fazendo a conexão com o banco dentro do metodo listar - entao sempre que chamar o metodo listar ele vai fazer uma conexao com o banco
            using var connection = new Connection().ObterConexao();
            connection.Open();

            // passando a query que queremos executar
            string sql = " SELECT * FROM Artistas"; // comando sql que queremos executar

            SqlCommand command = new SqlCommand(sql, connection); // criando o comando passando a query e a conexao
            using SqlDataReader dataReader = command.ExecuteReader(); // executando o comando e retornando um SqlDataReader


            // fazendo a verificação do que vc quer ler do banco
            while (dataReader.Read())
            {
                string nomeArtista = Convert.ToString(dataReader["Nome"]);
                string bioArtista = Convert.ToString(dataReader["Bio"]);
                int idArtista = Convert.ToInt32(dataReader["Id"]);

                // criando o objeto artista com as informações que pegamos do banco
                Artista artista = new Artista(nomeArtista, bioArtista) { Id = idArtista };

                lista.Add(artista); // adicionando o artista na lista
            }
            return lista; // retornando a lista com os artistas

        }



        // criando um metodo para adicionar artistas
        public void Adicionar(Artista artista)
        {
            // precisa tambem da conexao com o banco
            using var connection = new Connection().ObterConexao();
            connection.Open();

            // passando a query que queremos executar
            string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@nome, @perfilPadrao, @bio)";
            SqlCommand command = new SqlCommand(sql, connection);


            // informando qual será o parâmetro referente a cada uma das colunas. Com isso, há conseguimos mapear qual informação vai para cada uma das colunas da tabela
            command.Parameters.AddWithValue("@nome", artista.Nome);
            command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
            command.Parameters.AddWithValue("@bio", artista.Bio);

            // O método Adicionar() vai trazer um retorno da quantidade de linhas afetadas, de acordo com a quantidade de itens adicionados na tabela
            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {retorno}");
        }


        // Criando um metodo para atualizar artistas
        public void Atualizar(Artista artista)
        {
            // conexao com o banco
            using var connection = new Connection().ObterConexao();
            connection.Open();

            // passando a query que queremos executar
            string sql = "UPDATE Artistas SET Nome = @nome, Bio = @bio WHERE Id = @id;";
            SqlCommand command = new SqlCommand(sql, connection);


            command.Parameters.AddWithValue("@id", artista.Id);
            command.Parameters.AddWithValue("@nome", artista.Nome);
            command.Parameters.AddWithValue("@bio", artista.Bio);

            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {retorno}");
        }


        // Criando um metodo para deletar artistas
        public void Deletar(Artista artista)
        {
            // conexao com o banco
            using var connection = new Connection().ObterConexao();
            connection.Open();

            // passando a query que queremos executar
            string sql = "DELETE FROM Artistas WHERE Id = @id";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@id", artista.Id);

            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {retorno}");
        }


    }
}
