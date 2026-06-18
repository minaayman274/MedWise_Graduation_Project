using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using MedWise.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedWise.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
	[field: CompilerGenerated]
	public DbSet<User> Users
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Medication> Medications
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Reminder> Reminders
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ReminderLog> ReminderLogs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<DrugInteraction> DrugInteractions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ActiveIngredient> ActiveIngredients
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<IngredientInteraction> IngredientInteractions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<EmergencyAlert> EmergencyAlerts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<CaregiverRelationship> CaregiverRelationships
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ChatHistory> ChatHistories
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base((DbContextOptions)(object)options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		((DbContext)this).OnModelCreating(modelBuilder);
		modelBuilder.Entity<User>((Action<EntityTypeBuilder<User>>)delegate(EntityTypeBuilder<User> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Expected O, but got Unknown
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Expected O, but got Unknown
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected O, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			ParameterExpression val8 = Expression.Parameter(typeof(User), "u");
			entity.HasKey(Expression.Lambda<Func<User, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 }));
			val8 = Expression.Parameter(typeof(User), "u");
			entity.HasIndex(Expression.Lambda<Func<User, object>>((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 })).IsUnique(true);
			val8 = Expression.Parameter(typeof(User), "u");
			entity.HasIndex(Expression.Lambda<Func<User, object>>((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 })).IsUnique(true);
			val8 = Expression.Parameter(typeof(User), "u");
			entity.Property<string>(Expression.Lambda<Func<User, string>>((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 })).IsRequired(true).HasMaxLength(256);
			val8 = Expression.Parameter(typeof(User), "u");
			entity.Property<string>(Expression.Lambda<Func<User, string>>((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 })).IsRequired(true).HasMaxLength(50);
			val8 = Expression.Parameter(typeof(User), "u");
			entity.Property<string>(Expression.Lambda<Func<User, string>>((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 })).IsRequired(true).HasMaxLength(100);
			val8 = Expression.Parameter(typeof(User), "u");
			entity.Property<string>(Expression.Lambda<Func<User, string>>((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val8 })).IsRequired(true);
			val8 = Expression.Parameter(typeof(User), "u");
			entity.HasQueryFilter(Expression.Lambda<Func<User, bool>>((Expression)(object)Expression.Not((Expression)(object)Expression.Property((Expression)(object)val8, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val8 }));
		});
		modelBuilder.Entity<Medication>((Action<EntityTypeBuilder<Medication>>)delegate(EntityTypeBuilder<Medication> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected O, but got Unknown
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected O, but got Unknown
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Expected O, but got Unknown
			ParameterExpression val7 = Expression.Parameter(typeof(Medication), "m");
			entity.HasKey(Expression.Lambda<Func<Medication, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val7 }));
			val7 = Expression.Parameter(typeof(Medication), "m");
			entity.Property<string>(Expression.Lambda<Func<Medication, string>>((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val7 })).IsRequired(true).HasMaxLength(200);
			val7 = Expression.Parameter(typeof(Medication), "m");
			entity.Property<string>(Expression.Lambda<Func<Medication, string>>((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val7 })).IsRequired(true).HasMaxLength(200);
			val7 = Expression.Parameter(typeof(Medication), "m");
			ReferenceNavigationBuilder<Medication, User> obj20 = entity.HasOne<User>(Expression.Lambda<Func<Medication, User>>((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val7 }));
			val7 = Expression.Parameter(typeof(User), "u");
			ReferenceCollectionBuilder<User, Medication> obj21 = obj20.WithMany(Expression.Lambda<Func<User, global::System.Collections.Generic.IEnumerable<Medication>>>((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val7 }));
			val7 = Expression.Parameter(typeof(Medication), "m");
			obj21.HasForeignKey(Expression.Lambda<Func<Medication, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val7 })).OnDelete((DeleteBehavior)3);
			val7 = Expression.Parameter(typeof(Medication), "m");
			entity.HasQueryFilter(Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.Not((Expression)(object)Expression.Property((Expression)(object)val7, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val7 }));
		});
		modelBuilder.Entity<Reminder>((Action<EntityTypeBuilder<Reminder>>)delegate(EntityTypeBuilder<Reminder> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Expected O, but got Unknown
			ParameterExpression val6 = Expression.Parameter(typeof(Reminder), "r");
			entity.HasKey(Expression.Lambda<Func<Reminder, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 }));
			val6 = Expression.Parameter(typeof(Reminder), "r");
			ReferenceNavigationBuilder<Reminder, Medication> obj16 = entity.HasOne<Medication>(Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 }));
			val6 = Expression.Parameter(typeof(Medication), "m");
			ReferenceCollectionBuilder<Medication, Reminder> obj17 = obj16.WithMany(Expression.Lambda<Func<Medication, global::System.Collections.Generic.IEnumerable<Reminder>>>((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 }));
			val6 = Expression.Parameter(typeof(Reminder), "r");
			obj17.HasForeignKey(Expression.Lambda<Func<Reminder, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 })).OnDelete((DeleteBehavior)3);
			val6 = Expression.Parameter(typeof(Reminder), "r");
			ReferenceNavigationBuilder<Reminder, User> obj18 = entity.HasOne<User>(Expression.Lambda<Func<Reminder, User>>((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 }));
			val6 = Expression.Parameter(typeof(User), "u");
			ReferenceCollectionBuilder<User, Reminder> obj19 = obj18.WithMany(Expression.Lambda<Func<User, global::System.Collections.Generic.IEnumerable<Reminder>>>((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 }));
			val6 = Expression.Parameter(typeof(Reminder), "r");
			obj19.HasForeignKey(Expression.Lambda<Func<Reminder, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val6 })).OnDelete((DeleteBehavior)5);
			val6 = Expression.Parameter(typeof(Reminder), "r");
			entity.HasQueryFilter(Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.Not((Expression)(object)Expression.Property((Expression)(object)val6, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val6 }));
		});
		modelBuilder.Entity<DrugInteraction>((Action<EntityTypeBuilder<DrugInteraction>>)delegate(EntityTypeBuilder<DrugInteraction> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			ParameterExpression val5 = Expression.Parameter(typeof(DrugInteraction), "d");
			entity.HasKey(Expression.Lambda<Func<DrugInteraction, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 }));
			val5 = Expression.Parameter(typeof(DrugInteraction), "d");
			ReferenceNavigationBuilder<DrugInteraction, Medication> obj12 = entity.HasOne<Medication>(Expression.Lambda<Func<DrugInteraction, Medication>>((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 }));
			val5 = Expression.Parameter(typeof(Medication), "m");
			ReferenceCollectionBuilder<Medication, DrugInteraction> obj13 = obj12.WithMany(Expression.Lambda<Func<Medication, global::System.Collections.Generic.IEnumerable<DrugInteraction>>>((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 }));
			val5 = Expression.Parameter(typeof(DrugInteraction), "d");
			obj13.HasForeignKey(Expression.Lambda<Func<DrugInteraction, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 })).OnDelete((DeleteBehavior)5);
			val5 = Expression.Parameter(typeof(DrugInteraction), "d");
			ReferenceNavigationBuilder<DrugInteraction, Medication> obj14 = entity.HasOne<Medication>(Expression.Lambda<Func<DrugInteraction, Medication>>((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 }));
			val5 = Expression.Parameter(typeof(Medication), "m");
			ReferenceCollectionBuilder<Medication, DrugInteraction> obj15 = obj14.WithMany(Expression.Lambda<Func<Medication, global::System.Collections.Generic.IEnumerable<DrugInteraction>>>((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 }));
			val5 = Expression.Parameter(typeof(DrugInteraction), "d");
			obj15.HasForeignKey(Expression.Lambda<Func<DrugInteraction, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val5, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val5 })).OnDelete((DeleteBehavior)5);
		});
		modelBuilder.Entity<IngredientInteraction>((Action<EntityTypeBuilder<IngredientInteraction>>)delegate(EntityTypeBuilder<IngredientInteraction> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected O, but got Unknown
			ParameterExpression val4 = Expression.Parameter(typeof(IngredientInteraction), "i");
			entity.HasKey(Expression.Lambda<Func<IngredientInteraction, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val4 }));
			val4 = Expression.Parameter(typeof(IngredientInteraction), "i");
			ReferenceNavigationBuilder<IngredientInteraction, ActiveIngredient> obj9 = entity.HasOne<ActiveIngredient>(Expression.Lambda<Func<IngredientInteraction, ActiveIngredient>>((Expression)(object)Expression.Property((Expression)(object)val4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val4 }));
			val4 = Expression.Parameter(typeof(ActiveIngredient), "a");
			ReferenceCollectionBuilder<ActiveIngredient, IngredientInteraction> obj10 = obj9.WithMany(Expression.Lambda<Func<ActiveIngredient, global::System.Collections.Generic.IEnumerable<IngredientInteraction>>>((Expression)(object)Expression.Property((Expression)(object)val4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val4 }));
			val4 = Expression.Parameter(typeof(IngredientInteraction), "i");
			obj10.HasForeignKey(Expression.Lambda<Func<IngredientInteraction, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val4 })).OnDelete((DeleteBehavior)5);
			val4 = Expression.Parameter(typeof(IngredientInteraction), "i");
			ReferenceCollectionBuilder<ActiveIngredient, IngredientInteraction> obj11 = entity.HasOne<ActiveIngredient>(Expression.Lambda<Func<IngredientInteraction, ActiveIngredient>>((Expression)(object)Expression.Property((Expression)(object)val4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val4 })).WithMany((string)null);
			val4 = Expression.Parameter(typeof(IngredientInteraction), "i");
			obj11.HasForeignKey(Expression.Lambda<Func<IngredientInteraction, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val4, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val4 })).OnDelete((DeleteBehavior)5);
		});
		modelBuilder.Entity<EmergencyAlert>((Action<EntityTypeBuilder<EmergencyAlert>>)delegate(EntityTypeBuilder<EmergencyAlert> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			ParameterExpression val3 = Expression.Parameter(typeof(EmergencyAlert), "e");
			entity.HasKey(Expression.Lambda<Func<EmergencyAlert, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val3 }));
			val3 = Expression.Parameter(typeof(EmergencyAlert), "e");
			ReferenceNavigationBuilder<EmergencyAlert, User> obj7 = entity.HasOne<User>(Expression.Lambda<Func<EmergencyAlert, User>>((Expression)(object)Expression.Property((Expression)(object)val3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val3 }));
			val3 = Expression.Parameter(typeof(User), "u");
			ReferenceCollectionBuilder<User, EmergencyAlert> obj8 = obj7.WithMany(Expression.Lambda<Func<User, global::System.Collections.Generic.IEnumerable<EmergencyAlert>>>((Expression)(object)Expression.Property((Expression)(object)val3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val3 }));
			val3 = Expression.Parameter(typeof(EmergencyAlert), "e");
			obj8.HasForeignKey(Expression.Lambda<Func<EmergencyAlert, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val3 })).OnDelete((DeleteBehavior)3);
		});
		modelBuilder.Entity<CaregiverRelationship>((Action<EntityTypeBuilder<CaregiverRelationship>>)delegate(EntityTypeBuilder<CaregiverRelationship> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Expected O, but got Unknown
			//IL_0246: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Expected O, but got Unknown
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Expected O, but got Unknown
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Expected O, but got Unknown
			//IL_028a: Expected O, but got Unknown
			ParameterExpression val2 = Expression.Parameter(typeof(CaregiverRelationship), "c");
			entity.HasKey(Expression.Lambda<Func<CaregiverRelationship, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 }));
			val2 = Expression.Parameter(typeof(CaregiverRelationship), "c");
			ReferenceNavigationBuilder<CaregiverRelationship, User> obj3 = entity.HasOne<User>(Expression.Lambda<Func<CaregiverRelationship, User>>((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 }));
			val2 = Expression.Parameter(typeof(User), "u");
			ReferenceCollectionBuilder<User, CaregiverRelationship> obj4 = obj3.WithMany(Expression.Lambda<Func<User, global::System.Collections.Generic.IEnumerable<CaregiverRelationship>>>((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 }));
			val2 = Expression.Parameter(typeof(CaregiverRelationship), "c");
			obj4.HasForeignKey(Expression.Lambda<Func<CaregiverRelationship, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 })).OnDelete((DeleteBehavior)5);
			val2 = Expression.Parameter(typeof(CaregiverRelationship), "c");
			ReferenceNavigationBuilder<CaregiverRelationship, User> obj5 = entity.HasOne<User>(Expression.Lambda<Func<CaregiverRelationship, User>>((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 }));
			val2 = Expression.Parameter(typeof(User), "u");
			ReferenceCollectionBuilder<User, CaregiverRelationship> obj6 = obj5.WithMany(Expression.Lambda<Func<User, global::System.Collections.Generic.IEnumerable<CaregiverRelationship>>>((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 }));
			val2 = Expression.Parameter(typeof(CaregiverRelationship), "c");
			obj6.HasForeignKey(Expression.Lambda<Func<CaregiverRelationship, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val2 })).OnDelete((DeleteBehavior)5);
			val2 = Expression.Parameter(typeof(CaregiverRelationship), "c");
			entity.HasIndex(Expression.Lambda<Func<CaregiverRelationship, object>>((Expression)(object)Expression.New((ConstructorInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType2<int, int>).TypeHandle), (global::System.Collections.Generic.IEnumerable<Expression>)(object)new Expression[2]
			{
				(Expression)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)),
				(Expression)Expression.Property((Expression)(object)val2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))
			}, (MemberInfo[])(object)new MemberInfo[2]
			{
				(MemberInfo)(MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType2<int, int>).TypeHandle),
				(MemberInfo)(MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(_003C_003Ef__AnonymousType2<int, int>).TypeHandle)
			}), (ParameterExpression[])(object)new ParameterExpression[1] { val2 })).IsUnique(true);
		});
		modelBuilder.Entity<ChatHistory>((Action<EntityTypeBuilder<ChatHistory>>)delegate(EntityTypeBuilder<ChatHistory> entity)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Expected O, but got Unknown
			ParameterExpression val = Expression.Parameter(typeof(ChatHistory), "c");
			entity.HasKey(Expression.Lambda<Func<ChatHistory, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
			val = Expression.Parameter(typeof(ChatHistory), "c");
			ReferenceNavigationBuilder<ChatHistory, User> obj = entity.HasOne<User>(Expression.Lambda<Func<ChatHistory, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
			val = Expression.Parameter(typeof(User), "u");
			ReferenceCollectionBuilder<User, ChatHistory> obj2 = obj.WithMany(Expression.Lambda<Func<User, global::System.Collections.Generic.IEnumerable<ChatHistory>>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
			val = Expression.Parameter(typeof(ChatHistory), "c");
			obj2.HasForeignKey(Expression.Lambda<Func<ChatHistory, object>>((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), (ParameterExpression[])(object)new ParameterExpression[1] { val })).OnDelete((DeleteBehavior)3);
			val = Expression.Parameter(typeof(ChatHistory), "c");
			entity.HasQueryFilter(Expression.Lambda<Func<ChatHistory, bool>>((Expression)(object)Expression.Not((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		});
	}
}
