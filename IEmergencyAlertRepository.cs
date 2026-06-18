using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.Models;

namespace MedWise.Core.Interfaces;

public interface IEmergencyAlertRepository : IRepository<EmergencyAlert>
{
	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<EmergencyAlert>> GetByPatientIdAsync(int patientId);

	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<EmergencyAlert>> GetPendingAlertsAsync(int caregiverId);
}
