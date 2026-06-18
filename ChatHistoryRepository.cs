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

public class ChatHistoryRepository : Repository<ChatHistory>, IChatHistoryRepository, IRepository<ChatHistory>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public int userId;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CGetByUserIdAsync_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<global::System.Collections.Generic.IEnumerable<ChatHistory>> _003C_003Et__builder;

		public int userId;

		public ChatHistoryRepository _003C_003E4__this;

		public int pageSize;

		private TaskAwaiter<List<ChatHistory>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ChatHistoryRepository chatHistoryRepository = _003C_003E4__this;
			global::System.Collections.Generic.IEnumerable<ChatHistory> result2;
			try
			{
				TaskAwaiter<List<ChatHistory>> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						userId = userId
					};
					DbSet<ChatHistory> dbSet = chatHistoryRepository._dbSet;
					ParameterExpression val = Expression.Parameter(typeof(ChatHistory), "c");
					IQueryable<ChatHistory> obj = Queryable.Where<ChatHistory>((IQueryable<ChatHistory>)(object)dbSet, Expression.Lambda<Func<ChatHistory, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					val = Expression.Parameter(typeof(ChatHistory), "c");
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<ChatHistory>(Queryable.Take<ChatHistory>((IQueryable<ChatHistory>)(object)Queryable.OrderByDescending<ChatHistory, global::System.DateTime>(obj, Expression.Lambda<Func<ChatHistory, global::System.DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), pageSize), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ChatHistory>>, _003CGetByUserIdAsync_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ChatHistory>>);
					num = (_003C_003E1__state = -1);
				}
				List<ChatHistory> result = awaiter.GetResult();
				result2 = (global::System.Collections.Generic.IEnumerable<ChatHistory>)result;
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

	public ChatHistoryRepository(ApplicationDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CGetByUserIdAsync_003Ed__1))]
	public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<ChatHistory>> GetByUserIdAsync(int userId, int pageSize = 50)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.userId = userId;
		DbSet<ChatHistory> dbSet = _dbSet;
		ParameterExpression val = Expression.Parameter(typeof(ChatHistory), "c");
		IQueryable<ChatHistory> obj = Queryable.Where<ChatHistory>((IQueryable<ChatHistory>)(object)dbSet, Expression.Lambda<Func<ChatHistory, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
		val = Expression.Parameter(typeof(ChatHistory), "c");
		return (global::System.Collections.Generic.IEnumerable<ChatHistory>)(await EntityFrameworkQueryableExtensions.ToListAsync<ChatHistory>(Queryable.Take<ChatHistory>((IQueryable<ChatHistory>)(object)Queryable.OrderByDescending<ChatHistory, global::System.DateTime>(obj, Expression.Lambda<Func<ChatHistory, global::System.DateTime>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val })), pageSize), default(CancellationToken)));
	}
}
