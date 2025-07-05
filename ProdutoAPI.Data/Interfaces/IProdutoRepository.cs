using System.Collections.Generic;
using System.Threading.Tasks;
using ProdutoAPI.Domain.Entidades;

namespace ProdutoAPI.Data.Interfaces
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> ListarTodos(int pagina, int quantidade);
        Task<Produto> BuscarPorId(int id);
        Task<Produto> Cadastrar(Produto produto);
        Task Atualizar(Produto produto);
        Task Deletar(int id);
    }
}
