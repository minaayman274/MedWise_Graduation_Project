using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.DTOs;

namespace MedWise.Core.Interfaces;

public interface IReminderService
{
	global::System.Threading.Tasks.Task<ApiResponse<global::System.Collections.Generic.IEnumerable<ReminderDto>>> GetTodayRemindersAsync(int userId);

	global::System.Threading.Tasks.Task<ApiResponse<bool>> MarkReminderTakenAsync(int reminderId, int userId);

	global::System.Threading.Tasks.Task<ApiResponse<bool>> MarkReminderMissedAsync(int reminderId, int userId);
}
