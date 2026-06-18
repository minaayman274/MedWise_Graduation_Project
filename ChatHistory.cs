using System;
using System.Runtime.CompilerServices;
using MedWise.Core.Enums;

namespace MedWise.Core.Models;

public class ChatHistory : BaseEntity
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
	public string UserMessage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string BotResponse
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public global::System.DateTime Timestamp
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = global::System.DateTime.UtcNow;


	[field: CompilerGenerated]
	public Language Language
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public virtual User User
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
