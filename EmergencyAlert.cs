using System;
using System.Runtime.CompilerServices;
using MedWise.Core.Enums;

namespace MedWise.Core.Models;

public class EmergencyAlert : BaseEntity
{
	[field: CompilerGenerated]
	public int PatientId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public global::System.DateTime AlertTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = global::System.DateTime.UtcNow;


	[field: CompilerGenerated]
	public string? Location
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public AlertStatus Status
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string? Notes
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
