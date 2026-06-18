using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MedWise.Core.Enums;

namespace MedWise.Core.Models;

public class User : BaseEntity
{
	[field: CompilerGenerated]
	public string Username
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string Email
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string PasswordHash
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string PhoneNumber
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string FullName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string? ProfilePicture
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public UserRole Role
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public Language PreferredLanguage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int? Age
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string? MedicalCondition
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<Medication> Medications
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<Medication>)new List<Medication>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<EmergencyAlert> EmergencyAlerts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<EmergencyAlert>)new List<EmergencyAlert>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<ChatHistory> ChatHistories
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<ChatHistory>)new List<ChatHistory>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<Reminder> Reminders
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<Reminder>)new List<Reminder>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<CaregiverRelationship> CaregiverRelationships
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<CaregiverRelationship>)new List<CaregiverRelationship>();


	[field: CompilerGenerated]
	public virtual global::System.Collections.Generic.ICollection<CaregiverRelationship> PatientRelationships
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = (global::System.Collections.Generic.ICollection<CaregiverRelationship>)new List<CaregiverRelationship>();

}
