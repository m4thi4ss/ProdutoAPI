using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Data.Context;
using ProdutoAPI.Data.Interfaces;
using ProdutoAPI.Domain.Entidades;

namespace ProdutoAPI.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly BancoDeDadosContext _context;

        public ProdutoRepository(BancoDeDadosContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> ListarTodos(int pagina, int quantidade)
        {
            return await _context.Produtos
                .Skip((pagina - 1) * quantidade)
                .Take(quantidade)
                .ToListAsync();
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task<Produto> Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
