using System;
using System.Runtime.CompilerServices;

namespace MedWise.Core.Models;

public class CaregiverRelationship : BaseEntity
{
	[field: CompilerGenerated]
	public int CaregiverId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int PatientId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public global::System.DateTime LinkedDate
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = global::System.DateTime.UtcNow;


	[field: CompilerGenerated]
	public bool IsActive
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = true;


	[field: CompilerGenerated]
	public virtual User Caregiver
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public virtual User Patient
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
