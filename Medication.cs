using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MedWise.Core.Enums;

namespace MedWise.Core.Models;

public class Medication : BaseEntity
{
	[field: CompilerGenerated]
	public int UserId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string Name
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string ActiveIngredient
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public TimeSpan DosageTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public ReminderFrequency Frequency
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
	public bool IsActive
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = true;


	[field: CompilerGenerated]
	public global::System.DateTime AddedDate
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = global::System.DateTime.UtcNow;


	[field: CompilerGenerated]
	public virtual User User
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<Reminder> Reminders
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<Reminder>)new List<Reminder>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<DrugInteraction> DrugInteractionsAsMed1
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<DrugInteraction>)new List<DrugInteraction>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<DrugInteraction> DrugInteractionsAsMed2
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<DrugInteraction>)new List<DrugInteraction>();

}
