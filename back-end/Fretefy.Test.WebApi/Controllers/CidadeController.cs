using AutoMapper;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _cidadeService;
        private readonly IMapper _mapper;

        public CidadeController(ICidadeService cidadeService, IMapper mapper)
        {
            _cidadeService = cidadeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List([FromQuery] string uf, [FromQuery] string terms)
        {
            IEnumerable<Cidade> cidades;

            if (!string.IsNullOrEmpty(terms))
                cidades = _cidadeService.Query(terms);
            else if (!string.IsNullOrEmpty(uf))
                cidades = _cidadeService.ListByUf(uf);
            else
                cidades = _cidadeService.List();

            var result = cidades.Select(c => _mapper.Map<CidadeDto>(c));

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var cidade = _cidadeService.Get(id);
            if (cidade == null) return NotFound();

            var dto = _mapper.Map<CidadeDto>(cidade);

            return Ok(dto);
        }
    }
}
