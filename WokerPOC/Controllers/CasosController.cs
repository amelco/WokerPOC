using Microsoft.AspNetCore.Mvc;
using WokerPOC.Entities;
using WokerPOC.Repositories;

namespace WokerPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CasosController
    {
        private readonly CasosRepository _repository;

        public CasosController(CasosRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Caso> Listar()
        {
            return _repository.Listar();
        }

        [HttpPost]
        public void Adicionar()
        {
            _repository.Adicionar();
        }
    }
}
