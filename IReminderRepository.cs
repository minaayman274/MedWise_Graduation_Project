using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.Enums;
using MedWise.Core.Models;

namespace MedWise.Core.Interfaces;

public interface IReminderRepository : IRepository<Reminder>
{
	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Reminder>> GetByUserIdAsync(int userId);

	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Reminder>> GetTodayRemindersAsync(int userId);

	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Reminder>> GetActiveRemindersAsync();

	global::System.Threading.Tasks.Task UpdateStatusAsync(int reminderId, ReminderStatus status);
}
