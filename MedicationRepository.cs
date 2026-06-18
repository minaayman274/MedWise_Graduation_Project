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

public class MedicationRepository : Repository<Medication>, IMedicationRepository, IRepository<Medication>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int userId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string name;

		public int userId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public int userId;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetActiveByUserIdAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<Medication>> _003C_003Et__builder;

		public int userId;

		public MedicationRepository _003C_003E4__this;

		private TaskAwaiter<List<Medication>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MedicationRepository medicationRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<Medication> result2;
			try
			{
				TaskAwaiter<List<Medication>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0
					{
						userId = userId
					};
					DbSet<Medication> dbSet = medicationRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(Medication), "m");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<Medication>(Queryable.Where<Medication>((IQueryable<Medication>)(object)dbSet, Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Medication>>, _003CGetActiveByUserIdAsync_003Ed__3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<Medication>>);
					num = (_003C_003E1__state = -1);
				}
				List<Medication> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<Medication>)result;
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
	private struct _003CGetByNameAndUserAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Medication> _003C_003Et__builder;

		public string name;

		public int userId;

		public MedicationRepository _003C_003E4__this;

		private TaskAwaiter<Medication?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected O, but got Unknown
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MedicationRepository medicationRepository = _003C_003E4__this;
			Medication result2;
			try
			{
				TaskAwaiter<Medication> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0
					{
						name = name,
						userId = userId
					};
					DbSet<Medication> dbSet = medicationRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(Medication), "m");
					awaiter = EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<Medication>((IQueryable<Medication>)(object)dbSet, Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Medication>, _003CGetByNameAndUserAsync_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Medication>);
					num = (_003C_003E1__state = -1);
				}
				Medication result = awaiter.GetResult();
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetByUserIdAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<Medication>> _003C_003Et__builder;

		public int userId;

		public MedicationRepository _003C_003E4__this;

		private TaskAwaiter<List<Medication>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MedicationRepository medicationRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<Medication> result2;
			try
			{
				TaskAwaiter<List<Medication>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						userId = userId
					};
					DbSet<Medication> dbSet = medicationRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(Medication), "m");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<Medication>(Queryable.Where<Medication>((IQueryable<Medication>)(object)dbSet, Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Medication>>, _003CGetByUserIdAsync_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<Medication>>);
					num = (_003C_003E1__state = -1);
				}
				List<Medication> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<Medication>)result;
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

	public MedicationRepository(ApplicationDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CGetByUserIdAsync_003Ed__1))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Medication>> GetByUserIdAsync(int userId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.userId = userId;
		DbSet<Medication> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(Medication), "m");
		return (global::System.Collections.Generic.IEnumerable<Medication>)(await EntityFrameworkQueryableExtensions.ToListAsync<Medication>(Queryable.Where<Medication>((IQueryable<Medication>)(object)dbSet, Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CGetByNameAndUserAsync_003Ed__2))]
	public async global::System.Threading.Tasks.Task<Medication?> GetByNameAndUserAsync(string name, int userId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.name = name;
		_003C_003Ec__DisplayClass2_.userId = userId;
		DbSet<Medication> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(Medication), "m");
		return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<Medication>((IQueryable<Medication>)(object)dbSet, Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}

	[AsyncStateMachine(typeof(_003CGetActiveByUserIdAsync_003Ed__3))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Medication>> GetActiveByUserIdAsync(int userId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.userId = userId;
		DbSet<Medication> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(Medication), "m");
		return (global::System.Collections.Generic.IEnumerable<Medication>)(await EntityFrameworkQueryableExtensions.ToListAsync<Medication>(Queryable.Where<Medication>((IQueryable<Medication>)(object)dbSet, Expression.Lambda<Func<Medication, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}
}
