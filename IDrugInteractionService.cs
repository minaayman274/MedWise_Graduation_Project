using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.DTOs;

namespace MedWise.Core.Interfaces;

public interface IDrugInteractionService
{
	global::System.Threading.Tasks.Task<ApiResponse<InteractionResultDto>> CheckInteractionAsync(CheckInteractionDto dto);

	global::System.Threading.Tasks.Task<ApiResponse<global::System.Collections.Generic.IEnumerable<InteractionResultDto>>> CheckAllUserMedicationsAsync(int userId);
}
