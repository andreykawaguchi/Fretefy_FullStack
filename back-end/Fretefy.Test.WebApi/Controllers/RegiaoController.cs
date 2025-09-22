using AutoMapper;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Exceptions;
using Fretefy.Test.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ClosedXML.Excel;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;
        private readonly IMapper _mapper;

        public RegiaoController(IRegiaoService regiaoService, IMapper mapper)
        {
            _regiaoService = regiaoService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var regioes = _regiaoService.List()
                .Select(r => _mapper.Map<RegiaoDto>(r));

            return Ok(regioes);
        }

        [HttpGet("paged")]
        public IActionResult ListPaged([FromQuery] int page = 1, [FromQuery] int pageSize = 10, [FromQuery] string sortBy = "nome", [FromQuery] string sortDirection = "asc")
        {
            var all = _regiaoService.List().ToList();
            var total = all.Count;
            var totalPages = (int)Math.Ceiling((double)total / pageSize);

            IEnumerable<Regiao> ordered;
            var dirDesc = string.Equals(sortDirection, "desc", StringComparison.OrdinalIgnoreCase);
            switch ((sortBy ?? "").ToLowerInvariant())
            {
                case "nome":
                    ordered = dirDesc ? all.OrderByDescending(r => r.Nome) : all.OrderBy(r => r.Nome);
                    break;
                case "cidade":
                    // Order by the first cidade's Nome (if any), fallback to empty string
                    if (dirDesc)
                    {
                        ordered = all.OrderByDescending(r => (_regiaoService.GetCidadesPorRegiao(r.Id)?.FirstOrDefault()?.Nome) ?? string.Empty);
                    }
                    else
                    {
                        ordered = all.OrderBy(r => (_regiaoService.GetCidadesPorRegiao(r.Id)?.FirstOrDefault()?.Nome) ?? string.Empty);
                    }
                    break;
                default:
                    ordered = dirDesc ? all.OrderByDescending(r => r.Nome) : all.OrderBy(r => r.Nome);
                    break;
            }

            var items = ordered.Skip((page - 1) * pageSize).Take(pageSize)
                .Select(r => _mapper.Map<RegiaoDto>(r));

            var result = new
            {
                items,
                pagination = new
                {
                    total,
                    page,
                    pageSize,
                    totalPages,
                    sortBy,
                    sortDirection = dirDesc ? "desc" : "asc"
                }
            };

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var regiao = _regiaoService.Get(id);
            if (regiao == null) return NotFound();

            var dto = _mapper.Map<RegiaoDto>(regiao);

            return Ok(dto);
        }

        [HttpGet("{id}/cidades")]
        public IActionResult GetCidades(Guid id)
        {
            try
            {
                var cidades = _regiaoService.GetCidadesPorRegiao(id);
                var result = _mapper.Map<IEnumerable<CidadeDto>>(cidades);
                return Ok(result);
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("export")]
        public IActionResult ExportExcel()
        {
            var regioes = _regiaoService.List().ToList();

            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Regioes");

                // Headers
                ws.Cell(1, 1).Value = "Regiao";
                ws.Cell(1, 2).Value = "Cidade 1";
                ws.Cell(1, 3).Value = "CIdade 2";

                var row = 2;
                foreach (var regiao in regioes)
                {
                    var cidades = _regiaoService.GetCidadesPorRegiao(regiao.Id)?.ToList() ?? new List<Cidade>();

                    ws.Cell(row, 1).Value = regiao.Nome;
                    ws.Cell(row, 2).Value = cidades.Count > 0 ? cidades[0].Nome : string.Empty;
                    ws.Cell(row, 3).Value = cidades.Count > 1 ? cidades[1].Nome : string.Empty;

                    row++;
                }

                using (var ms = new MemoryStream())
                {
                    workbook.SaveAs(ms);
                    ms.Seek(0, SeekOrigin.Begin);
                    var content = ms.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "regioes.xlsx");
                }
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateRegiaoDto regiaoDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var regiao = _mapper.Map<Regiao>(regiaoDto);

                var created = _regiaoService.Add(regiao);
                var dto = _mapper.Map<RegiaoDto>(created);
                return CreatedAtAction(nameof(Get), new { id = created.Id }, dto);
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
        public IActionResult Put(Guid id, [FromBody] UpdateRegiaoDto regiaoDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                if (id != regiaoDto.Id) return BadRequest(new { message = "O ID da URL deve corresponder ao ID do objeto." });

                var regiao = _mapper.Map<Regiao>(regiaoDto);

                var updated = _regiaoService.Update(regiao);
                if (updated == null)
                {
                    return NotFound(new { message = "Região não encontrada." });
                }

                var dto = _mapper.Map<RegiaoDto>(updated);
                return Ok(dto);
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException ex)
            {
                return Conflict(new { message = "A região foi modificada por outro usuário. Tente novamente.", details = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Erro interno do servidor.", details = ex.Message, stackTrace = ex.StackTrace });
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

        [HttpPost("{id}/ativar")]
        public IActionResult Ativar(Guid id)
        {
            try
            {
                _regiaoService.Ativar(id);
                return Ok(new { message = "Região ativada com sucesso." });
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("{id}/desativar")]
        public IActionResult Desativar(Guid id)
        {
            try
            {
                _regiaoService.Desativar(id);
                return Ok(new { message = "Região desativada com sucesso." });
            }
            catch (DomainException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
