using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ScreenSound.Banco
{
    // uma classe para só fazer conexão com o banco com Entity Framework
    internal class ScreenSoundContext : DbContext
    {

        // Aqui informa que que queremos mapear a nossa tabela Artistas para a nossa classe Artistas
        public DbSet<Artista> Artistas
        {
            get; set;
        }
        public DbSet<Musica> Musicas
        {
            get; set;
        }

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Encrypt=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}