using MagicVilla_VillaApi.Models.DTO;
using MagicVilla_VillaApi.Models;

namespace MagicVilla_VillaApi.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LogInRequestDTO loginRequestDTO);
        Task<LocalUser> Register(RegistrationRequestDTO registerationRequestDTO);
    }
}
