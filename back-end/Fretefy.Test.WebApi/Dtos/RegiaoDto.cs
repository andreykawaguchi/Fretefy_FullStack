using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.Dtos
{
    public class RegiaoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<CidadeDto> Cidades { get; set; }
    }
}
