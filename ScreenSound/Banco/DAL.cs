using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    // Criando um DAL genérico porque Artista e Musica possuem os mesmos comportamentos
    internal abstract class DAL<T>
    {
        private readonly ScreenSoundContext context; // esse campo adiciona no construtor do artistaDAL

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.<DAL>.ToList();
        }
        public abstract void Adicionar(T objeto);
        public abstract void Atualizar(T objeto);
        public abstract void Deletar(T objeto);

   
    }

}
