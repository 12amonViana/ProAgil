using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Repository;

namespace ProAgil.WebAPI.Controllers
{
    public class PalestrantesController : ControllerBase
    {
        private readonly IProAgilRepository _repo;
        public PalestrantesController(IProAgilRepository repo)
        {
            this._repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int palestranteId, bool includeEventos)
        {
            try
            {
                var results = await _repo.GetPalestranteAsync(palestranteId, includeEventos);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de Dados Falhou");
            }
            
        }

    }
}