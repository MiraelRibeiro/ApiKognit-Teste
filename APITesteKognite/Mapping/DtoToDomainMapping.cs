using APITesteKognite.Models;
using APITesteKognite.Models.Dtos;
using AutoMapper;

namespace APITesteKognite.Mapping
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<UserDto, User>();
            CreateMap<WalletDto, Wallet>();
        }
    }
}
