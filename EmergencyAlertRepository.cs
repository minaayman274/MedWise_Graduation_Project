using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using MedWise.Core.Interfaces;
using MedWise.Core.Models;
using MedWise.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MedWise.Infrastructure.Repositories;

public class EmergencyAlertRepository : Repository<EmergencyAlert>, IEmergencyAlertRepository, IRepository<EmergencyAlert>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int patientId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public int caregiverId;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetByPatientIdAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<EmergencyAlert>> _003C_003Et__builder;

		public int patientId;

		public EmergencyAlertRepository _003C_003E4__this;

		private TaskAwaiter<List<EmergencyAlert>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			EmergencyAlertRepository emergencyAlertRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<EmergencyAlert> result2;
			try
			{
				TaskAwaiter<List<EmergencyAlert>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						patientId = patientId
					};
					DbSet<EmergencyAlert> dbSet = emergencyAlertRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(EmergencyAlert), "e");
					IQueryable<EmergencyAlert> obj = Queryable.Where<EmergencyAlert>((IQueryable<EmergencyAlert>)(object)dbSet, Expression.Lambda<Func<EmergencyAlert, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(EmergencyAlert), "e");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<EmergencyAlert>((IQueryable<EmergencyAlert>)(object)Queryable.OrderByDescending<EmergencyAlert, global::System.DateTime>(obj, Expression.Lambda<Func<EmergencyAlert, global::System.DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<EmergencyAlert>>, _003CGetByPatientIdAsync_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<EmergencyAlert>>);
					num = (_003C_003E1__state = -1);
				}
				List<EmergencyAlert> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<EmergencyAlert>)result;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetPendingAlertsAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<EmergencyAlert>> _003C_003Et__builder;

		public int caregiverId;

		public EmergencyAlertRepository _003C_003E4__this;

		private TaskAwaiter<List<EmergencyAlert>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			EmergencyAlertRepository emergencyAlertRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<EmergencyAlert> result2;
			try
			{
				TaskAwaiter<List<EmergencyAlert>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0
					{
						caregiverId = caregiverId
					};
					DbSet<CaregiverRelationship> caregiverRelationships = emergencyAlertRepository._context.CaregiverRelationships;
					ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "cr");
					IQueryable<CaregiverRelationship> obj = Queryable.Where<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)caregiverRelationships, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(CaregiverRelationship), "cr");
					IQueryable<EmergencyAlert> obj2 = Queryable.SelectMany<CaregiverRelationship, EmergencyAlert>(obj, Expression.Lambda<Func<CaregiverRelationship, global::System.Collections.Generic.IEnumerable<EmergencyAlert>>>((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(EmergencyAlert), "e");
					IQueryable<EmergencyAlert> obj3 = Queryable.Where<EmergencyAlert>(obj2, Expression.Lambda<Func<EmergencyAlert, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(int)), (Expression)(object)Expression.Constant((object)0, typeof(int))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(EmergencyAlert), "e");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<EmergencyAlert>((IQueryable<EmergencyAlert>)(object)Queryable.OrderByDescending<EmergencyAlert, global::System.DateTime>(obj3, Expression.Lambda<Func<EmergencyAlert, global::System.DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<EmergencyAlert>>, _003CGetPendingAlertsAsync_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<EmergencyAlert>>);
					num = (_003C_003E1__state = -1);
				}
				List<EmergencyAlert> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<EmergencyAlert>)result;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	public EmergencyAlertRepository(ApplicationDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CGetByPatientIdAsync_003Ed__1))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<EmergencyAlert>> GetByPatientIdAsync(int patientId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.patientId = patientId;
		DbSet<EmergencyAlert> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(EmergencyAlert), "e");
		IQueryable<EmergencyAlert> obj = Queryable.Where<EmergencyAlert>((IQueryable<EmergencyAlert>)(object)dbSet, Expression.Lambda<Func<EmergencyAlert, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(EmergencyAlert), "e");
		return (global::System.Collections.Generic.IEnumerable<EmergencyAlert>)(await EntityFrameworkQueryableExtensions.ToListAsync<EmergencyAlert>((IQueryable<EmergencyAlert>)(object)Queryable.OrderByDescending<EmergencyAlert, global::System.DateTime>(obj, Expression.Lambda<Func<EmergencyAlert, global::System.DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CGetPendingAlertsAsync_003Ed__2))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<EmergencyAlert>> GetPendingAlertsAsync(int caregiverId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.caregiverId = caregiverId;
		DbSet<CaregiverRelationship> caregiverRelationships = _context.CaregiverRelationships;
		ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "cr");
		IQueryable<CaregiverRelationship> obj = Queryable.Where<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)caregiverRelationships, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(CaregiverRelationship), "cr");
		IQueryable<EmergencyAlert> obj2 = Queryable.SelectMany<CaregiverRelationship, EmergencyAlert>(obj, Expression.Lambda<Func<CaregiverRelationship, global::System.Collections.Generic.IEnumerable<EmergencyAlert>>>((Expression)(object)Expression.Property((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(EmergencyAlert), "e");
		IQueryable<EmergencyAlert> obj3 = Queryable.Where<EmergencyAlert>(obj2, Expression.Lambda<Func<EmergencyAlert, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(int)), (Expression)(object)Expression.Constant((object)0, typeof(int))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(EmergencyAlert), "e");
		return (global::System.Collections.Generic.IEnumerable<EmergencyAlert>)(await EntityFrameworkQueryableExtensions.ToListAsync<EmergencyAlert>((IQueryable<EmergencyAlert>)(object)Queryable.OrderByDescending<EmergencyAlert, global::System.DateTime>(obj3, Expression.Lambda<Func<EmergencyAlert, global::System.DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}
}
