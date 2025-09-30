using Microsoft.EntityFrameworkCore;
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

        /* Para todos os metodos abaixo que acessam o banco de dados tem que passar o context: using var context = new ScreenSoundContext();
        mas ao inves de ficar repetindo isso em todos os metodos, podemos criar um metodo privado que faz isso e chamar esse metodo nos outros
        */

        private readonly ScreenSoundContext context; // esse campo adiciona no construtor do artistaDAL

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }


        public IEnumerable<Artista> Listar()
        {
            // o nome da string de conexao tem que ser context pq é o nome da classe que faz a conexao com o banco
            //using var context = new ScreenSoundContext();
            return context.Artistas.ToList(); // só funciona pq mapeamos a tbl artistas na classe ScreenSoundContext
        }

        public void Adicionar(Artista artista)
        {
            //using var context = new ScreenSoundContext();
            context.Artistas.Add(artista);
            context.SaveChanges(); // altera alguma coisa do banco entao tem que salvar as mudancas
        }

        public void Atualizar(Artista artista)
        {
            context.Artistas.Update(artista);
            context.SaveChanges();
        }

        public void Deletar(Artista artista)
        {
            context.Artistas.Remove(artista);
            context.SaveChanges();
        }

        public Artista? RecuperarPeloNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
            // buscará o primeiro elemento que atenda a condição através do FirstOrDefault
        }


    }
}
