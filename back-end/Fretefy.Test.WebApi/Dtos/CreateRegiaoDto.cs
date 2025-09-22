using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fretefy.Test.WebApi.Dtos
{
    public class CreateRegiaoDto
    {
        [Required]
        public string Nome { get; set; }
        public IEnumerable<RegiaoCidadeInputDto> RegiaoCidades { get; set; }
    }
}
