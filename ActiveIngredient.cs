using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MedWise.Core.Models;

public class ActiveIngredient : BaseEntity
{
	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string NameArabic
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string? Description
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<IngredientInteraction> Interactions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<IngredientInteraction>)new List<IngredientInteraction>();

}
