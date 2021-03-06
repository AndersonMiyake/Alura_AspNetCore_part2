using CasaDoCodigo.Models;
using System.Collections.Generic;

namespace CasaDoCodigo.Aula1.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}