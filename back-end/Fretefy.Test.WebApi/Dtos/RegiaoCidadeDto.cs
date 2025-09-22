using System;

namespace Fretefy.Test.WebApi.Dtos
{
    public class RegiaoCidadeDto
    {
        public Guid Id { get; set; }
        public Guid RegiaoId { get; set; }
        public Guid CidadeId { get; set; }
        public string RegiaoNome { get; set; }
        public string CidadeNome { get; set; }
    }
}
