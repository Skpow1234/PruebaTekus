﻿
namespace PruebaTekus.Application.Dtos
{
    public class ProviderDto
    {
        public int Id { get; set; }
        public string Nit { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public List<ProviderCountryDto> Countries { get; set; }  

    }
}
