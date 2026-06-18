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
using MedWise.Core.Enums;
using MedWise.Core.Interfaces;
using MedWise.Core.Models;
using MedWise.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;

namespace MedWise.Infrastructure.Repositories;

public class ReminderRepository : Repository<Reminder>, IReminderRepository, IRepository<Reminder>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int userId;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public int userId;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetActiveRemindersAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<Reminder>> _003C_003Et__builder;

		public ReminderRepository _003C_003E4__this;

		private TaskAwaiter<List<Reminder>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ReminderRepository reminderRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<Reminder> result2;
			try
			{
				TaskAwaiter<List<Reminder>> awaiter;
				if (num != 0)
				{
					DbSet<Reminder> dbSet = reminderRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(Reminder), "r");
					IQueryable<Reminder> obj = Queryable.Where<Reminder>((IQueryable<Reminder>)(object)dbSet, Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(Reminder), "r");
					IIncludableQueryable<Reminder, User> obj2 = EntityFrameworkQueryableExtensions.Include<Reminder, User>(obj, Expression.Lambda<Func<Reminder, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(Reminder), "r");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<Reminder>((IQueryable<Reminder>)(object)EntityFrameworkQueryableExtensions.Include<Reminder, Medication>((IQueryable<Reminder>)(object)obj2, Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Reminder>>, _003CGetActiveRemindersAsync_003Ed__3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<Reminder>>);
					num = (_003C_003E1__state = -1);
				}
				List<Reminder> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<Reminder>)result;
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

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<Reminder>> _003C_003Et__builder;

		public int userId;

		public ReminderRepository _003C_003E4__this;

		private TaskAwaiter<List<Reminder>> _003C_003Eu__1;

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
			ReminderRepository reminderRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<Reminder> result2;
			try
			{
				TaskAwaiter<List<Reminder>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						userId = userId
					};
					DbSet<Reminder> dbSet = reminderRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(Reminder), "r");
					IQueryable<Reminder> obj = Queryable.Where<Reminder>((IQueryable<Reminder>)(object)dbSet, Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(Reminder), "r");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<Reminder>((IQueryable<Reminder>)(object)EntityFrameworkQueryableExtensions.Include<Reminder, Medication>(obj, Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Reminder>>, _003CGetByUserIdAsync_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<Reminder>>);
					num = (_003C_003E1__state = -1);
				}
				List<Reminder> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<Reminder>)result;
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
	private struct _003CGetTodayRemindersAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<Reminder>> _003C_003Et__builder;

		public int userId;

		public ReminderRepository _003C_003E4__this;

		private TaskAwaiter<List<Reminder>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected O, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ReminderRepository reminderRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<Reminder> result2;
			try
			{
				TaskAwaiter<List<Reminder>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0
					{
						userId = userId
					};
					DbSet<Reminder> dbSet = reminderRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(Reminder), "r");
					IQueryable<Reminder> obj = Queryable.Where<Reminder>((IQueryable<Reminder>)(object)dbSet, Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(Reminder), "r");
					IIncludableQueryable<Reminder, Medication> obj2 = EntityFrameworkQueryableExtensions.Include<Reminder, Medication>(obj, Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(Reminder), "r");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<Reminder>((IQueryable<Reminder>)(object)Queryable.OrderBy<Reminder, TimeSpan>((IQueryable<Reminder>)(object)obj2, Expression.Lambda<Func<Reminder, TimeSpan>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Reminder>>, _003CGetTodayRemindersAsync_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<Reminder>>);
					num = (_003C_003E1__state = -1);
				}
				List<Reminder> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<Reminder>)result;
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
	private struct _003CUpdateStatusAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ReminderRepository _003C_003E4__this;

		public int reminderId;

		public ReminderStatus status;

		private TaskAwaiter<Reminder?> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private ValueTaskAwaiter<EntityEntry<ReminderLog>> _003C_003Eu__3;

		private TaskAwaiter<int> _003C_003Eu__4;

		private void MoveNext()
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ReminderRepository reminderRepository = _003C_003E4__this;
			try
			{
				TaskAwaiter<Reminder> awaiter4;
				TaskAwaiter awaiter3;
				ValueTaskAwaiter<EntityEntry<ReminderLog>> awaiter2;
				TaskAwaiter<int> awaiter;
				Reminder result;
				Reminder reminder;
				switch (num)
				{
				default:
					awaiter4 = reminderRepository.GetByIdAsync(reminderId).GetAwaiter();
					if (!awaiter4.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Reminder>, _003CUpdateStatusAsync_003Ed__4>(ref awaiter4, ref this);
						return;
					}
					goto IL_0081;
				case 0:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Reminder>);
					num = (_003C_003E1__state = -1);
					goto IL_0081;
				case 1:
					awaiter3 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0105;
				case 2:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default(ValueTaskAwaiter<EntityEntry<ReminderLog>>);
					num = (_003C_003E1__state = -1);
					goto IL_01a3;
				case 3:
					{
						awaiter = _003C_003Eu__4;
						_003C_003Eu__4 = default(TaskAwaiter<int>);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_01a3:
					awaiter2.GetResult();
					awaiter = ((DbContext)reminderRepository._context).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__4 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CUpdateStatusAsync_003Ed__4>(ref awaiter, ref this);
						return;
					}
					break;
					IL_0081:
					result = awaiter4.GetResult();
					reminder = result;
					if (reminder != null)
					{
						reminder.Status = status;
						reminder.LastTriggered = global::System.DateTime.UtcNow;
						awaiter3 = reminderRepository.UpdateAsync(reminder).GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CUpdateStatusAsync_003Ed__4>(ref awaiter3, ref this);
							return;
						}
						goto IL_0105;
					}
					goto end_IL_000e;
					IL_0105:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					awaiter2 = reminderRepository._context.ReminderLogs.AddAsync(new ReminderLog
					{
						ReminderId = reminderId,
						Status = status,
						TriggeredAt = global::System.DateTime.UtcNow
					}, default(CancellationToken)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__3 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<ValueTaskAwaiter<EntityEntry<ReminderLog>>, _003CUpdateStatusAsync_003Ed__4>(ref awaiter2, ref this);
						return;
					}
					goto IL_01a3;
				}
				awaiter.GetResult();
				end_IL_000e:;
			}
			catch (global::System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	public ReminderRepository(ApplicationDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CGetByUserIdAsync_003Ed__1))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Reminder>> GetByUserIdAsync(int userId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.userId = userId;
		DbSet<Reminder> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(Reminder), "r");
		IQueryable<Reminder> obj = Queryable.Where<Reminder>((IQueryable<Reminder>)(object)dbSet, Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Reminder), "r");
		return (global::System.Collections.Generic.IEnumerable<Reminder>)(await EntityFrameworkQueryableExtensions.ToListAsync<Reminder>((IQueryable<Reminder>)(object)EntityFrameworkQueryableExtensions.Include<Reminder, Medication>(obj, Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CGetTodayRemindersAsync_003Ed__2))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Reminder>> GetTodayRemindersAsync(int userId)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
		_003C_003Ec__DisplayClass2_.userId = userId;
		DbSet<Reminder> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(Reminder), "r");
		IQueryable<Reminder> obj = Queryable.Where<Reminder>((IQueryable<Reminder>)(object)dbSet, Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.AndAlso((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass2_, typeof(_003C_003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Reminder), "r");
		IIncludableQueryable<Reminder, Medication> obj2 = EntityFrameworkQueryableExtensions.Include<Reminder, Medication>(obj, Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Reminder), "r");
		return (global::System.Collections.Generic.IEnumerable<Reminder>)(await EntityFrameworkQueryableExtensions.ToListAsync<Reminder>((IQueryable<Reminder>)(object)Queryable.OrderBy<Reminder, TimeSpan>((IQueryable<Reminder>)(object)obj2, Expression.Lambda<Func<Reminder, TimeSpan>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CGetActiveRemindersAsync_003Ed__3))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<Reminder>> GetActiveRemindersAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DbSet<Reminder> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(Reminder), "r");
		IQueryable<Reminder> obj = Queryable.Where<Reminder>((IQueryable<Reminder>)(object)dbSet, Expression.Lambda<Func<Reminder, bool>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Reminder), "r");
		IIncludableQueryable<Reminder, User> obj2 = EntityFrameworkQueryableExtensions.Include<Reminder, User>(obj, Expression.Lambda<Func<Reminder, User>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(Reminder), "r");
		return (global::System.Collections.Generic.IEnumerable<Reminder>)(await EntityFrameworkQueryableExtensions.ToListAsync<Reminder>((IQueryable<Reminder>)(object)EntityFrameworkQueryableExtensions.Include<Reminder, Medication>((IQueryable<Reminder>)(object)obj2, Expression.Lambda<Func<Reminder, Medication>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), default(CancellationToken)));
	}

	[AsyncStateMachine(typeof(_003CUpdateStatusAsync_003Ed__4))]
	public global::System.Threading.Tasks.Task UpdateStatusAsync(int reminderId, ReminderStatus status)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CUpdateStatusAsync_003Ed__4 _003CUpdateStatusAsync_003Ed__ = default(_003CUpdateStatusAsync_003Ed__4);
		_003CUpdateStatusAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CUpdateStatusAsync_003Ed__._003C_003E4__this = this;
		_003CUpdateStatusAsync_003Ed__.reminderId = reminderId;
		_003CUpdateStatusAsync_003Ed__.status = status;
		_003CUpdateStatusAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CUpdateStatusAsync_003Ed__._003C_003Et__builder)).Start<_003CUpdateStatusAsync_003Ed__4>(ref _003CUpdateStatusAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CUpdateStatusAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
