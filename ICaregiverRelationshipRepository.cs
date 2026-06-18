using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.Models;

namespace MedWise.Core.Interfaces;

public interface ICaregiverRelationshipRepository : IRepository<CaregiverRelationship>
{
	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<CaregiverRelationship>> GetByCaregiversIdAsync(int caregiverId);

	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<CaregiverRelationship>> GetByPatientIdAsync(int patientId);

	global::System.Threading.Tasks.Task<bool> RelationshipExistsAsync(int caregiverId, int patientId);
}
