using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco
{
    // Criando um DAL genérico porque Artista e Musica possuem os mesmos comportamentos
    internal class DAL<T> where T : class 
    {
        protected readonly ScreenSoundContext context; // esse campo adiciona no construtor do artistaDAL

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> Listar()
        {
            return context.Set<T>().ToList(); // Set<> é um método que ajuda a fazer a identificação de qual tipo ta sendo utilizado para um generics. Por conta desse T que precisa definir na declaração da classe DAL que o tipo de T é classe:  "where T : class "
        }
        public void Adicionar(T objeto) // adicionou {} nao pe mais um metodo abstrato
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }
        public void Atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }
        public void Deletar(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();
        }

        public T? RecuperarPor(Func<T, bool> condicao) //Func vai encapsular um método que geralmente tem um parâmetro e retorna um valor do tipo especificado pelo parâmetro
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }


    }

}
