using System.Collections.Generic;
using System.Threading.Tasks;
using ProdutoAPI.Domain.Entidades;
using ProdutoAPI.Service.Interfaces;
using ProdutoAPI.Data.Interfaces;

namespace ProdutoAPI.Service.Servicos
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repositories;

        public ProdutoService(IProdutoRepository repositories)
        {
            _repositories = repositories;
        }

        public async Task<List<Produto>> ListarTodos(int pagina, int quantidade)
        {
            return await _repositories.ListarTodos(pagina, quantidade);
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            return await _repositories.BuscarPorId(id);
        }

        public async Task<Produto> Cadastrar(Produto produto)
        {
            return await _repositories.Cadastrar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            await _repositories.Atualizar(produto);
        }

        public async Task Deletar(int id)
        {
            await _repositories.Deletar(id);
        }
    }
}