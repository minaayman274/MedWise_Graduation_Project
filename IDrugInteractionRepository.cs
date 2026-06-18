using System.Collections.Generic;
using System.Threading.Tasks;
using MedWise.Core.Models;

namespace MedWise.Core.Interfaces;

public interface IDrugInteractionRepository : IRepository<DrugInteraction>
{
	global::System.Threading.Tasks.Task<DrugInteraction?> CheckInteractionAsync(int med1Id, int med2Id);

	global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<IngredientInteraction>> CheckIngredientInteractionAsync(string ingredient1, string ingredient2);
}
