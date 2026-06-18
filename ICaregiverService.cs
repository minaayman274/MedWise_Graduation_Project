using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.DTOs;

namespace MedWise.Core.Interfaces;

public interface ICaregiverService
{
	global::System.Threading.Tasks.Task<ApiResponse<CaregiverDashboardDto>> GetDashboardAsync(int caregiverId, int patientId);

	global::System.Threading.Tasks.Task<ApiResponse<bool>> LinkPatientAsync(int caregiverId, string patientEmail);

	global::System.Threading.Tasks.Task<ApiResponse<global::System.Collections.Generic.IEnumerable<UserDto>>> GetLinkedPatientsAsync(int caregiverId);
}
