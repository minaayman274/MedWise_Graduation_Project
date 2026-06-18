using System;
using System.Runtime.CompilerServices;

namespace MedWise.Core.Models;

public abstract class BaseEntity
{
	[field: CompilerGenerated]
	public int Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public global::System.DateTime CreatedAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = global::System.DateTime.UtcNow;


	[field: CompilerGenerated]
	public global::System.DateTime? UpdatedAt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool IsDeleted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
