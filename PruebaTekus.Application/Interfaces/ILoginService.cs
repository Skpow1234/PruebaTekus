
using PruebaTekus.Application.Dtos;

namespace PruebaTekus.Application.Interfaces
{
    public interface ILoginService
    {
        Task<string> Login(UserDto userDto);
    }
}
