using TaskManagementSystem.Data;
using TaskManagementSystem.DTO;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Services
{
    public class AuthService
    {
        private readonly TaskManagementDbContext _taskManagementDbContext;
        public AuthService(TaskManagementDbContext taskManagementDbContext)
        {
            _taskManagementDbContext = taskManagementDbContext;
        }

        public Task<ServiceResponse<LoginResponseDto>> Login(UserDto userDto)
        {
            var use = _taskManagementDbContext.Users.Find(userDto.Username);
            LoginResponseDto loginResponseDto = new LoginResponseDto();
            ServiceResponse serviceResponse = new ServiceResponse
            {
                Data = loginResponseDto,
            };
            return loginResponseDto;

        }
    }
}
