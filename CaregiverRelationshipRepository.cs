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

public class CaregiverRelationshipRepository : Repository<CaregiverRelationship>, ICaregiverRelationshipRepository, IRepository<CaregiverRelationship>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int caregiverId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public int patientId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public int caregiverId;

		public int patientId;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetByCaregiversIdAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<CaregiverRelationship>> _003C_003Et__builder;

		public int caregiverId;

		public CaregiverRelationshipRepository _003C_003E4__this;

		private TaskAwaiter<List<CaregiverRelationship>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverRelationshipRepository caregiverRelationshipRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<CaregiverRelationship> result2;
			try
			{
				TaskAwaiter<List<CaregiverRelationship>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						caregiverId = caregiverId
					};
					DbSet<CaregiverRelationship> dbSet = caregiverRelationshipRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "c");
					IQueryable<CaregiverRelationship> obj = Queryable.Where<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)dbSet, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(CaregiverRelationship), "c");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)EntityFrameworkQueryableExtensions.Include<CaregiverRelationship, User>(obj, Expression.Lambda<Func<CaregiverRelationship, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<CaregiverRelationship>>, _003CGetByCaregiversIdAsync_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<CaregiverRelationship>>);
					num = (_003C_003E1__state = -1);
				}
				List<CaregiverRelationship> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<CaregiverRelationship>)result;
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
	private struct _003CGetByPatientIdAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<CaregiverRelationship>> _003C_003Et__builder;

		public int patientId;

		public CaregiverRelationshipRepository _003C_003E4__this;

		private TaskAwaiter<List<CaregiverRelationship>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverRelationshipRepository caregiverRelationshipRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<CaregiverRelationship> result2;
			try
			{
				TaskAwaiter<List<CaregiverRelationship>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0
					{
						patientId = patientId
					};
					DbSet<CaregiverRelationship> dbSet = caregiverRelationshipRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "c");
					IQueryable<CaregiverRelationship> obj = Queryable.Where<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)dbSet, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(CaregiverRelationship), "c");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)EntityFrameworkQueryableExtensions.Include<CaregiverRelationship, User>(obj, Expression.Lambda<Func<CaregiverRelationship, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<CaregiverRelationship>>, _003CGetByPatientIdAsync_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<CaregiverRelationship>>);
					num = (_003C_003E1__state = -1);
				}
				List<CaregiverRelationship> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<CaregiverRelationship>)result;
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
	private struct _003CRelationshipExistsAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public int caregiverId;

		public int patientId;

		public CaregiverRelationshipRepository _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CaregiverRelationshipRepository caregiverRelationshipRepository = _003C_003E4__this;
			bool result2;
			try
			{
				TaskAwaiter<bool> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0
					{
						caregiverId = caregiverId,
						patientId = patientId
					};
					DbSet<CaregiverRelationship> dbSet = caregiverRelationshipRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "c");
					awaiter = EntityFrameworkQueryableExtensions.AnyAsync<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)dbSet, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _003CRelationshipExistsAsync_003Ed__3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<bool>);
					num = (_003C_003E1__state = -1);
				}
				bool result = awaiter.GetResult();
				result2 = result;
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

	public CaregiverRelationshipRepository(ApplicationDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CGetByCaregiversIdAsync_003Ed__1))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<CaregiverRelationship>> GetByCaregiversIdAsync(int caregiverId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.caregiverId = caregiverId;
		DbSet<CaregiverRelationship> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "c");
		IQueryable<CaregiverRelationship> obj = Queryable.Where<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)dbSet, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(CaregiverRelationship), "c");
		return (global::System.Collections.Generic.IEnumerable<CaregiverRelationship>)(await EntityFrameworkQueryableExtensions.ToListAsync<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)EntityFrameworkQueryableExtensions.Include<CaregiverRelationship, User>(obj, Expression.Lambda<Func<CaregiverRelationship, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CGetByPatientIdAsync_003Ed__2))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<CaregiverRelationship>> GetByPatientIdAsync(int patientId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.patientId = patientId;
		DbSet<CaregiverRelationship> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "c");
		IQueryable<CaregiverRelationship> obj = Queryable.Where<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)dbSet, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(CaregiverRelationship), "c");
		return (global::System.Collections.Generic.IEnumerable<CaregiverRelationship>)(await EntityFrameworkQueryableExtensions.ToListAsync<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)EntityFrameworkQueryableExtensions.Include<CaregiverRelationship, User>(obj, Expression.Lambda<Func<CaregiverRelationship, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CRelationshipExistsAsync_003Ed__3))]
	public async global::System.Threading.Tasks.Task<bool> RelationshipExistsAsync(int caregiverId, int patientId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.caregiverId = caregiverId;
		_003C_003Ec__DisplayClass3_.patientId = patientId;
		DbSet<CaregiverRelationship> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(CaregiverRelationship), "c");
		return await EntityFrameworkQueryableExtensions.AnyAsync<CaregiverRelationship>((IQueryable<CaregiverRelationship>)(object)dbSet, Expression.Lambda<Func<CaregiverRelationship, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}
}
