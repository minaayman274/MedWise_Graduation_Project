using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.Models;

namespace MedWise.Core.Interfaces;

public interface IChatHistoryRepository : IRepository<ChatHistory>
{
	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<ChatHistory>> GetByUserIdAsync(int userId, int pageSize = 50);
}
