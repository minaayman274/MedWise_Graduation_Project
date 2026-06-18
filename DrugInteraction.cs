using System.Runtime.CompilerServices;
using MedWise.Core.Enums;

namespace MedWise.Core.Models;

public class DrugInteraction : BaseEntity
{
	[field: CompilerGenerated]
	public int Medication1Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int Medication2Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public InteractionSeverity Severity
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string Description
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string Recommendation
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public virtual Medication Medication1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public virtual Medication Medication2
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
