using APITesteKognite.Models;
using APITesteKognite.Models.Dtos;
using AutoMapper;

namespace APITesteKognite.Mapping
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<User, UserDto>();
            CreateMap<Wallet, WalletDto>();
        }
    }
}
