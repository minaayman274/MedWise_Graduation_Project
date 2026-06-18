using System;
using System.Runtime.CompilerServices;
using MedWise.Core.Enums;

namespace MedWise.Core.Models;

public class ReminderLog : BaseEntity
{
	[field: CompilerGenerated]
	public int ReminderId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public global::System.DateTime TriggeredAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public ReminderStatus Status
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
	public virtual Reminder Reminder
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
