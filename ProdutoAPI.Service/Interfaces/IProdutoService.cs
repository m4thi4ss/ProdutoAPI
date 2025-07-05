using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdutoAPI.Domain.Entidades;

namespace ProdutoAPI.Service.Interfaces
{
    public interface IProdutoService
    {
        Task<List<Produto>> ListarTodos(int pagina, int quantidade);
        Task<Produto> BuscarPorId(int id);
        Task<Produto> Cadastrar(Produto produto);
        Task Atualizar(Produto produto);
        Task Deletar(int id);
    }
}
