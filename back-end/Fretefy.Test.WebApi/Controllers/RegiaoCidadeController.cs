using AutoMapper;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Exceptions;
using Fretefy.Test.WebApi.Dtos;
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
        private readonly IMapper _mapper;

        public RegiaoCidadeController(IRegiaoCidadeRepository regiaoCidadeRepository, IMapper mapper)
        {
            _regiaoCidadeRepository = regiaoCidadeRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var relacionamentos = _regiaoCidadeRepository.List()
                .ToList()
                .Select(rc => _mapper.Map<RegiaoCidadeDto>(rc));
            return Ok(relacionamentos);
        }

        [HttpGet("regiao/{regiaoId}")]
        public IActionResult GetByRegiao(Guid regiaoId)
        {
            var relacionamentos = _regiaoCidadeRepository.GetByRegiaoId(regiaoId)
                .Select(rc => _mapper.Map<RegiaoCidadeDto>(rc));
            return Ok(relacionamentos);
        }

        [HttpGet("cidade/{cidadeId}")]
        public IActionResult GetByCidade(Guid cidadeId)
        {
            var relacionamentos = _regiaoCidadeRepository.GetByCidadeId(cidadeId)
                .Select(rc => _mapper.Map<RegiaoCidadeDto>(rc));
            return Ok(relacionamentos);
        }
    }
}