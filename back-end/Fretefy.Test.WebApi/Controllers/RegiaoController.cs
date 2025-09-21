using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult List()
        {
            IEnumerable<Regiao> regioes = _regiaoService.List();
            return Ok(regioes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var regiao = _regiaoService.Get(id);
            if (regiao == null) return NotFound();
            return Ok(regiao);
        }

        [HttpGet("{id}/cidades")]
        public IActionResult GetCidades(Guid id)
        {
            try
            {
                var cidades = _regiaoService.GetCidadesPorRegiao(id);
                return Ok(cidades);
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Regiao regiao)
        {
            try
            {
                var created = _regiaoService.Add(regiao);
                return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("{regiaoId}/cidades/{cidadeId}")]
        public IActionResult AdicionarCidade(Guid regiaoId, Guid cidadeId)
        {
            try
            {
                _regiaoService.AdicionarCidadeNaRegiao(regiaoId, cidadeId);
                return Ok(new { message = "Cidade adicionada à região com sucesso." });
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Regiao regiao)
        {
            try
            {
                if (id != regiao.Id) return BadRequest();
                var updated = _regiaoService.Update(regiao);
                return Ok(updated);
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _regiaoService.Delete(id);
            return NoContent();
        }

        [HttpDelete("{regiaoId}/cidades/{cidadeId}")]
        public IActionResult RemoverCidade(Guid regiaoId, Guid cidadeId)
        {
            try
            {
                _regiaoService.RemoverCidadeDaRegiao(regiaoId, cidadeId);
                return Ok(new { message = "Cidade removida da região com sucesso." });
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
