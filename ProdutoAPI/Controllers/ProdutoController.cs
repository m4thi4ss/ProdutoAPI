using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Domain.Entidades;
using ProdutoAPI.Service.Interfaces;

namespace ProdutoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodos(int pagina = 1, int quantidade = 10)
        {
            var produtos = await _produtoService.ListarTodos(pagina, quantidade);
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var produto = await _produtoService.BuscarPorId(id);
            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var produtoCadastrado = await _produtoService.Cadastrar(produto);
            return CreatedAtAction(nameof(BuscarPorId), new { id = produtoCadastrado.Id }, produtoCadastrado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id)
                return BadRequest("ID do produto incompatível.");

            await _produtoService.Atualizar(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            await _produtoService.Deletar(id);
            return NoContent();
        }
    }
}
