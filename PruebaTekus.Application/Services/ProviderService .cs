﻿using AutoMapper;
using PruebaTekus.Application.Dtos;
using PruebaTekus.Application.Interfaces;
using PruebaTekus.Domain.Interfaces;


namespace PruebaTekus.Application.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        private readonly IMapper _mapper;


        public ProviderService(IProviderRepository providerRepository, IMapper mapper)
        {
            _providerRepository = providerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProviderDto>> ListAsyncProviders()
        {
            var provider = await _providerRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProviderDto>>(provider);
        }

        public async Task<ProviderDto> GetProviderByIdAsync(int id)
        {
            var provider = await _providerRepository.GetByIdAsync(id);
            return _mapper.Map<ProviderDto>(provider);
        }
        public async Task<IDictionary<string, int>> GetProviderCountByCountryAsync()
        {
            return await _providerRepository.GetProviderCountByCountryAsync();
        }
    }
}
