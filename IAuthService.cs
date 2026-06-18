using System.Threading.Tasks;
using MedWise.Core.DTOs;
using MedWise.Core.Models;

namespace MedWise.Core.Interfaces;

public interface IAuthService
{
	global::System.Threading.Tasks.Task<ApiResponse<AuthResponseDto>> RegisterAsync(RegisterDto dto);

	global::System.Threading.Tasks.Task<ApiResponse<AuthResponseDto>> LoginAsync(LoginDto dto);

	global::System.Threading.Tasks.Task<string> GenerateJwtTokenAsync(User user);
}
