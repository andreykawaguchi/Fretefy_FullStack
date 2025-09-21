using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao-cidade")]
    [ApiController]
    public class RegiaoCidadeController : ControllerBase
    {
        private readonly IRegiaoCidadeRepository _regiaoCidadeRepository;

        public RegiaoCidadeController(IRegiaoCidadeRepository regiaoCidadeRepository)
        {
            _regiaoCidadeRepository = regiaoCidadeRepository;
        }

        [HttpGet]
        public IActionResult List()
        {
            var relacionamentos = _regiaoCidadeRepository.List()
                .ToList()
                .Select(rc => new
                {
                    Id = rc.Id,
                    RegiaoId = rc.RegiaoId,
                    CidadeId = rc.CidadeId,
                    RegiaoNome = rc.Regiao?.Nome,
                    CidadeNome = rc.Cidade?.Nome
                });
            return Ok(relacionamentos);
        }

        [HttpGet("regiao/{regiaoId}")]
        public IActionResult GetByRegiao(Guid regiaoId)
        {
            var relacionamentos = _regiaoCidadeRepository.GetByRegiaoId(regiaoId);
            return Ok(relacionamentos);
        }

        [HttpGet("cidade/{cidadeId}")]
        public IActionResult GetByCidade(Guid cidadeId)
        {
            var relacionamentos = _regiaoCidadeRepository.GetByCidadeId(cidadeId);
            return Ok(relacionamentos);
        }
    }
}